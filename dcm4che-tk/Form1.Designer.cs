namespace dcm4che_tk
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEcho = new System.Windows.Forms.TabPage();
            this.echoButton = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.tabUpload = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonUploadBrowse = new System.Windows.Forms.Button();
            this.settingsUploadFilename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uploadBrowseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.settingsUploadPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pathBrowseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.settingsToolkitPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectUpdateButton = new System.Windows.Forms.Button();
            this.settingsHost = new System.Windows.Forms.TextBox();
            this.settingsPort = new System.Windows.Forms.TextBox();
            this.settingsAe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.process1 = new System.Diagnostics.Process();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabEcho.SuspendLayout();
            this.tabUpload.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEcho);
            this.tabControl1.Controls.Add(this.tabUpload);
            this.tabControl1.Controls.Add(this.tabNotes);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEcho
            // 
            this.tabEcho.Controls.Add(this.echoButton);
            this.tabEcho.Controls.Add(this.consoleBox);
            this.tabEcho.Location = new System.Drawing.Point(4, 22);
            this.tabEcho.Name = "tabEcho";
            this.tabEcho.Padding = new System.Windows.Forms.Padding(3);
            this.tabEcho.Size = new System.Drawing.Size(769, 399);
            this.tabEcho.TabIndex = 0;
            this.tabEcho.Text = "Echo";
            this.tabEcho.UseVisualStyleBackColor = true;
            // 
            // echoButton
            // 
            this.echoButton.Location = new System.Drawing.Point(667, 370);
            this.echoButton.Name = "echoButton";
            this.echoButton.Size = new System.Drawing.Size(100, 23);
            this.echoButton.TabIndex = 0;
            this.echoButton.Text = "Echo";
            this.echoButton.UseVisualStyleBackColor = true;
            this.echoButton.Click += new System.EventHandler(this.echoButton_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(8, 6);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleBox.Size = new System.Drawing.Size(759, 358);
            this.consoleBox.TabIndex = 1;
            this.consoleBox.WordWrap = false;
            // 
            // tabUpload
            // 
            this.tabUpload.Controls.Add(this.textBox3);
            this.tabUpload.Controls.Add(this.groupBox5);
            this.tabUpload.Location = new System.Drawing.Point(4, 22);
            this.tabUpload.Name = "tabUpload";
            this.tabUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpload.Size = new System.Drawing.Size(769, 399);
            this.tabUpload.TabIndex = 1;
            this.tabUpload.Text = "Upload";
            this.tabUpload.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 63);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(726, 281);
            this.textBox3.TabIndex = 1;
            this.textBox3.WordWrap = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.buttonUpload);
            this.groupBox5.Controls.Add(this.buttonUploadBrowse);
            this.groupBox5.Controls.Add(this.settingsUploadFilename);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(28, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(729, 49);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select File for Upload";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(585, 16);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(120, 24);
            this.buttonUpload.TabIndex = 3;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonUploadBrowse
            // 
            this.buttonUploadBrowse.Location = new System.Drawing.Point(474, 15);
            this.buttonUploadBrowse.Name = "buttonUploadBrowse";
            this.buttonUploadBrowse.Size = new System.Drawing.Size(105, 25);
            this.buttonUploadBrowse.TabIndex = 2;
            this.buttonUploadBrowse.Text = "Browse";
            this.buttonUploadBrowse.UseVisualStyleBackColor = true;
            this.buttonUploadBrowse.Click += new System.EventHandler(this.buttonUploadBrowse_Click);
            // 
            // settingsUploadFilename
            // 
            this.settingsUploadFilename.Location = new System.Drawing.Point(70, 17);
            this.settingsUploadFilename.Name = "settingsUploadFilename";
            this.settingsUploadFilename.Size = new System.Drawing.Size(398, 20);
            this.settingsUploadFilename.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Filename";
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.notesTextBox);
            this.tabNotes.Location = new System.Drawing.Point(4, 22);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotes.Size = new System.Drawing.Size(769, 399);
            this.tabNotes.TabIndex = 2;
            this.tabNotes.Text = "Notes";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.AcceptsTab = true;
            this.notesTextBox.Location = new System.Drawing.Point(0, 0);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(766, 398);
            this.notesTextBox.TabIndex = 0;
            this.notesTextBox.WordWrap = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox4);
            this.tabSettings.Controls.Add(this.groupBox3);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(769, 399);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.uploadBrowseButton);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.settingsUploadPath);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(8, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 76);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Upload Source Location";
            // 
            // uploadBrowseButton
            // 
            this.uploadBrowseButton.Location = new System.Drawing.Point(406, 46);
            this.uploadBrowseButton.Name = "uploadBrowseButton";
            this.uploadBrowseButton.Size = new System.Drawing.Size(92, 24);
            this.uploadBrowseButton.TabIndex = 2;
            this.uploadBrowseButton.Text = "Browse";
            this.uploadBrowseButton.UseVisualStyleBackColor = true;
            this.uploadBrowseButton.Click += new System.EventHandler(this.uploadBrowseButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Path";
            // 
            // settingsUploadPath
            // 
            this.settingsUploadPath.Location = new System.Drawing.Point(49, 20);
            this.settingsUploadPath.Name = "settingsUploadPath";
            this.settingsUploadPath.Size = new System.Drawing.Size(449, 20);
            this.settingsUploadPath.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.pathBrowseButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.settingsToolkitPath);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(8, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 76);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DCM4CHEE Toolkit Location";
            // 
            // pathBrowseButton
            // 
            this.pathBrowseButton.Location = new System.Drawing.Point(406, 46);
            this.pathBrowseButton.Name = "pathBrowseButton";
            this.pathBrowseButton.Size = new System.Drawing.Size(92, 24);
            this.pathBrowseButton.TabIndex = 2;
            this.pathBrowseButton.Text = "Browse";
            this.pathBrowseButton.UseVisualStyleBackColor = true;
            this.pathBrowseButton.Click += new System.EventHandler(this.pathBrowseButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Path";
            // 
            // settingsToolkitPath
            // 
            this.settingsToolkitPath.Location = new System.Drawing.Point(49, 20);
            this.settingsToolkitPath.Name = "settingsToolkitPath";
            this.settingsToolkitPath.Size = new System.Drawing.Size(449, 20);
            this.settingsToolkitPath.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.connectUpdateButton);
            this.groupBox1.Controls.Add(this.settingsHost);
            this.groupBox1.Controls.Add(this.settingsPort);
            this.groupBox1.Controls.Add(this.settingsAe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(553, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Data";
            // 
            // connectUpdateButton
            // 
            this.connectUpdateButton.Location = new System.Drawing.Point(110, 128);
            this.connectUpdateButton.Name = "connectUpdateButton";
            this.connectUpdateButton.Size = new System.Drawing.Size(77, 23);
            this.connectUpdateButton.TabIndex = 6;
            this.connectUpdateButton.Text = "Update";
            this.connectUpdateButton.UseVisualStyleBackColor = true;
            this.connectUpdateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // settingsHost
            // 
            this.settingsHost.Location = new System.Drawing.Point(49, 56);
            this.settingsHost.Name = "settingsHost";
            this.settingsHost.Size = new System.Drawing.Size(138, 20);
            this.settingsHost.TabIndex = 2;
            // 
            // settingsPort
            // 
            this.settingsPort.Location = new System.Drawing.Point(49, 91);
            this.settingsPort.Name = "settingsPort";
            this.settingsPort.Size = new System.Drawing.Size(138, 20);
            this.settingsPort.TabIndex = 4;
            // 
            // settingsAe
            // 
            this.settingsAe.Location = new System.Drawing.Point(49, 23);
            this.settingsAe.Name = "settingsAe";
            this.settingsAe.Size = new System.Drawing.Size(138, 20);
            this.settingsAe.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AE";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 3;
            // 
            // statusBarText
            // 
            this.statusBarText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarText.Name = "statusBarText";
            this.statusBarText.Size = new System.Drawing.Size(39, 17);
            this.statusBarText.Text = "Status";
            // 
            // process1
            // 
            this.process1.StartInfo.CreateNoWindow = true;
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.RedirectStandardOutput = true;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.StartInfo.UseShellExecute = false;
            this.process1.SynchronizingObject = this;
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 455);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DCM4CHEE Toolkit";
            this.tabControl1.ResumeLayout(false);
            this.tabEcho.ResumeLayout(false);
            this.tabEcho.PerformLayout();
            this.tabUpload.ResumeLayout(false);
            this.tabUpload.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabNotes.ResumeLayout(false);
            this.tabNotes.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEcho;
        private System.Windows.Forms.TabPage tabUpload;
        private System.Windows.Forms.TabPage tabNotes;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox settingsAe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox settingsPort;
        private System.Windows.Forms.TextBox settingsHost;
        private System.Windows.Forms.Button connectUpdateButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarText;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.Button echoButton;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox settingsToolkitPath;
        private System.Windows.Forms.Button pathBrowseButton;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button uploadBrowseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox settingsUploadPath;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonUploadBrowse;
        private System.Windows.Forms.TextBox settingsUploadFilename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox notesTextBox;
    }
}

