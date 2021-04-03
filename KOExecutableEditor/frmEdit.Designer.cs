using System.ComponentModel;
using System.Windows.Forms;

namespace KOExecutableEditor
{
    partial class frmEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.gbPrivateKeys = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateAllPK = new System.Windows.Forms.Button();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.btnUpdateSelectedPK = new System.Windows.Forms.Button();
            this.lbPrivateKeys = new System.Windows.Forms.ListBox();
            this.gbGameserverPorts = new System.Windows.Forms.GroupBox();
            this.nGameserverPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateAllGSPort = new System.Windows.Forms.Button();
            this.btnUpdateSelectedGSPort = new System.Windows.Forms.Button();
            this.lbGameserverPorts = new System.Windows.Forms.ListBox();
            this.gbLoginserverPorts = new System.Windows.Forms.GroupBox();
            this.nLoginserverPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateAllLSPort = new System.Windows.Forms.Button();
            this.btnUpdateSelectedLSPort = new System.Windows.Forms.Button();
            this.lbLoginserverPorts = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateVersionOriginal = new System.Windows.Forms.Button();
            this.btnUpdateVersionDisplay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nVersionOriginal = new System.Windows.Forms.NumericUpDown();
            this.nVersionDisplay = new System.Windows.Forms.NumericUpDown();
            this.gbTableKeys = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbKey3P = new System.Windows.Forms.ListBox();
            this.lbKey2P = new System.Windows.Forms.ListBox();
            this.lbKey1P = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbKey3 = new System.Windows.Forms.ListBox();
            this.lbKey2 = new System.Windows.Forms.ListBox();
            this.btnUpdateAllKeys = new System.Windows.Forms.Button();
            this.btnUpdateSelectedKey = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKey2 = new System.Windows.Forms.TextBox();
            this.tbKey1 = new System.Windows.Forms.TextBox();
            this.tbKey3 = new System.Windows.Forms.TextBox();
            this.lbKey1 = new System.Windows.Forms.ListBox();
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.nRotate = new System.Windows.Forms.NumericUpDown();
            this.nMove = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDisableWebsite = new System.Windows.Forms.CheckBox();
            this.cbDisableLauncher = new System.Windows.Forms.CheckBox();
            this.cbEnableMulti = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbURLs = new System.Windows.Forms.GroupBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.btnUpdateURL = new System.Windows.Forms.Button();
            this.tbSelectedURL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbURLs = new System.Windows.Forms.ListBox();
            this.gbPrivateKeys.SuspendLayout();
            this.gbGameserverPorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGameserverPort)).BeginInit();
            this.gbLoginserverPorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLoginserverPort)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVersionOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVersionDisplay)).BeginInit();
            this.gbTableKeys.SuspendLayout();
            this.gbMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMove)).BeginInit();
            this.gbURLs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrivateKeys
            // 
            this.gbPrivateKeys.Controls.Add(this.label1);
            this.gbPrivateKeys.Controls.Add(this.btnUpdateAllPK);
            this.gbPrivateKeys.Controls.Add(this.tbPrivateKey);
            this.gbPrivateKeys.Controls.Add(this.btnUpdateSelectedPK);
            this.gbPrivateKeys.Controls.Add(this.lbPrivateKeys);
            this.gbPrivateKeys.Location = new System.Drawing.Point(12, 12);
            this.gbPrivateKeys.Name = "gbPrivateKeys";
            this.gbPrivateKeys.Size = new System.Drawing.Size(347, 452);
            this.gbPrivateKeys.TabIndex = 0;
            this.gbPrivateKeys.TabStop = false;
            this.gbPrivateKeys.Text = "Private Keys";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Value :";
            // 
            // btnUpdateAllPK
            // 
            this.btnUpdateAllPK.Enabled = false;
            this.btnUpdateAllPK.Location = new System.Drawing.Point(6, 419);
            this.btnUpdateAllPK.Name = "btnUpdateAllPK";
            this.btnUpdateAllPK.Size = new System.Drawing.Size(330, 23);
            this.btnUpdateAllPK.TabIndex = 4;
            this.btnUpdateAllPK.Text = "Update All Values";
            this.btnUpdateAllPK.UseVisualStyleBackColor = true;
            this.btnUpdateAllPK.Click += new System.EventHandler(this.btnUpdateAllPK_Click);
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Enabled = false;
            this.tbPrivateKey.Location = new System.Drawing.Point(90, 357);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(246, 22);
            this.tbPrivateKey.TabIndex = 3;
            this.tbPrivateKey.Tag = "1";
            // 
            // btnUpdateSelectedPK
            // 
            this.btnUpdateSelectedPK.Enabled = false;
            this.btnUpdateSelectedPK.Location = new System.Drawing.Point(6, 390);
            this.btnUpdateSelectedPK.Name = "btnUpdateSelectedPK";
            this.btnUpdateSelectedPK.Size = new System.Drawing.Size(330, 23);
            this.btnUpdateSelectedPK.TabIndex = 2;
            this.btnUpdateSelectedPK.Text = "Update Selected";
            this.btnUpdateSelectedPK.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedPK.Click += new System.EventHandler(this.btnUpdateSelectedPK_Click);
            // 
            // lbPrivateKeys
            // 
            this.lbPrivateKeys.FormattingEnabled = true;
            this.lbPrivateKeys.ItemHeight = 16;
            this.lbPrivateKeys.Location = new System.Drawing.Point(6, 38);
            this.lbPrivateKeys.Name = "lbPrivateKeys";
            this.lbPrivateKeys.Size = new System.Drawing.Size(330, 308);
            this.lbPrivateKeys.TabIndex = 0;
            this.lbPrivateKeys.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // gbGameserverPorts
            // 
            this.gbGameserverPorts.Controls.Add(this.nGameserverPort);
            this.gbGameserverPorts.Controls.Add(this.label2);
            this.gbGameserverPorts.Controls.Add(this.btnUpdateAllGSPort);
            this.gbGameserverPorts.Controls.Add(this.btnUpdateSelectedGSPort);
            this.gbGameserverPorts.Controls.Add(this.lbGameserverPorts);
            this.gbGameserverPorts.Location = new System.Drawing.Point(365, 12);
            this.gbGameserverPorts.Name = "gbGameserverPorts";
            this.gbGameserverPorts.Size = new System.Drawing.Size(203, 228);
            this.gbGameserverPorts.TabIndex = 6;
            this.gbGameserverPorts.TabStop = false;
            this.gbGameserverPorts.Text = "Gameserver Ports";
            // 
            // nGameserverPort
            // 
            this.nGameserverPort.Enabled = false;
            this.nGameserverPort.Location = new System.Drawing.Point(95, 138);
            this.nGameserverPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nGameserverPort.Name = "nGameserverPort";
            this.nGameserverPort.Size = new System.Drawing.Size(98, 22);
            this.nGameserverPort.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Value :";
            // 
            // btnUpdateAllGSPort
            // 
            this.btnUpdateAllGSPort.Enabled = false;
            this.btnUpdateAllGSPort.Location = new System.Drawing.Point(6, 195);
            this.btnUpdateAllGSPort.Name = "btnUpdateAllGSPort";
            this.btnUpdateAllGSPort.Size = new System.Drawing.Size(187, 23);
            this.btnUpdateAllGSPort.TabIndex = 4;
            this.btnUpdateAllGSPort.Text = "Update All Values";
            this.btnUpdateAllGSPort.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSelectedGSPort
            // 
            this.btnUpdateSelectedGSPort.Enabled = false;
            this.btnUpdateSelectedGSPort.Location = new System.Drawing.Point(6, 166);
            this.btnUpdateSelectedGSPort.Name = "btnUpdateSelectedGSPort";
            this.btnUpdateSelectedGSPort.Size = new System.Drawing.Size(187, 23);
            this.btnUpdateSelectedGSPort.TabIndex = 2;
            this.btnUpdateSelectedGSPort.Text = "Update Selected";
            this.btnUpdateSelectedGSPort.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedGSPort.Click += new System.EventHandler(this.btnUpdateSelectedGSPort_Click);
            // 
            // lbGameserverPorts
            // 
            this.lbGameserverPorts.FormattingEnabled = true;
            this.lbGameserverPorts.ItemHeight = 16;
            this.lbGameserverPorts.Location = new System.Drawing.Point(6, 32);
            this.lbGameserverPorts.Name = "lbGameserverPorts";
            this.lbGameserverPorts.Size = new System.Drawing.Size(187, 100);
            this.lbGameserverPorts.TabIndex = 0;
            this.lbGameserverPorts.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // gbLoginserverPorts
            // 
            this.gbLoginserverPorts.Controls.Add(this.nLoginserverPort);
            this.gbLoginserverPorts.Controls.Add(this.label3);
            this.gbLoginserverPorts.Controls.Add(this.btnUpdateAllLSPort);
            this.gbLoginserverPorts.Controls.Add(this.btnUpdateSelectedLSPort);
            this.gbLoginserverPorts.Controls.Add(this.lbLoginserverPorts);
            this.gbLoginserverPorts.Location = new System.Drawing.Point(365, 236);
            this.gbLoginserverPorts.Name = "gbLoginserverPorts";
            this.gbLoginserverPorts.Size = new System.Drawing.Size(203, 228);
            this.gbLoginserverPorts.TabIndex = 7;
            this.gbLoginserverPorts.TabStop = false;
            this.gbLoginserverPorts.Text = "Loginserver Ports";
            // 
            // nLoginserverPort
            // 
            this.nLoginserverPort.Enabled = false;
            this.nLoginserverPort.Location = new System.Drawing.Point(95, 139);
            this.nLoginserverPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nLoginserverPort.Name = "nLoginserverPort";
            this.nLoginserverPort.Size = new System.Drawing.Size(98, 22);
            this.nLoginserverPort.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Value :";
            // 
            // btnUpdateAllLSPort
            // 
            this.btnUpdateAllLSPort.Enabled = false;
            this.btnUpdateAllLSPort.Location = new System.Drawing.Point(6, 195);
            this.btnUpdateAllLSPort.Name = "btnUpdateAllLSPort";
            this.btnUpdateAllLSPort.Size = new System.Drawing.Size(187, 23);
            this.btnUpdateAllLSPort.TabIndex = 4;
            this.btnUpdateAllLSPort.Text = "Update All Values";
            this.btnUpdateAllLSPort.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSelectedLSPort
            // 
            this.btnUpdateSelectedLSPort.Enabled = false;
            this.btnUpdateSelectedLSPort.Location = new System.Drawing.Point(6, 166);
            this.btnUpdateSelectedLSPort.Name = "btnUpdateSelectedLSPort";
            this.btnUpdateSelectedLSPort.Size = new System.Drawing.Size(187, 23);
            this.btnUpdateSelectedLSPort.TabIndex = 2;
            this.btnUpdateSelectedLSPort.Text = "Update Selected";
            this.btnUpdateSelectedLSPort.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedLSPort.Click += new System.EventHandler(this.btnUpdateSelectedLSPort_Click);
            // 
            // lbLoginserverPorts
            // 
            this.lbLoginserverPorts.FormattingEnabled = true;
            this.lbLoginserverPorts.ItemHeight = 16;
            this.lbLoginserverPorts.Location = new System.Drawing.Point(6, 32);
            this.lbLoginserverPorts.Name = "lbLoginserverPorts";
            this.lbLoginserverPorts.Size = new System.Drawing.Size(187, 100);
            this.lbLoginserverPorts.TabIndex = 0;
            this.lbLoginserverPorts.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdateVersionOriginal);
            this.groupBox4.Controls.Add(this.btnUpdateVersionDisplay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nVersionOriginal);
            this.groupBox4.Controls.Add(this.nVersionDisplay);
            this.groupBox4.Location = new System.Drawing.Point(365, 470);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 154);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Version";
            // 
            // btnUpdateVersionOriginal
            // 
            this.btnUpdateVersionOriginal.Location = new System.Drawing.Point(23, 113);
            this.btnUpdateVersionOriginal.Name = "btnUpdateVersionOriginal";
            this.btnUpdateVersionOriginal.Size = new System.Drawing.Size(159, 23);
            this.btnUpdateVersionOriginal.TabIndex = 5;
            this.btnUpdateVersionOriginal.Text = "Update";
            this.btnUpdateVersionOriginal.UseVisualStyleBackColor = true;
            // 
            // btnUpdateVersionDisplay
            // 
            this.btnUpdateVersionDisplay.Location = new System.Drawing.Point(23, 53);
            this.btnUpdateVersionDisplay.Name = "btnUpdateVersionDisplay";
            this.btnUpdateVersionDisplay.Size = new System.Drawing.Size(159, 23);
            this.btnUpdateVersionDisplay.TabIndex = 4;
            this.btnUpdateVersionDisplay.Text = "Update";
            this.btnUpdateVersionDisplay.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Original";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Display";
            // 
            // nVersionOriginal
            // 
            this.nVersionOriginal.Location = new System.Drawing.Point(95, 92);
            this.nVersionOriginal.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nVersionOriginal.Name = "nVersionOriginal";
            this.nVersionOriginal.Size = new System.Drawing.Size(87, 22);
            this.nVersionOriginal.TabIndex = 1;
            // 
            // nVersionDisplay
            // 
            this.nVersionDisplay.Location = new System.Drawing.Point(95, 26);
            this.nVersionDisplay.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nVersionDisplay.Name = "nVersionDisplay";
            this.nVersionDisplay.Size = new System.Drawing.Size(87, 22);
            this.nVersionDisplay.TabIndex = 0;
            // 
            // gbTableKeys
            // 
            this.gbTableKeys.Controls.Add(this.label12);
            this.gbTableKeys.Controls.Add(this.lbKey3P);
            this.gbTableKeys.Controls.Add(this.lbKey2P);
            this.gbTableKeys.Controls.Add(this.lbKey1P);
            this.gbTableKeys.Controls.Add(this.label11);
            this.gbTableKeys.Controls.Add(this.lbKey3);
            this.gbTableKeys.Controls.Add(this.lbKey2);
            this.gbTableKeys.Controls.Add(this.btnUpdateAllKeys);
            this.gbTableKeys.Controls.Add(this.btnUpdateSelectedKey);
            this.gbTableKeys.Controls.Add(this.label8);
            this.gbTableKeys.Controls.Add(this.label7);
            this.gbTableKeys.Controls.Add(this.label6);
            this.gbTableKeys.Controls.Add(this.tbKey2);
            this.gbTableKeys.Controls.Add(this.tbKey1);
            this.gbTableKeys.Controls.Add(this.tbKey3);
            this.gbTableKeys.Controls.Add(this.lbKey1);
            this.gbTableKeys.Location = new System.Drawing.Point(574, 13);
            this.gbTableKeys.Name = "gbTableKeys";
            this.gbTableKeys.Size = new System.Drawing.Size(503, 451);
            this.gbTableKeys.TabIndex = 9;
            this.gbTableKeys.TabStop = false;
            this.gbTableKeys.Text = "Table Keys";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Pattern 2 (LEA)";
            // 
            // lbKey3P
            // 
            this.lbKey3P.FormattingEnabled = true;
            this.lbKey3P.ItemHeight = 16;
            this.lbKey3P.Location = new System.Drawing.Point(347, 227);
            this.lbKey3P.Name = "lbKey3P";
            this.lbKey3P.Size = new System.Drawing.Size(150, 116);
            this.lbKey3P.TabIndex = 18;
            // 
            // lbKey2P
            // 
            this.lbKey2P.FormattingEnabled = true;
            this.lbKey2P.ItemHeight = 16;
            this.lbKey2P.Location = new System.Drawing.Point(182, 227);
            this.lbKey2P.Name = "lbKey2P";
            this.lbKey2P.Size = new System.Drawing.Size(150, 116);
            this.lbKey2P.TabIndex = 17;
            // 
            // lbKey1P
            // 
            this.lbKey1P.FormattingEnabled = true;
            this.lbKey1P.ItemHeight = 16;
            this.lbKey1P.Location = new System.Drawing.Point(21, 227);
            this.lbKey1P.Name = "lbKey1P";
            this.lbKey1P.Size = new System.Drawing.Size(150, 116);
            this.lbKey1P.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Pattern 1 (PUSH,MOV)";
            // 
            // lbKey3
            // 
            this.lbKey3.FormattingEnabled = true;
            this.lbKey3.ItemHeight = 16;
            this.lbKey3.Location = new System.Drawing.Point(347, 57);
            this.lbKey3.Name = "lbKey3";
            this.lbKey3.Size = new System.Drawing.Size(150, 132);
            this.lbKey3.TabIndex = 14;
            // 
            // lbKey2
            // 
            this.lbKey2.FormattingEnabled = true;
            this.lbKey2.ItemHeight = 16;
            this.lbKey2.Location = new System.Drawing.Point(182, 57);
            this.lbKey2.Name = "lbKey2";
            this.lbKey2.Size = new System.Drawing.Size(150, 132);
            this.lbKey2.TabIndex = 13;
            // 
            // btnUpdateAllKeys
            // 
            this.btnUpdateAllKeys.Location = new System.Drawing.Point(262, 418);
            this.btnUpdateAllKeys.Name = "btnUpdateAllKeys";
            this.btnUpdateAllKeys.Size = new System.Drawing.Size(232, 23);
            this.btnUpdateAllKeys.TabIndex = 7;
            this.btnUpdateAllKeys.Text = "Update All Values";
            this.btnUpdateAllKeys.UseVisualStyleBackColor = true;
            this.btnUpdateAllKeys.Click += new System.EventHandler(this.btnUpdateAllKeys_Click);
            // 
            // btnUpdateSelectedKey
            // 
            this.btnUpdateSelectedKey.Enabled = false;
            this.btnUpdateSelectedKey.Location = new System.Drawing.Point(18, 418);
            this.btnUpdateSelectedKey.Name = "btnUpdateSelectedKey";
            this.btnUpdateSelectedKey.Size = new System.Drawing.Size(232, 23);
            this.btnUpdateSelectedKey.TabIndex = 6;
            this.btnUpdateSelectedKey.Text = "Update Selected";
            this.btnUpdateSelectedKey.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(347, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Key 3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(182, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Key 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Key 1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbKey2
            // 
            this.tbKey2.Location = new System.Drawing.Point(182, 379);
            this.tbKey2.Name = "tbKey2";
            this.tbKey2.Size = new System.Drawing.Size(153, 22);
            this.tbKey2.TabIndex = 9;
            this.tbKey2.Tag = "5";
            // 
            // tbKey1
            // 
            this.tbKey1.Location = new System.Drawing.Point(18, 379);
            this.tbKey1.Name = "tbKey1";
            this.tbKey1.Size = new System.Drawing.Size(150, 22);
            this.tbKey1.TabIndex = 8;
            this.tbKey1.Tag = "4";
            // 
            // tbKey3
            // 
            this.tbKey3.Location = new System.Drawing.Point(347, 377);
            this.tbKey3.Name = "tbKey3";
            this.tbKey3.Size = new System.Drawing.Size(147, 22);
            this.tbKey3.TabIndex = 7;
            this.tbKey3.Tag = "6";
            // 
            // lbKey1
            // 
            this.lbKey1.FormattingEnabled = true;
            this.lbKey1.ItemHeight = 16;
            this.lbKey1.Location = new System.Drawing.Point(21, 57);
            this.lbKey1.Name = "lbKey1";
            this.lbKey1.Size = new System.Drawing.Size(150, 132);
            this.lbKey1.TabIndex = 6;
            // 
            // gbMisc
            // 
            this.gbMisc.Controls.Add(this.nRotate);
            this.gbMisc.Controls.Add(this.nMove);
            this.gbMisc.Controls.Add(this.label10);
            this.gbMisc.Controls.Add(this.label9);
            this.gbMisc.Controls.Add(this.cbDisableWebsite);
            this.gbMisc.Controls.Add(this.cbDisableLauncher);
            this.gbMisc.Controls.Add(this.cbEnableMulti);
            this.gbMisc.Location = new System.Drawing.Point(12, 470);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(347, 154);
            this.gbMisc.TabIndex = 10;
            this.gbMisc.TabStop = false;
            this.gbMisc.Text = "Misc.";
            // 
            // nRotate
            // 
            this.nRotate.Enabled = false;
            this.nRotate.Location = new System.Drawing.Point(200, 126);
            this.nRotate.Name = "nRotate";
            this.nRotate.Size = new System.Drawing.Size(120, 22);
            this.nRotate.TabIndex = 13;
            // 
            // nMove
            // 
            this.nMove.Enabled = false;
            this.nMove.Location = new System.Drawing.Point(200, 102);
            this.nMove.Name = "nMove";
            this.nMove.Size = new System.Drawing.Size(120, 22);
            this.nMove.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Rotate packet interval :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Move packet interval :";
            // 
            // cbDisableWebsite
            // 
            this.cbDisableWebsite.AutoSize = true;
            this.cbDisableWebsite.Enabled = false;
            this.cbDisableWebsite.Location = new System.Drawing.Point(27, 75);
            this.cbDisableWebsite.Name = "cbDisableWebsite";
            this.cbDisableWebsite.Size = new System.Drawing.Size(173, 21);
            this.cbDisableWebsite.TabIndex = 2;
            this.cbDisableWebsite.Text = "Disable website on exit";
            this.cbDisableWebsite.UseVisualStyleBackColor = true;
            // 
            // cbDisableLauncher
            // 
            this.cbDisableLauncher.AutoSize = true;
            this.cbDisableLauncher.Enabled = false;
            this.cbDisableLauncher.Location = new System.Drawing.Point(27, 48);
            this.cbDisableLauncher.Name = "cbDisableLauncher";
            this.cbDisableLauncher.Size = new System.Drawing.Size(177, 21);
            this.cbDisableLauncher.TabIndex = 1;
            this.cbDisableLauncher.Text = "Disable launcher check";
            this.cbDisableLauncher.UseVisualStyleBackColor = true;
            // 
            // cbEnableMulti
            // 
            this.cbEnableMulti.AutoSize = true;
            this.cbEnableMulti.Enabled = false;
            this.cbEnableMulti.Location = new System.Drawing.Point(27, 21);
            this.cbEnableMulti.Name = "cbEnableMulti";
            this.cbEnableMulti.Size = new System.Drawing.Size(190, 21);
            this.cbEnableMulti.TabIndex = 0;
            this.cbEnableMulti.Text = "Disable multiclient control";
            this.cbEnableMulti.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbURLs
            // 
            this.gbURLs.Controls.Add(this.lblRemaining);
            this.gbURLs.Controls.Add(this.btnUpdateURL);
            this.gbURLs.Controls.Add(this.tbSelectedURL);
            this.gbURLs.Controls.Add(this.label13);
            this.gbURLs.Controls.Add(this.lbURLs);
            this.gbURLs.Location = new System.Drawing.Point(574, 470);
            this.gbURLs.Name = "gbURLs";
            this.gbURLs.Size = new System.Drawing.Size(503, 154);
            this.gbURLs.TabIndex = 11;
            this.gbURLs.TabStop = false;
            this.gbURLs.Text = "URLs";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblRemaining.Location = new System.Drawing.Point(18, 128);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(118, 13);
            this.lblRemaining.TabIndex = 4;
            this.lblRemaining.Text = "0 character(s) remaining";
            // 
            // btnUpdateURL
            // 
            this.btnUpdateURL.Location = new System.Drawing.Point(376, 104);
            this.btnUpdateURL.Name = "btnUpdateURL";
            this.btnUpdateURL.Size = new System.Drawing.Size(118, 23);
            this.btnUpdateURL.TabIndex = 3;
            this.btnUpdateURL.Text = "Update";
            this.btnUpdateURL.UseVisualStyleBackColor = true;
            this.btnUpdateURL.Click += new System.EventHandler(this.btnUpdateURL_Click);
            // 
            // tbSelectedURL
            // 
            this.tbSelectedURL.Location = new System.Drawing.Point(18, 104);
            this.tbSelectedURL.Name = "tbSelectedURL";
            this.tbSelectedURL.Size = new System.Drawing.Size(352, 22);
            this.tbSelectedURL.TabIndex = 2;
            this.tbSelectedURL.Tag = "7";
            this.tbSelectedURL.TextChanged += new System.EventHandler(this.tbSelectedURL_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(352, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "NOTE : New URL cannot exceed the length of old one.";
            // 
            // lbURLs
            // 
            this.lbURLs.FormattingEnabled = true;
            this.lbURLs.ItemHeight = 16;
            this.lbURLs.Location = new System.Drawing.Point(18, 44);
            this.lbURLs.Name = "lbURLs";
            this.lbURLs.Size = new System.Drawing.Size(476, 52);
            this.lbURLs.TabIndex = 0;
            this.lbURLs.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 637);
            this.Controls.Add(this.gbURLs);
            this.Controls.Add(this.gbMisc);
            this.Controls.Add(this.gbTableKeys);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbLoginserverPorts);
            this.Controls.Add(this.gbGameserverPorts);
            this.Controls.Add(this.gbPrivateKeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KO Executable Editor :: Edit ";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.gbPrivateKeys.ResumeLayout(false);
            this.gbPrivateKeys.PerformLayout();
            this.gbGameserverPorts.ResumeLayout(false);
            this.gbGameserverPorts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGameserverPort)).EndInit();
            this.gbLoginserverPorts.ResumeLayout(false);
            this.gbLoginserverPorts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLoginserverPort)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVersionOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVersionDisplay)).EndInit();
            this.gbTableKeys.ResumeLayout(false);
            this.gbTableKeys.PerformLayout();
            this.gbMisc.ResumeLayout(false);
            this.gbMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMove)).EndInit();
            this.gbURLs.ResumeLayout(false);
            this.gbURLs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbPrivateKeys;
        private Label label1;
        private Button btnUpdateAllPK;
        private TextBox tbPrivateKey;
        private Button btnUpdateSelectedPK;
        private ListBox lbPrivateKeys;
        private GroupBox gbGameserverPorts;
        private Label label2;
        private Button btnUpdateAllGSPort;
        private Button btnUpdateSelectedGSPort;
        private ListBox lbGameserverPorts;
        private GroupBox gbLoginserverPorts;
        private Label label3;
        private Button btnUpdateAllLSPort;
        private Button btnUpdateSelectedLSPort;
        private ListBox lbLoginserverPorts;
        private GroupBox groupBox4;
        private Button btnUpdateVersionOriginal;
        private Button btnUpdateVersionDisplay;
        private Label label5;
        private Label label4;
        private NumericUpDown nVersionOriginal;
        private NumericUpDown nVersionDisplay;
        private GroupBox gbTableKeys;
        private Button btnUpdateAllKeys;
        private Button btnUpdateSelectedKey;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tbKey2;
        private TextBox tbKey1;
        private TextBox tbKey3;
        private ListBox lbKey1;
        private ListBox lbKey3;
        private ListBox lbKey2;
        private GroupBox gbMisc;
        private CheckBox cbDisableLauncher;
        private CheckBox cbEnableMulti;
        private CheckBox cbDisableWebsite;
        private Label label10;
        private Label label9;
        private ContextMenuStrip contextMenuStrip1;
        private NumericUpDown nMove;
        private NumericUpDown nRotate;
        private Label label11;
        private Label label12;
        private ListBox lbKey3P;
        private ListBox lbKey2P;
        private ListBox lbKey1P;
        private GroupBox gbURLs;
        private ListBox lbURLs;
        private TextBox tbSelectedURL;
        private Label label13;
        private Button btnUpdateURL;
        private NumericUpDown nGameserverPort;
        private NumericUpDown nLoginserverPort;
        private Label lblRemaining;
    }
}