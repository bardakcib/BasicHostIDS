
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
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.Tbl_Result = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latestMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Lbl_download = new System.Windows.Forms.Label();
            this.Picture_Help = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.startScanButton = new System.Windows.Forms.Button();
            this.scanPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Help)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Result.Location = new System.Drawing.Point(590, 94);
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
            this.Tbl_Result.Location = new System.Drawing.Point(66, 122);
            this.Tbl_Result.Name = "Tbl_Result";
            this.Tbl_Result.Size = new System.Drawing.Size(1246, 574);
            this.Tbl_Result.TabIndex = 5;
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
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.Location = new System.Drawing.Point(1170, 702);
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
            this.Lbl_download.Location = new System.Drawing.Point(63, 17);
            this.Lbl_download.Name = "Lbl_download";
            this.Lbl_download.Size = new System.Drawing.Size(131, 16);
            this.Lbl_download.TabIndex = 7;
            this.Lbl_download.Text = "Folder Path To Scan";
            // 
            // Picture_Help
            // 
            this.Picture_Help.Location = new System.Drawing.Point(1262, 9);
            this.Picture_Help.Name = "Picture_Help";
            this.Picture_Help.Size = new System.Drawing.Size(50, 39);
            this.Picture_Help.TabIndex = 9;
            this.Picture_Help.TabStop = false;
            this.Picture_Help.Click += new System.EventHandler(this.Picture_Help_Click);
            // 
            // startScanButton
            // 
            this.startScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startScanButton.Location = new System.Drawing.Point(503, 17);
            this.startScanButton.Name = "startScanButton";
            this.startScanButton.Size = new System.Drawing.Size(431, 39);
            this.startScanButton.TabIndex = 11;
            this.startScanButton.Text = "Continiously Scan Folder ";
            this.startScanButton.UseVisualStyleBackColor = true;
            this.startScanButton.Click += new System.EventHandler(this.StartScanButton_Click);
            // 
            // scanPath
            // 
            this.scanPath.Location = new System.Drawing.Point(66, 36);
            this.scanPath.Name = "scanPath";
            this.scanPath.Size = new System.Drawing.Size(431, 20);
            this.scanPath.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 752);
            this.Controls.Add(this.scanPath);
            this.Controls.Add(this.startScanButton);
            this.Controls.Add(this.Picture_Help);
            this.Controls.Add(this.Lbl_download);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Tbl_Result);
            this.Controls.Add(this.Lbl_Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Intrusion Detection System using MD5 Checksum - Bedirhan Bardakci";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Result;
        private System.Windows.Forms.DataGridView Tbl_Result;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label Lbl_download;
        private System.Windows.Forms.PictureBox Picture_Help;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button startScanButton;
        private System.Windows.Forms.TextBox scanPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn latestMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}

