namespace File_Locker
{
    partial class FileLocker
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
            this.pnlFileLocker = new System.Windows.Forms.Panel();
            this.lblRead = new System.Windows.Forms.Label();
            this.btnUnzipFiles = new System.Windows.Forms.Button();
            this.lblCrypto = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnZipFiles = new System.Windows.Forms.Button();
            this.lblZip = new System.Windows.Forms.Label();
            this.stsFileStatusBar = new System.Windows.Forms.StatusStrip();
            this.pgbFileStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.pnlFileLocker.SuspendLayout();
            this.stsFileStatusBar.SuspendLayout();
            this.pnlLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFileLocker
            // 
            this.pnlFileLocker.Controls.Add(this.lblRead);
            this.pnlFileLocker.Controls.Add(this.btnUnzipFiles);
            this.pnlFileLocker.Controls.Add(this.lblCrypto);
            this.pnlFileLocker.Controls.Add(this.btnDecrypt);
            this.pnlFileLocker.Controls.Add(this.btnEncrypt);
            this.pnlFileLocker.Controls.Add(this.btnZipFiles);
            this.pnlFileLocker.Controls.Add(this.lblZip);
            this.pnlFileLocker.Location = new System.Drawing.Point(12, 12);
            this.pnlFileLocker.Name = "pnlFileLocker";
            this.pnlFileLocker.Size = new System.Drawing.Size(274, 273);
            this.pnlFileLocker.TabIndex = 0;
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRead.ForeColor = System.Drawing.Color.Red;
            this.lblRead.Location = new System.Drawing.Point(13, 14);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(243, 20);
            this.lblRead.TabIndex = 6;
            this.lblRead.Text = "PLEASE READ CAREFULLY";
            // 
            // btnUnzipFiles
            // 
            this.btnUnzipFiles.Location = new System.Drawing.Point(171, 105);
            this.btnUnzipFiles.Name = "btnUnzipFiles";
            this.btnUnzipFiles.Size = new System.Drawing.Size(75, 23);
            this.btnUnzipFiles.TabIndex = 5;
            this.btnUnzipFiles.Text = "Unzip Files";
            this.btnUnzipFiles.UseVisualStyleBackColor = true;
            this.btnUnzipFiles.Click += new System.EventHandler(this.btnUnzipFiles_Click);
            // 
            // lblCrypto
            // 
            this.lblCrypto.AutoSize = true;
            this.lblCrypto.Location = new System.Drawing.Point(13, 179);
            this.lblCrypto.Name = "lblCrypto";
            this.lblCrypto.Size = new System.Drawing.Size(243, 39);
            this.lblCrypto.TabIndex = 4;
            this.lblCrypto.Text = "The options below will encrypt or decrypt what is \r\ncurrenly unzipped (unless the" +
    " file was zipped while\r\nencrypted) in the File directory.";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(171, 221);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(16, 221);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnZipFiles
            // 
            this.btnZipFiles.Location = new System.Drawing.Point(16, 105);
            this.btnZipFiles.Name = "btnZipFiles";
            this.btnZipFiles.Size = new System.Drawing.Size(75, 23);
            this.btnZipFiles.TabIndex = 1;
            this.btnZipFiles.Text = "Zip Files";
            this.btnZipFiles.UseVisualStyleBackColor = true;
            this.btnZipFiles.Click += new System.EventHandler(this.btnZipFiles_Click);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(13, 50);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(243, 52);
            this.lblZip.TabIndex = 0;
            this.lblZip.Text = "The options below will compress and decompress \r\nthe Files folder or zip file. It" +
    " will extract all from the\r\nFiles.zip to the Files directory and vice versa for " +
    "\r\ncompression.";
            // 
            // stsFileStatusBar
            // 
            this.stsFileStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgbFileStatus});
            this.stsFileStatusBar.Location = new System.Drawing.Point(0, 301);
            this.stsFileStatusBar.Name = "stsFileStatusBar";
            this.stsFileStatusBar.Size = new System.Drawing.Size(986, 22);
            this.stsFileStatusBar.TabIndex = 2;
            this.stsFileStatusBar.Text = "File Progress";
            // 
            // pgbFileStatus
            // 
            this.pgbFileStatus.Name = "pgbFileStatus";
            this.pgbFileStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // pnlLog
            // 
            this.pnlLog.Controls.Add(this.txtLog);
            this.pnlLog.Controls.Add(this.lblLog);
            this.pnlLog.Location = new System.Drawing.Point(292, 14);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(682, 271);
            this.pnlLog.TabIndex = 3;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(18, 12);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(25, 13);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(21, 29);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(637, 225);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // FileLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 323);
            this.Controls.Add(this.pnlLog);
            this.Controls.Add(this.stsFileStatusBar);
            this.Controls.Add(this.pnlFileLocker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileLocker";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileLocker";
            this.pnlFileLocker.ResumeLayout(false);
            this.pnlFileLocker.PerformLayout();
            this.stsFileStatusBar.ResumeLayout(false);
            this.stsFileStatusBar.PerformLayout();
            this.pnlLog.ResumeLayout(false);
            this.pnlLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFileLocker;
        private System.Windows.Forms.Label lblCrypto;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnZipFiles;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Button btnUnzipFiles;
        private System.Windows.Forms.StatusStrip stsFileStatusBar;
        private System.Windows.Forms.ToolStripProgressBar pgbFileStatus;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Label lblLog;
        public System.Windows.Forms.RichTextBox txtLog;
    }
}