using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;


/// <summary>
/// A basic IDS which will recognize any modification to a file.
/// References https://www.irjet.net/archives/V7/i6/IRJET-V7I6925.pdf
///            https://en.wikipedia.org/wiki/MD5
/// </summary>
namespace SimpleIDS
{
    public partial class MainForm : Form
    {
        private readonly string allowedPaths = "*.config; *.sys,; *.exe";
        private string pathToScan = "";
        public MainForm()
        {
            InitializeComponent();
            Initialize();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
        }
        private void startScanButton_Click(object sender, EventArgs e)
        {
            // textboxa girilen değerin uzunluğu 0 dan büyükse
            if (scanPath.Text.Length > 0)
            {
                // tablo temizlenir
                Tbl_Result.Rows.Clear();

                // textboxa girilen değer dosya yoluna çevrilir. Validate amaçlı
                pathToScan = Path.Combine(scanPath.Text, "");

                //ilgili dosya yolundaki dosyalar taranır
                ScanAllFiles();

                //ilgili dosya yolu dinlenmeye başlar
                WatchFolder();

                // dinleme süresince buton disable edilir.
                startScanButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid folder path!");
            }
        }


        private void ScanAllFiles()
        {
            if (Directory.Exists(pathToScan))
            {
                // hedef klasörde izin verilen uzantılı dosyaları tara
                var allowedExtensions = new List<string> { "exe", "sys", "config" };

                // bulunan her bir uygun dosya için tam dosya yolu ve kısa dosya adlarını al
                var foundFiles = Directory
                    .EnumerateFiles(pathToScan)
                    .Where(s => allowedExtensions.Contains(Path.GetExtension(s).TrimStart('.').ToLowerInvariant()))
                    .Select(x => new
                    {
                        fileName = Path.GetFullPath(x),
                        safeName = Path.GetFileName(x)
                    }).ToList();

                foreach (var item in foundFiles)
                {
                    // dosyalar tabloda yok ise ekle, var ise kıyasla
                    InsertToTable(item.fileName, item.safeName);
                }
            }
        }

        private void WatchFolder()
        {
            // izin verilen extensionlar
            string[] filters = { "*.exe", "*.sys", "*.config" };
            List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();


            // izin verilen extensionlar için dosya dinleyicileri oluştur.
            foreach (string f in filters)
            {
                FileSystemWatcher w = new FileSystemWatcher();
                w.Filter = f;

                w.NotifyFilter = NotifyFilters.LastWrite;
                w.Path = pathToScan;
                w.Changed += new FileSystemEventHandler(OnChanged);
                w.EnableRaisingEvents = true;
                watchers.Add(w);
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            // hedef klasörde değişiklik fark edilirse dosyaların hepsini tekrar tara
            ScanAllFiles();
        }
        public void InsertToTable(string fullFileName, string shortFileName)
        {
            try
            {
                using (MD5 md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(fullFileName))
                    {
                        // okunan ilk dosya için md5 oluştur
                        string checkMD5 = Encoding.Default.GetString(md5.ComputeHash(stream));
                        Tbl_Result.Visible = true;
                        Btn_Clear.Visible = true;


                        // tabloda dolan
                        foreach (DataGridViewRow row in Tbl_Result.Rows)
                        {
                            // mevcut okunan dosya tabloda var ise
                            if (shortFileName.Equals(row.Cells[0].Value ?? string.Empty))
                            {
                                // şu an oluşturulan md5 ile ilk oluşturduğumuz aynı değilse changed uyarısı ver
                                if (checkMD5 != row.Cells[1].Value.ToString())
                                {
                                    row.Cells[3].Value = "Changed";
                                    row.Cells[3].Style.BackColor = Color.Red;
                                    row.Cells[2].Value = checkMD5;
                                }
                                else
                                {
                                    row.Cells[3].Value = " ";
                                    row.Cells[3].Style.BackColor = Color.White;
                                    row.Cells[2].Value = " ";
                                }
                                return;
                            }
                        }

                        // tabloda bu kayıt olsaydı yukarıdaki return ile fonksiyondan çıkardık.
                        // demek ki tabloda bu yeni eklenen dosya yok. Bunu tabloya ekle
                        Tbl_Result.Rows.Add(shortFileName, checkMD5, "");
                    }
                }
            }
            catch (IOException)
            {

            }
        }
        #region others

        private void Btn_FileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = $"System files ({allowedPaths})|{allowedPaths}",
                RestoreDirectory = true
            };

