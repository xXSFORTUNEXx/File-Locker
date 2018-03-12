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
            this.stsFileStatusBar = new System.Windows.Forms.StatusStrip();
            this.pgbFileStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.ttlProgressStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unzipFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFileLockerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHelpOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startFreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMainTabs = new System.Windows.Forms.TabControl();
            this.tabInstructions = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.tabTools = new System.Windows.Forms.TabPage();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnUnzipFiles = new System.Windows.Forms.Button();
            this.btnZipFiles = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stsFileStatusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabMainTabs.SuspendLayout();
            this.tabInstructions.SuspendLayout();
            this.tabTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsFileStatusBar
            // 
            this.stsFileStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgbFileStatus,
            this.ttlProgressStatus});
            this.stsFileStatusBar.Location = new System.Drawing.Point(0, 686);
            this.stsFileStatusBar.Name = "stsFileStatusBar";
            this.stsFileStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stsFileStatusBar.Size = new System.Drawing.Size(986, 22);
            this.stsFileStatusBar.TabIndex = 2;
            this.stsFileStatusBar.Text = "File Progress";
            // 
            // pgbFileStatus
            // 
            this.pgbFileStatus.Name = "pgbFileStatus";
            this.pgbFileStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // ttlProgressStatus
            // 
            this.ttlProgressStatus.Name = "ttlProgressStatus";
            this.ttlProgressStatus.Size = new System.Drawing.Size(39, 17);
            this.ttlProgressStatus.Text = "Ready";
            this.ttlProgressStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Location = new System.Drawing.Point(293, 37);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(682, 639);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.preferencesToolStripMenuItem2});
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // preferencesToolStripMenuItem2
            // 
            this.preferencesToolStripMenuItem2.Name = "preferencesToolStripMenuItem2";
            this.preferencesToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.preferencesToolStripMenuItem2.Text = "Preferences";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.unzipFilesToolStripMenuItem,
            this.encryptFilesToolStripMenuItem,
            this.decryptFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.preferencesToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewToolStripMenuItem.Text = "Tools";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.preferencesToolStripMenuItem.Text = "Zip Files";
            // 
            // unzipFilesToolStripMenuItem
            // 
            this.unzipFilesToolStripMenuItem.Name = "unzipFilesToolStripMenuItem";
            this.unzipFilesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.unzipFilesToolStripMenuItem.Text = "Unzip Files";
            // 
            // encryptFilesToolStripMenuItem
            // 
            this.encryptFilesToolStripMenuItem.Name = "encryptFilesToolStripMenuItem";
            this.encryptFilesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.encryptFilesToolStripMenuItem.Text = "Encrypt Files";
            // 
            // decryptFilesToolStripMenuItem
            // 
            this.decryptFilesToolStripMenuItem.Name = "decryptFilesToolStripMenuItem";
            this.decryptFilesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.decryptFilesToolStripMenuItem.Text = "Decrypt Files";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBackupToolStripMenuItem,
            this.encryptedToolStripMenuItem,
            this.decryptedToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.zipFilesToolStripMenuItem});
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.preferencesToolStripMenuItem1.Text = "Delete Files";
            // 
            // deleteBackupToolStripMenuItem
            // 
            this.deleteBackupToolStripMenuItem.Name = "deleteBackupToolStripMenuItem";
            this.deleteBackupToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteBackupToolStripMenuItem.Text = "Backup";
            // 
            // encryptedToolStripMenuItem
            // 
            this.encryptedToolStripMenuItem.Name = "encryptedToolStripMenuItem";
            this.encryptedToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.encryptedToolStripMenuItem.Text = "Encrypted";
            // 
            // decryptedToolStripMenuItem
            // 
            this.decryptedToolStripMenuItem.Name = "decryptedToolStripMenuItem";
            this.decryptedToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.decryptedToolStripMenuItem.Text = "Decrypted";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // zipFilesToolStripMenuItem
            // 
            this.zipFilesToolStripMenuItem.Name = "zipFilesToolStripMenuItem";
            this.zipFilesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.zipFilesToolStripMenuItem.Text = "Zip Files";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFileLockerToolStripMenuItem,
            this.getHelpOnlineToolStripMenuItem,
            this.toolStripSeparator2,
            this.startFreshToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutFileLockerToolStripMenuItem
            // 
            this.aboutFileLockerToolStripMenuItem.Name = "aboutFileLockerToolStripMenuItem";
            this.aboutFileLockerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutFileLockerToolStripMenuItem.Text = "About File Locker";
            // 
            // getHelpOnlineToolStripMenuItem
            // 
            this.getHelpOnlineToolStripMenuItem.Name = "getHelpOnlineToolStripMenuItem";
            this.getHelpOnlineToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.getHelpOnlineToolStripMenuItem.Text = "Get Help Online";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // startFreshToolStripMenuItem
            // 
            this.startFreshToolStripMenuItem.Name = "startFreshToolStripMenuItem";
            this.startFreshToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.startFreshToolStripMenuItem.Text = "Start Fresh";
            // 
            // tabMainTabs
            // 
            this.tabMainTabs.Controls.Add(this.tabInstructions);
            this.tabMainTabs.Controls.Add(this.tabTools);
            this.tabMainTabs.Controls.Add(this.tabPage1);
            this.tabMainTabs.Location = new System.Drawing.Point(12, 37);
            this.tabMainTabs.Name = "tabMainTabs";
            this.tabMainTabs.SelectedIndex = 0;
            this.tabMainTabs.Size = new System.Drawing.Size(275, 639);
            this.tabMainTabs.TabIndex = 5;
            // 
            // tabInstructions
            // 
            this.tabInstructions.Controls.Add(this.label1);
            this.tabInstructions.Controls.Add(this.lblRead);
            this.tabInstructions.Location = new System.Drawing.Point(4, 22);
            this.tabInstructions.Name = "tabInstructions";
            this.tabInstructions.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstructions.Size = new System.Drawing.Size(267, 613);
            this.tabInstructions.TabIndex = 0;
            this.tabInstructions.Text = "Instructions";
            this.tabInstructions.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please read all instructions carefully before\r\ncompressing files or encrypting AN" +
    "YTHING! Lets\r\nstart with some basic steps:";
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRead.ForeColor = System.Drawing.Color.Red;
            this.lblRead.Location = new System.Drawing.Point(11, 17);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(243, 20);
            this.lblRead.TabIndex = 7;
            this.lblRead.Text = "PLEASE READ CAREFULLY";
            // 
            // tabTools
            // 
            this.tabTools.Controls.Add(this.btnDecrypt);
            this.tabTools.Controls.Add(this.btnEncrypt);
            this.tabTools.Controls.Add(this.btnUnzipFiles);
            this.tabTools.Controls.Add(this.btnZipFiles);
            this.tabTools.Location = new System.Drawing.Point(4, 22);
            this.tabTools.Name = "tabTools";
            this.tabTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabTools.Size = new System.Drawing.Size(267, 613);
            this.tabTools.TabIndex = 1;
            this.tabTools.Text = "Tools";
            this.tabTools.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(169, 112);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(21, 112);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnUnzipFiles
            // 
            this.btnUnzipFiles.Location = new System.Drawing.Point(169, 20);
            this.btnUnzipFiles.Name = "btnUnzipFiles";
            this.btnUnzipFiles.Size = new System.Drawing.Size(75, 23);
            this.btnUnzipFiles.TabIndex = 6;
            this.btnUnzipFiles.Text = "Unzip Files";
            this.btnUnzipFiles.UseVisualStyleBackColor = true;
            this.btnUnzipFiles.Click += new System.EventHandler(this.btnUnzipFiles_Click);
            // 
            // btnZipFiles
            // 
            this.btnZipFiles.Location = new System.Drawing.Point(21, 20);
            this.btnZipFiles.Name = "btnZipFiles";
            this.btnZipFiles.Size = new System.Drawing.Size(75, 23);
            this.btnZipFiles.TabIndex = 2;
            this.btnZipFiles.Text = "Zip Files";
            this.btnZipFiles.UseVisualStyleBackColor = true;
            this.btnZipFiles.Click += new System.EventHandler(this.btnZipFiles_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 613);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Prefrences";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FileLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 708);
            this.ControlBox = false;
            this.Controls.Add(this.tabMainTabs);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.stsFileStatusBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileLocker";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileLocker";
            this.stsFileStatusBar.ResumeLayout(false);
            this.stsFileStatusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMainTabs.ResumeLayout(false);
            this.tabInstructions.ResumeLayout(false);
            this.tabInstructions.PerformLayout();
            this.tabTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsFileStatusBar;
        private System.Windows.Forms.ToolStripProgressBar pgbFileStatus;
        private System.Windows.Forms.ToolStripStatusLabel ttlProgressStatus;
        public System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMainTabs;
        private System.Windows.Forms.TabPage tabInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.TabPage tabTools;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnUnzipFiles;
        private System.Windows.Forms.Button btnZipFiles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unzipFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutFileLockerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHelpOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startFreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem2;
    }
}