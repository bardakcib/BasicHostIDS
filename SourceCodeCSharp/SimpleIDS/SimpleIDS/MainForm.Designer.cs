
namespace SimpleIDS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FileBrowser = new System.Windows.Forms.Button();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.Tbl_Result = new System.Windows.Forms.DataGridView();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Lbl_download = new System.Windows.Forms.Label();
            this.pictureBox_acrobat = new System.Windows.Forms.PictureBox();
            this.Picture_Help = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_FolderBrowser = new System.Windows.Forms.Button();
            this.startScanButton = new System.Windows.Forms.Button();
            this.scanPath = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latestMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_acrobat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Help)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FileBrowser
            // 
            this.btn_FileBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FileBrowser.Location = new System.Drawing.Point(66, 12);
            this.btn_FileBrowser.Name = "btn_FileBrowser";
            this.btn_FileBrowser.Size = new System.Drawing.Size(227, 81);
            this.btn_FileBrowser.TabIndex = 0;
            this.btn_FileBrowser.Text = "Browse File";
            this.btn_FileBrowser.UseVisualStyleBackColor = true;
            this.btn_FileBrowser.Click += new System.EventHandler(this.Btn_FileBrowser_Click);
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Result.Location = new System.Drawing.Point(854, 136);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(194, 25);
            this.Lbl_Result.TabIndex = 4;
            this.Lbl_Result.Text = "Comparison Result";
            // 
            // Tbl_Result
            // 
            this.Tbl_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.initialMD5,
            this.latestMD5,
            this.Result});
            this.Tbl_Result.Location = new System.Drawing.Point(66, 164);
            this.Tbl_Result.Name = "Tbl_Result";
            this.Tbl_Result.Size = new System.Drawing.Size(1782, 824);
            this.Tbl_Result.TabIndex = 5;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.Location = new System.Drawing.Point(1706, 994);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(142, 31);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Clear Results";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Lbl_download
            // 
            this.Lbl_download.AutoSize = true;
            this.Lbl_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_download.Location = new System.Drawing.Point(1628, 21);
            this.Lbl_download.Name = "Lbl_download";
            this.Lbl_download.Size = new System.Drawing.Size(142, 16);
            this.Lbl_download.TabIndex = 7;
            this.Lbl_download.Text = "Download Assignment";
            this.Lbl_download.Click += new System.EventHandler(this.Lbl_download_Click);
            // 
            // pictureBox_acrobat
            // 
            this.pictureBox_acrobat.Location = new System.Drawing.Point(1671, 40);
            this.pictureBox_acrobat.Name = "pictureBox_acrobat";
            this.pictureBox_acrobat.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_acrobat.TabIndex = 8;
            this.pictureBox_acrobat.TabStop = false;
            this.pictureBox_acrobat.Click += new System.EventHandler(this.PictureBox_acrobat_Click);
            // 
            // Picture_Help
            // 
            this.Picture_Help.Location = new System.Drawing.Point(1784, 29);
            this.Picture_Help.Name = "Picture_Help";
            this.Picture_Help.Size = new System.Drawing.Size(64, 64);
            this.Picture_Help.TabIndex = 9;
            this.Picture_Help.TabStop = false;
            this.Picture_Help.Click += new System.EventHandler(this.Picture_Help_Click);
            // 
            // btn_FolderBrowser
            // 
            this.btn_FolderBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FolderBrowser.Location = new System.Drawing.Point(310, 12);
            this.btn_FolderBrowser.Name = "btn_FolderBrowser";
            this.btn_FolderBrowser.Size = new System.Drawing.Size(227, 81);
            this.btn_FolderBrowser.TabIndex = 10;
            this.btn_FolderBrowser.Text = "Browse Folder";
            this.btn_FolderBrowser.UseVisualStyleBackColor = true;
            this.btn_FolderBrowser.Click += new System.EventHandler(this.Btn_FolderBrowser_Click);
            // 
            // startScanButton
            // 
            this.startScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startScanButton.Location = new System.Drawing.Point(673, 40);
            this.startScanButton.Name = "startScanButton";
            this.startScanButton.Size = new System.Drawing.Size(431, 55);
            this.startScanButton.TabIndex = 11;
            this.startScanButton.Text = "Continiously Scan Folder ";
            this.startScanButton.UseVisualStyleBackColor = true;
            this.startScanButton.Click += new System.EventHandler(this.startScanButton_Click);
            // 
            // scanPath
            // 
            this.scanPath.Location = new System.Drawing.Point(673, 12);
            this.scanPath.Name = "scanPath";
            this.scanPath.Size = new System.Drawing.Size(431, 20);
            this.scanPath.TabIndex = 12;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // initialMD5
            // 
            this.initialMD5.HeaderText = "Default MD5 Hash Code";
            this.initialMD5.Name = "initialMD5";
            this.initialMD5.ReadOnly = true;
            // 
            // latestMD5
            // 
            this.latestMD5.HeaderText = "After File Changed MD5 Hash Code";
            this.latestMD5.Name = "latestMD5";
            this.latestMD5.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Comparison Result";
            this.Result.Name = "Result";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1037);
            this.Controls.Add(this.scanPath);
            this.Controls.Add(this.startScanButton);
            this.Controls.Add(this.btn_FolderBrowser);
            this.Controls.Add(this.Picture_Help);
            this.Controls.Add(this.pictureBox_acrobat);
            this.Controls.Add(this.Lbl_download);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Tbl_Result);
            this.Controls.Add(this.Lbl_Result);
            this.Controls.Add(this.btn_FileBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Intrusion Detection System using MD5 Checksum - Bedirhan Bardakci";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_acrobat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_FileBrowser;
        private System.Windows.Forms.Label Lbl_Result;
        private System.Windows.Forms.DataGridView Tbl_Result;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label Lbl_download;
        private System.Windows.Forms.PictureBox pictureBox_acrobat;
        private System.Windows.Forms.PictureBox Picture_Help;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_FolderBrowser;
        private System.Windows.Forms.Button startScanButton;
        private System.Windows.Forms.TextBox scanPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn latestMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}