            DialogResult result = ofd.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                FillResultTable(ofd.FileName, ofd.SafeFileName);
                CompareResultTable();
            }
        }

        public void FillResultTable(string fullFileName, string shortFileName)
        {
            try
            {
                using (MD5 md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(fullFileName))
                    {
                        string checkMD5 = Encoding.Default.GetString(md5.ComputeHash(stream));
                        Tbl_Result.Visible = true;
                        Btn_Clear.Visible = true;
                        foreach (DataGridViewRow row in Tbl_Result.Rows)
                        {
                            if (shortFileName.Equals(row.Cells[0].Value ?? string.Empty))
                            {
                                if (string.IsNullOrWhiteSpace(row.Cells[2].Value.ToString()))
                                {
                                    row.Cells[2].Value = checkMD5;
                                }
                                else
                                {
                                    row.Cells[2].Value = string.Empty;
                                    row.Cells[1].Value = checkMD5;
                                    row.Cells[3].Value = string.Empty;
                                    row.Cells[3].Style.BackColor = Color.Empty;
                                }
                                return;
                            }
                        }

                        Tbl_Result.Rows.Add(shortFileName, checkMD5, "");
                    }
                }
            }
            catch (IOException)
            {

            }
        }


       


        public void CompareResultTable()
        {
            Lbl_Result.Visible = true;
            Lbl_Result.Text = "COMPARISON RESULTS";
            Btn_Clear.Visible = true;

            try
            {
                foreach (DataGridViewRow row in Tbl_Result.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(row.Cells[1].Value?.ToString()) && !string.IsNullOrWhiteSpace(row.Cells[2].Value?.ToString()))
                    {
                        row.Cells[3].Style.BackColor = Color.Red;

                        row.Cells[3].Value = "Changed";

                        if (row.Cells[1].Value.Equals(row.Cells[2].Value))
                        {
                            row.Cells[3].Value = "Not Changed";
                            row.Cells[3].Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Initialize()
        {
            Lbl_download.Cursor = Cursors.Hand;
            Lbl_Result.Text = string.Empty;
            Tbl_Result.Visible = false;
            Lbl_Result.Visible = false;
            Tbl_Result.DefaultCellStyle.Font = new Font("Tahoma", 14);
            Tbl_Result.AutoResizeColumns();
            Tbl_Result.AutoResizeRows();
            Tbl_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Btn_Clear.Visible = false;

            initPicture(pictureBox_acrobat, @"Assets\Images\pdf.png", 48, 48);
            initPicture(Picture_Help, @"Assets\Images\info.png", 48, 48);
        }

        private void initPicture(PictureBox pb, string imagePath, int xSize, int ySize)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap MyImage = new Bitmap(@imagePath);
            pb.ClientSize = new Size(xSize, ySize);
            pb.Image = (Image)MyImage;
            pb.Cursor = Cursors.Hand;
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Tbl_Result.Rows.Clear();
            startScanButton.Enabled = true;
        }

        private void PictureBox_acrobat_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void Lbl_download_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void Download()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Project";
            sfd.DefaultExt = "pdf";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string destinationPath = Path.Combine(sfd.InitialDirectory, "Project.pdf");
            string sourcePath = Path.Combine(Environment.CurrentDirectory, @"Assets\Assignment\Project.pdf");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(sourcePath, destinationPath, true);
            }
        }

        private void MainForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MyMessageBox mmb = new MyMessageBox();
            mmb.Show();
        }

        private void Picture_Help_Click(object sender, EventArgs e)
        {
            MyMessageBox mmb = new MyMessageBox();
            mmb.Show();
        }

        private void Btn_FolderBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                SelectedPath = Path.Combine(Environment.CurrentDirectory, @"Assets\Sample Files"),
            };

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                var allowedExtensions = new List<string> { "exe", "sys", "config" };
                var foundFiles = Directory
                    .EnumerateFiles(fbd.SelectedPath)
                    .Where(s => allowedExtensions.Contains(Path.GetExtension(s).TrimStart('.').ToLowerInvariant()))
                    .Select(x => new
                    {
                        fileName = Path.GetFullPath(x),
                        safeName = Path.GetFileName(x)
                    }).ToList();

                foreach (var item in foundFiles)
                {
                    FillResultTable(item.fileName, item.safeName);
                }

                CompareResultTable();
            }

        }

        
    }
    #endregion others
}
