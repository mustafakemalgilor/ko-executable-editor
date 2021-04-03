using System.ComponentModel;
using System.Windows.Forms;

namespace KOExecutableEditor
{
    partial class frmFindOffsets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindOffsets));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPrivateKey = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPKList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchPorts = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPorts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbVersionDisplay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchVersion = new System.Windows.Forms.Button();
            this.tbVersionOriginal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbVersions = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbTableEncryption = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbKey2 = new System.Windows.Forms.TextBox();
            this.tbKey1 = new System.Windows.Forms.TextBox();
            this.tbKey3 = new System.Windows.Forms.TextBox();
            this.btnSearchKeys = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTableKeys = new System.Windows.Forms.ListBox();
            this.lbURLs = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbOtherOptions = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSearchMisc = new System.Windows.Forms.Button();
            this.cbFindOpenWebsite = new System.Windows.Forms.CheckBox();
            this.cbFindRotatePacket = new System.Windows.Forms.CheckBox();
            this.cbFindMovePacket = new System.Windows.Forms.CheckBox();
            this.cbFindLauncherCheck = new System.Windows.Forms.CheckBox();
            this.cbFindMutex = new System.Windows.Forms.CheckBox();
            this.cbFindURLS = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbTableEncryption.SuspendLayout();
            this.gbOtherOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPrivateKey);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbPKList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 : Private Key";
            // 
            // cbPrivateKey
            // 
            this.cbPrivateKey.FormattingEnabled = true;
            this.cbPrivateKey.Items.AddRange(new object[] {
            "Forgotten Frontiers (v1700 and above)",
            "Knight Empire (v1298)",
            "Fire Drake & Ice Age(v1300 - v1534)",
            ""});
            this.cbPrivateKey.Location = new System.Drawing.Point(9, 47);
            this.cbPrivateKey.Name = "cbPrivateKey";
            this.cbPrivateKey.Size = new System.Drawing.Size(217, 24);
            this.cbPrivateKey.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 394);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(217, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Results";
            // 
            // lbPKList
            // 
            this.lbPKList.FormattingEnabled = true;
            this.lbPKList.ItemHeight = 16;
            this.lbPKList.Location = new System.Drawing.Point(6, 96);
            this.lbPKList.Name = "lbPKList";
            this.lbPKList.Size = new System.Drawing.Size(220, 292);
            this.lbPKList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Private key to search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSearchPorts);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbPorts);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(255, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 428);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2 : Port";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "15100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loginserver Port";
            // 
            // btnSearchPorts
            // 
            this.btnSearchPorts.Location = new System.Drawing.Point(9, 394);
            this.btnSearchPorts.Name = "btnSearchPorts";
            this.btnSearchPorts.Size = new System.Drawing.Size(220, 28);
            this.btnSearchPorts.TabIndex = 1;
            this.btnSearchPorts.Text = "Search";
            this.btnSearchPorts.UseVisualStyleBackColor = true;
            this.btnSearchPorts.Click += new System.EventHandler(this.btnSearchPorts_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "15001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Results";
            // 
            // lbPorts
            // 
            this.lbPorts.FormattingEnabled = true;
            this.lbPorts.ItemHeight = 16;
            this.lbPorts.Location = new System.Drawing.Point(9, 96);
            this.lbPorts.Name = "lbPorts";
            this.lbPorts.Size = new System.Drawing.Size(220, 292);
            this.lbPorts.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gameserver Port";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbVersionDisplay);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSearchVersion);
            this.groupBox3.Controls.Add(this.tbVersionOriginal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbVersions);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(498, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 428);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3 : Version";
            // 
            // tbVersionDisplay
            // 
            this.tbVersionDisplay.Location = new System.Drawing.Point(157, 52);
            this.tbVersionDisplay.Name = "tbVersionDisplay";
            this.tbVersionDisplay.Size = new System.Drawing.Size(69, 22);
            this.tbVersionDisplay.TabIndex = 5;
            this.tbVersionDisplay.Text = "1534";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Version(display)";
            // 
            // btnSearchVersion
            // 
            this.btnSearchVersion.Location = new System.Drawing.Point(9, 394);
            this.btnSearchVersion.Name = "btnSearchVersion";
            this.btnSearchVersion.Size = new System.Drawing.Size(217, 28);
            this.btnSearchVersion.TabIndex = 1;
            this.btnSearchVersion.Text = "Search";
            this.btnSearchVersion.UseVisualStyleBackColor = true;
            this.btnSearchVersion.Click += new System.EventHandler(this.btnSearchVersion_Click);
            // 
            // tbVersionOriginal
            // 
            this.tbVersionOriginal.Location = new System.Drawing.Point(157, 24);
            this.tbVersionOriginal.Name = "tbVersionOriginal";
            this.tbVersionOriginal.Size = new System.Drawing.Size(69, 22);
            this.tbVersionOriginal.TabIndex = 3;
            this.tbVersionOriginal.Text = "1534";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Results";
            // 
            // lbVersions
            // 
            this.lbVersions.FormattingEnabled = true;
            this.lbVersions.ItemHeight = 16;
            this.lbVersions.Location = new System.Drawing.Point(6, 96);
            this.lbVersions.Name = "lbVersions";
            this.lbVersions.Size = new System.Drawing.Size(220, 292);
            this.lbVersions.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Version(original)";
            // 
            // gbTableEncryption
            // 
            this.gbTableEncryption.Controls.Add(this.label9);
            this.gbTableEncryption.Controls.Add(this.label11);
            this.gbTableEncryption.Controls.Add(this.label12);
            this.gbTableEncryption.Controls.Add(this.tbKey2);
            this.gbTableEncryption.Controls.Add(this.tbKey1);
            this.gbTableEncryption.Controls.Add(this.tbKey3);
            this.gbTableEncryption.Controls.Add(this.btnSearchKeys);
            this.gbTableEncryption.Controls.Add(this.label10);
            this.gbTableEncryption.Controls.Add(this.lbTableKeys);
            this.gbTableEncryption.Enabled = false;
            this.gbTableEncryption.Location = new System.Drawing.Point(741, 55);
            this.gbTableEncryption.Name = "gbTableEncryption";
            this.gbTableEncryption.Size = new System.Drawing.Size(237, 428);
            this.gbTableEncryption.TabIndex = 7;
            this.gbTableEncryption.TabStop = false;
            this.gbTableEncryption.Text = "Step 4 : Table && Log Encryption";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(158, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Key 3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(89, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Key 2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(19, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "Key 1";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbKey2
            // 
            this.tbKey2.Location = new System.Drawing.Point(89, 50);
            this.tbKey2.Name = "tbKey2";
            this.tbKey2.Size = new System.Drawing.Size(68, 22);
            this.tbKey2.TabIndex = 15;
            this.tbKey2.Text = "0x6081";
            // 
            // tbKey1
            // 
            this.tbKey1.Location = new System.Drawing.Point(19, 50);
            this.tbKey1.Name = "tbKey1";
            this.tbKey1.Size = new System.Drawing.Size(68, 22);
            this.tbKey1.TabIndex = 14;
            this.tbKey1.Text = "0x1608";
            // 
            // tbKey3
            // 
            this.tbKey3.Location = new System.Drawing.Point(158, 50);
            this.tbKey3.Name = "tbKey3";
            this.tbKey3.Size = new System.Drawing.Size(68, 22);
            this.tbKey3.TabIndex = 13;
            this.tbKey3.Text = "0x816";
 
            // 
            // btnSearchKeys
            // 
            this.btnSearchKeys.Location = new System.Drawing.Point(9, 394);
            this.btnSearchKeys.Name = "btnSearchKeys";
            this.btnSearchKeys.Size = new System.Drawing.Size(217, 28);
            this.btnSearchKeys.TabIndex = 1;
            this.btnSearchKeys.Text = "Search";
            this.btnSearchKeys.UseVisualStyleBackColor = true;
            this.btnSearchKeys.Click += new System.EventHandler(this.btnSearchKeys_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Results";
            // 
            // lbTableKeys
            // 
            this.lbTableKeys.FormattingEnabled = true;
            this.lbTableKeys.ItemHeight = 16;
            this.lbTableKeys.Location = new System.Drawing.Point(6, 96);
            this.lbTableKeys.Name = "lbTableKeys";
            this.lbTableKeys.Size = new System.Drawing.Size(220, 292);
            this.lbTableKeys.TabIndex = 1;
            // 
            // lbURLs
            // 
            this.lbURLs.FormattingEnabled = true;
            this.lbURLs.ItemHeight = 16;
            this.lbURLs.Location = new System.Drawing.Point(6, 134);
            this.lbURLs.Name = "lbURLs";
            this.lbURLs.Size = new System.Drawing.Size(943, 52);
            this.lbURLs.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(937, 34);
            this.label14.TabIndex = 9;
            this.label14.Text = "You need to enter correct values below. The default values are already given. If " +
    "default values are not working, you need to find out the value which\r\n is stored" +
    " currently in executable.";
            // 
            // gbOtherOptions
            // 
            this.gbOtherOptions.Controls.Add(this.btnFinalize);
            this.gbOtherOptions.Controls.Add(this.label13);
            this.gbOtherOptions.Controls.Add(this.cbFindURLS);
            this.gbOtherOptions.Controls.Add(this.label15);
            this.gbOtherOptions.Controls.Add(this.lbURLs);
            this.gbOtherOptions.Controls.Add(this.btnSearchMisc);
            this.gbOtherOptions.Controls.Add(this.cbFindOpenWebsite);
            this.gbOtherOptions.Controls.Add(this.cbFindRotatePacket);
            this.gbOtherOptions.Controls.Add(this.cbFindMovePacket);
            this.gbOtherOptions.Controls.Add(this.cbFindLauncherCheck);
            this.gbOtherOptions.Controls.Add(this.cbFindMutex);
            this.gbOtherOptions.Enabled = false;
            this.gbOtherOptions.Location = new System.Drawing.Point(12, 489);
            this.gbOtherOptions.Name = "gbOtherOptions";
            this.gbOtherOptions.Size = new System.Drawing.Size(966, 223);
            this.gbOtherOptions.TabIndex = 10;
            this.gbOtherOptions.TabStop = false;
            this.gbOtherOptions.Text = "Other Options (misc.)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(712, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "NOTE : Those are miscellaneous and experimental options. There\'s no guarantee tha" +
    "t the values can be found.";
            // 
            // btnSearchMisc
            // 
            this.btnSearchMisc.Location = new System.Drawing.Point(538, 192);
            this.btnSearchMisc.Name = "btnSearchMisc";
            this.btnSearchMisc.Size = new System.Drawing.Size(248, 23);
            this.btnSearchMisc.TabIndex = 5;
            this.btnSearchMisc.Text = "Search for Checked Values";
            this.btnSearchMisc.UseVisualStyleBackColor = true;
            this.btnSearchMisc.Click += new System.EventHandler(this.btnSearchMisc_Click);
            // 
            // cbFindOpenWebsite
            // 
            this.cbFindOpenWebsite.AutoSize = true;
            this.cbFindOpenWebsite.Location = new System.Drawing.Point(665, 57);
            this.cbFindOpenWebsite.Name = "cbFindOpenWebsite";
            this.cbFindOpenWebsite.Size = new System.Drawing.Size(239, 21);
            this.cbFindOpenWebsite.TabIndex = 4;
            this.cbFindOpenWebsite.Text = "Find Open Website on Exit Offset";
            this.cbFindOpenWebsite.UseVisualStyleBackColor = true;
            // 
            // cbFindRotatePacket
            // 
            this.cbFindRotatePacket.AutoSize = true;
            this.cbFindRotatePacket.Location = new System.Drawing.Point(336, 84);
            this.cbFindRotatePacket.Name = "cbFindRotatePacket";
            this.cbFindRotatePacket.Size = new System.Drawing.Size(242, 21);
            this.cbFindRotatePacket.TabIndex = 3;
            this.cbFindRotatePacket.Text = "Find Rotate Packet Interval Offset";
            this.cbFindRotatePacket.UseVisualStyleBackColor = true;
            // 
            // cbFindMovePacket
            // 
            this.cbFindMovePacket.AutoSize = true;
            this.cbFindMovePacket.Location = new System.Drawing.Point(336, 57);
            this.cbFindMovePacket.Name = "cbFindMovePacket";
            this.cbFindMovePacket.Size = new System.Drawing.Size(234, 21);
            this.cbFindMovePacket.TabIndex = 2;
            this.cbFindMovePacket.Text = "Find Move Packet Interval Offset";
            this.cbFindMovePacket.UseVisualStyleBackColor = true;
            // 
            // cbFindLauncherCheck
            // 
            this.cbFindLauncherCheck.AutoSize = true;
            this.cbFindLauncherCheck.Location = new System.Drawing.Point(12, 84);
            this.cbFindLauncherCheck.Name = "cbFindLauncherCheck";
            this.cbFindLauncherCheck.Size = new System.Drawing.Size(206, 21);
            this.cbFindLauncherCheck.TabIndex = 1;
            this.cbFindLauncherCheck.Text = "Find Launcher Check Offset";
            this.cbFindLauncherCheck.UseVisualStyleBackColor = true;
            // 
            // cbFindMutex
            // 
            this.cbFindMutex.AutoSize = true;
            this.cbFindMutex.Checked = true;
            this.cbFindMutex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFindMutex.Location = new System.Drawing.Point(12, 57);
            this.cbFindMutex.Name = "cbFindMutex";
            this.cbFindMutex.Size = new System.Drawing.Size(201, 21);
            this.cbFindMutex.TabIndex = 0;
            this.cbFindMutex.Text = "Find Allow Multiclient Offset";
            this.cbFindMutex.UseVisualStyleBackColor = true;
            // 
            // cbFindURLS
            // 
            this.cbFindURLS.AutoSize = true;
            this.cbFindURLS.Checked = true;
            this.cbFindURLS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFindURLS.Location = new System.Drawing.Point(665, 84);
            this.cbFindURLS.Name = "cbFindURLS";
            this.cbFindURLS.Size = new System.Drawing.Size(145, 21);
            this.cbFindURLS.TabIndex = 6;
            this.cbFindURLS.Text = "Find URL offset(s)";
            this.cbFindURLS.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Found URLs";
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(792, 192);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(157, 23);
            this.btnFinalize.TabIndex = 8;
            this.btnFinalize.Text = "Done";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // frmFindOffsets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 721);
            this.Controls.Add(this.gbOtherOptions);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gbTableEncryption);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFindOffsets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KO Executable Editor :: Find Offsets";
            this.Load += new System.EventHandler(this.frmFindOffsets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbTableEncryption.ResumeLayout(false);
            this.gbTableEncryption.PerformLayout();
            this.gbOtherOptions.ResumeLayout(false);
            this.gbOtherOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSearch;
        private Label label2;
        private ListBox lbPKList;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label5;
        private Button btnSearchPorts;
        private TextBox textBox1;
        private Label label3;
        private ListBox lbPorts;
        private Label label4;
        private GroupBox groupBox3;
        private Button btnSearchVersion;
        private TextBox tbVersionOriginal;
        private Label label7;
        private ListBox lbVersions;
        private Label label8;
        private TextBox tbVersionDisplay;
        private Label label6;
        private ComboBox cbPrivateKey;
        private GroupBox gbTableEncryption;
        private Button btnSearchKeys;
        private Label label10;
        private ListBox lbTableKeys;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox tbKey2;
        private TextBox tbKey1;
        private TextBox tbKey3;
        private ListBox lbURLs;
        private Label label14;
        private GroupBox gbOtherOptions;
        private Label label15;
        private Button btnSearchMisc;
        private CheckBox cbFindOpenWebsite;
        private CheckBox cbFindRotatePacket;
        private CheckBox cbFindMovePacket;
        private CheckBox cbFindLauncherCheck;
        private CheckBox cbFindMutex;
        private CheckBox cbFindURLS;
        private Label label13;
        private Button btnFinalize;
    }
}