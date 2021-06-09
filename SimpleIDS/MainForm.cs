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
        private string pathToScan = "";
        public MainForm()
        {
            InitializeComponent();
            Initialize();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
        }
        private void StartScanButton_Click(object sender, EventArgs e)
        {
            if (scanPath.Text.Length > 0)
            {
                Tbl_Result.Rows.Clear();

                pathToScan = Path.Combine(scanPath.Text, "");

                ScanAllFiles();

                StartWatchingFolder();

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
                var allowedExtensions = new List<string> { "exe", "sys", "config" };

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
                    InsertToTable(item.fileName, item.safeName);
                }
            }
        }

        private void StartWatchingFolder()
        {
            string[] filters = { "*.exe", "*.sys", "*.config" };
            List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();

            foreach (string f in filters)
            {
                FileSystemWatcher w = new FileSystemWatcher
                {
                    Filter = f,
                    NotifyFilter = NotifyFilters.LastWrite,
                    Path = pathToScan
                };
                w.Changed += new FileSystemEventHandler(OnChanged);
                w.EnableRaisingEvents = true;
                watchers.Add(w);
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
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
                        string checkMD5 = Encoding.Default.GetString(md5.ComputeHash(stream));
                        Tbl_Result.Visible = true;
                        Btn_Clear.Visible = true;

                        foreach (DataGridViewRow row in Tbl_Result.Rows)
                        {
                            if (shortFileName.Equals(row.Cells[0].Value ?? string.Empty))
                            {
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
                        Tbl_Result.Rows.Add(shortFileName, checkMD5, "");
                    }
                }
            }
            catch (IOException)
            {

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

            InitPicture(Picture_Help, @"Assets\Images\info.png", 48, 48);
        }

        private void InitPicture(PictureBox pb, string imagePath, int xSize, int ySize)
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
    }
}
