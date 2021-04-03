using System.ComponentModel;
using System.Windows.Forms;

namespace KOExecutableEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblGameserverPort = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLoginPort = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFileMD5 = new System.Windows.Forms.Label();
            this.label3x = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOriginalFileSize = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblOriginalMD5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDesciption = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblOriginalFilename = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPentagram = new System.Windows.Forms.LinkLabel();
            this.MainMenu.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1048, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoad,
            this.tsCloseFile,
            this.tsSave,
            this.tsSaveAs,
            this.tsExit,
            this.tempToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "File..";
            // 
            // tsLoad
            // 
            this.tsLoad.Name = "tsLoad";
            this.tsLoad.Size = new System.Drawing.Size(175, 24);
            this.tsLoad.Text = "Load";
            this.tsLoad.Click += new System.EventHandler(this.tsLoad_Click);
            // 
            // tsCloseFile
            // 
            this.tsCloseFile.Enabled = false;
            this.tsCloseFile.Name = "tsCloseFile";
            this.tsCloseFile.Size = new System.Drawing.Size(175, 24);
            this.tsCloseFile.Text = "Close file";
            this.tsCloseFile.Click += new System.EventHandler(this.tsCloseFile_Click);
            // 
            // tsSave
            // 
            this.tsSave.Enabled = false;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(175, 24);
            this.tsSave.Text = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsSaveAs
            // 
            this.tsSaveAs.Enabled = false;
            this.tsSaveAs.Name = "tsSaveAs";
            this.tsSaveAs.Size = new System.Drawing.Size(175, 24);
            this.tsSaveAs.Text = "Save as..";
            this.tsSaveAs.Click += new System.EventHandler(this.tsSaveAs_Click);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(175, 24);
            this.tsExit.Text = "Exit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tempToolStripMenuItem
            // 
            this.tempToolStripMenuItem.Name = "tempToolStripMenuItem";
            this.tempToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.tempToolStripMenuItem.Text = "temp";
            this.tempToolStripMenuItem.Click += new System.EventHandler(this.tempToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // OpenFile
            // 
            this.OpenFile.DefaultExt = "|*.exe";
            this.OpenFile.FileName = "KnightOnLine";
            this.OpenFile.Filter = "|*.exe";
            this.OpenFile.Title = "Select an executable file";
            // 
            // SaveFile
            // 
            this.SaveFile.DefaultExt = "|*.exe";
            this.SaveFile.FileName = "KnightOnLine_X";
            this.SaveFile.Filter = "|*.exe";
            this.SaveFile.Title = "Write filename";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblGameserverPort);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.lblLoginPort);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Controls.Add(this.btnEdit);
            this.gbDetails.Controls.Add(this.lblVersion);
            this.gbDetails.Controls.Add(this.label14);
            this.gbDetails.Controls.Add(this.lblFileMD5);
            this.gbDetails.Controls.Add(this.label3x);
            this.gbDetails.Controls.Add(this.lblSize);
            this.gbDetails.Controls.Add(this.lblFilename);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Enabled = false;
            this.gbDetails.Location = new System.Drawing.Point(6, 45);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(512, 245);
            this.gbDetails.TabIndex = 1;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Loaded Executable";
            // 
            // lblGameserverPort
            // 
            this.lblGameserverPort.Location = new System.Drawing.Point(106, 142);
            this.lblGameserverPort.Name = "lblGameserverPort";
            this.lblGameserverPort.Size = new System.Drawing.Size(400, 23);
            this.lblGameserverPort.TabIndex = 15;
            this.lblGameserverPort.Text = "-";
            this.lblGameserverPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Game Port :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginPort
            // 
            this.lblLoginPort.Location = new System.Drawing.Point(106, 119);
            this.lblLoginPort.Name = "lblLoginPort";
            this.lblLoginPort.Size = new System.Drawing.Size(400, 23);
            this.lblLoginPort.TabIndex = 13;
            this.lblLoginPort.Text = "-";
            this.lblLoginPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login Port :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 168);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(497, 66);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(106, 96);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(400, 23);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "-";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(-3, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Version : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileMD5
            // 
            this.lblFileMD5.Location = new System.Drawing.Point(106, 73);
            this.lblFileMD5.Name = "lblFileMD5";
            this.lblFileMD5.Size = new System.Drawing.Size(400, 23);
            this.lblFileMD5.TabIndex = 5;
            this.lblFileMD5.Text = "-";
            this.lblFileMD5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3x
            // 
            this.label3x.Location = new System.Drawing.Point(6, 73);
            this.label3x.Name = "label3x";
            this.label3x.Size = new System.Drawing.Size(100, 23);
            this.label3x.TabIndex = 4;
            this.label3x.Text = "MD5 :";
            this.label3x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(106, 50);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(400, 23);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "-";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilename
            // 
            this.lblFilename.Location = new System.Drawing.Point(106, 27);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(400, 23);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.Text = "-";
            this.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOriginalFileSize);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblOriginalMD5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblURL);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbDesciption);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblTimestamp);
            this.groupBox1.Controls.Add(this.lblOriginalFilename);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(524, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Signature Matching";
            // 
            // lblOriginalFileSize
            // 
            this.lblOriginalFileSize.Location = new System.Drawing.Point(171, 90);
            this.lblOriginalFileSize.Name = "lblOriginalFileSize";
            this.lblOriginalFileSize.Size = new System.Drawing.Size(332, 23);
            this.lblOriginalFileSize.TabIndex = 18;
            this.lblOriginalFileSize.Text = "-";
            this.lblOriginalFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 23);
            this.label15.TabIndex = 17;
            this.label15.Text = "Original File Size : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOriginalMD5
            // 
            this.lblOriginalMD5.Location = new System.Drawing.Point(168, 136);
            this.lblOriginalMD5.Name = "lblOriginalMD5";
            this.lblOriginalMD5.Size = new System.Drawing.Size(332, 23);
            this.lblOriginalMD5.TabIndex = 16;
            this.lblOriginalMD5.Text = "-";
            this.lblOriginalMD5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "MD5 : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblURL
            // 
            this.lblURL.Location = new System.Drawing.Point(171, 41);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(332, 26);
            this.lblURL.TabIndex = 14;
            this.lblURL.TabStop = true;
            this.lblURL.Text = "-";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 23);
            this.label13.TabIndex = 13;
            this.label13.Text = "URL : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDesciption
            // 
            this.tbDesciption.Location = new System.Drawing.Point(6, 185);
            this.tbDesciption.Multiline = true;
            this.tbDesciption.Name = "tbDesciption";
            this.tbDesciption.ReadOnly = true;
            this.tbDesciption.Size = new System.Drawing.Size(497, 49);
            this.tbDesciption.TabIndex = 12;
            this.tbDesciption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(500, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Description";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(168, 21);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(335, 23);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "-";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Location = new System.Drawing.Point(168, 113);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(332, 23);
            this.lblTimestamp.TabIndex = 9;
            this.lblTimestamp.Text = "-";
            this.lblTimestamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOriginalFilename
            // 
            this.lblOriginalFilename.Location = new System.Drawing.Point(171, 67);
            this.lblOriginalFilename.Name = "lblOriginalFilename";
            this.lblOriginalFilename.Size = new System.Drawing.Size(332, 23);
            this.lblOriginalFilename.TabIndex = 6;
            this.lblOriginalFilename.Text = "-";
            this.lblOriginalFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Author : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Timestamp : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Original Filename : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPentagram
            // 
            this.lblPentagram.AutoSize = true;
            this.lblPentagram.Location = new System.Drawing.Point(877, 28);
            this.lblPentagram.Name = "lblPentagram";
            this.lblPentagram.Size = new System.Drawing.Size(159, 17);
            this.lblPentagram.TabIndex = 4;
            this.lblPentagram.TabStop = true;
            this.lblPentagram.Text = "Coded by PENTAGRAM";
            this.lblPentagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 298);
            this.Controls.Add(this.lblPentagram);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knight OnLine Executable Editor (2015)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tsLoad;
        private ToolStripMenuItem tsSave;
        private ToolStripMenuItem tsSaveAs;
        private ToolStripMenuItem tsExit;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog OpenFile;
        private SaveFileDialog SaveFile;
        private GroupBox gbDetails;
        private Label lblSize;
        private Label lblFilename;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem tsCloseFile;
        private Label lblFileMD5;
        private Label label3x;
        private GroupBox groupBox1;
        private Label lblAuthor;
        private Label lblTimestamp;
        private Label lblOriginalFilename;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lblOriginalMD5;
        private Label label12;
        private LinkLabel lblURL;
        private Label label13;
        private TextBox tbDesciption;
        private Label label11;
        private Label lblOriginalFileSize;
        private Label label15;
        private Label lblVersion;
        private Label label14;
        private Button btnEdit;
        private LinkLabel lblPentagram;
        private Label label3;
        private Label lblGameserverPort;
        private Label label5;
        private Label lblLoginPort;
        private ToolStripMenuItem tempToolStripMenuItem;
    }
}

