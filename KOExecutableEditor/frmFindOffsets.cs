/**
 * ______________________________________________________
 * This file is part of ko-executable-editor project.
 * 
 * @author       Mustafa Kemal Gılor <mustafagilor@gmail.com> (2016)
 * .
 * SPDX-License-Identifier:	MIT
 * ______________________________________________________
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
#pragma warning disable 649

namespace KOExecutableEditor
{
    public partial class frmFindOffsets : Form
    {
        private readonly frmMain _myParent;
        private readonly OffsetHelper _ofHelper = new OffsetHelper();
        private List<int> _privateKeyOffsets;
        private List<int> _gameserverPortOffsets;
        private List<int> _loginserverPortOffsets;
        private List<int> _tableKeysPattern1Key1;
        private List<int> _tableKeysPattern1Key2;
        private List<int> _tableKeysPattern1Key3;
        private List<int> _tableKeysPattern3Key1;
        private List<int> _tableKeysPattern3Key2;
        private List<int> _tableKeysPattern3Key3;
        private readonly Dictionary<int, int> _urlOffsets = new Dictionary<int, int>();
        private int _versionOriginal;
        private int _versionDisplay;

        private int _multiclientOffset;
        private int _launcherCheckOffset;
        private int _movePacketIntervalOffset;
        private int _rotatePacketIntervalOffset;
        private int _openWebsiteOffset;
        
 
        public frmFindOffsets(frmMain myParent)
        {
            _myParent = myParent;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbPKList.Items.Clear();
            string pk;
            switch (cbPrivateKey.SelectedIndex)
            {
                case 0:
                    pk = "0x1207500120128966";
                    break;
                case 1:
                    pk = "0x1234567890123456";
                    break;
                case 2:
                    pk = "0x1257091582190465";
                    break;
                default:
                    pk = cbPrivateKey.Text;
                    break;
            }
            _privateKeyOffsets = _ofHelper.FindPrivateKey(_myParent.GetByteStream,pk);
            foreach (var i in _privateKeyOffsets)
            {
                lbPKList.Items.Add("(Offset) : " + i);
            }

            switch (_privateKeyOffsets.Count)
            {
                case 5:
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    break;
                case 0:
                    MessageBox.Show(
                        "No match found for the specified private key.\nEither private key is different, or file might be packed.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    DialogResult dr= MessageBox.Show(
                        "Some of the private key offsets are missing.\nEither file is damaged, or the executable uses a new technique.\nDo you want to continue anyway?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                    }
                    break;
            }
           

        }

        private void btnSearchPorts_Click(object sender, EventArgs e)
        {
            lbPorts.Items.Clear();
            _gameserverPortOffsets = _ofHelper.FindPort(_myParent.GetByteStream,textBox1.Text);
            _loginserverPortOffsets = _ofHelper.FindPort(_myParent.GetByteStream,textBox2.Text);
            foreach (int i in _gameserverPortOffsets)
            {
                lbPorts.Items.Add("[Gameserver](Offset) : " + i);
            }
            foreach (int i in _loginserverPortOffsets)
            {
                lbPorts.Items.Add("[Loginserver](Offset) : " + i);
            }

            if (_gameserverPortOffsets.Count >= 1 && _loginserverPortOffsets.Count >= 1)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }

        private void btnSearchVersion_Click(object sender, EventArgs e)
        {
            lbVersions.Items.Clear();
            _versionOriginal = _ofHelper.FindVersion_Original(_myParent.GetByteStream,tbVersionOriginal.Text);
            _versionDisplay = _ofHelper.FindVersion_Display(_myParent.GetByteStream, tbVersionDisplay.Text);
            lbVersions.Items.Add("[Original](Offset) : " + _versionOriginal);
            lbVersions.Items.Add("[Display](Offset) : " + _versionDisplay);
            if (_versionOriginal != 0)
            {
                groupBox3.Enabled = false;
                gbTableEncryption.Enabled = true;
            }
        }

        private void frmFindOffsets_Load(object sender, EventArgs e)
        {

        }



        private void btnSearchKeys_Click(object sender, EventArgs e)
        {
            lbTableKeys.Items.Clear();
            _tableKeysPattern1Key1 = _ofHelper.FindTBLKey_Pattern1(_myParent.GetByteStream, tbKey1.Text);
            _tableKeysPattern1Key2 = _ofHelper.FindTBLKey_Pattern1(_myParent.GetByteStream, tbKey2.Text);
            _tableKeysPattern1Key3 = _ofHelper.FindTBLKey_Pattern1(_myParent.GetByteStream, tbKey3.Text);

            _tableKeysPattern3Key1 = _ofHelper.FindTBLKey1_Pattern3(_myParent.GetByteStream, tbKey1.Text);
            _tableKeysPattern3Key2 = _ofHelper.FindTBLKey1_Pattern3(_myParent.GetByteStream, tbKey2.Text);
            _tableKeysPattern3Key3 = _ofHelper.FindTBLKey1_Pattern3(_myParent.GetByteStream, tbKey3.Text);

            label12.Text = _tableKeysPattern1Key1.Count.ToString();
            label11.Text = _tableKeysPattern1Key2.Count.ToString();
            label9.Text = _tableKeysPattern1Key3.Count.ToString();

            foreach (var v in _tableKeysPattern1Key1)
                lbTableKeys.Items.Add(string.Format("[P1][K1](Offset) : {0}", v));
            foreach (var v in _tableKeysPattern1Key2)
                lbTableKeys.Items.Add(string.Format("[P1][K2](Offset) : {0}", v));
            foreach (var v in _tableKeysPattern1Key3)
                lbTableKeys.Items.Add(string.Format("[P1][K3](Offset) : {0}", v));


            foreach (var v in _tableKeysPattern3Key1)
                lbTableKeys.Items.Add(string.Format("[P3][K1](Offset) : {0}", v));
            foreach (var v in _tableKeysPattern3Key2)
                lbTableKeys.Items.Add(string.Format("[P3][K2](Offset) : {0}", v));
            foreach (var v in _tableKeysPattern3Key3)
                lbTableKeys.Items.Add(string.Format("[P3][K3](Offset) : {0}", v));


            bool tableValuesFound =
                (_tableKeysPattern1Key1.Count > 0 &&
                 _tableKeysPattern1Key2.Count > 0 &&
                 _tableKeysPattern1Key3.Count > 0 &&
      
                 _tableKeysPattern3Key1.Count > 0);
            if (!tableValuesFound)
            {
              var dr=  MessageBox.Show(
                    "It seems to be there's some table key values are missing. It can mean that one of your key value are wrong.\nDo you want to continue?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
            }

            gbTableEncryption.Enabled = false;
            gbOtherOptions.Enabled = true;

        }

        private void btnSearchMisc_Click(object sender, EventArgs e)
        {
            if (cbFindMutex.Checked)
            {
                _multiclientOffset = _ofHelper.FindMutex(_myParent.GetByteStream);
                if (_multiclientOffset > 0)
                {
                    cbFindMutex.Text = "Mutex offset found(" + _multiclientOffset + ")";
                    cbFindMutex.Enabled = false;
                }
            }
            if (cbFindURLS.Checked)
            {
                var urLs = _ofHelper.FindURLs(_myParent.GetByteStream);
                foreach (var v in urLs)
                {
                    lbURLs.Items.Add(string.Format("[URL](Offset) : {0}, (Value) : {1}", v.Key, v.Value));
                    _urlOffsets.Add(v.Key, v.Value.Length);
                }
            }

          
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            using (var fa = new frmAuthor())
            {
                var ai = fa.GetAuthorInformation();
                var ex = new Executable();
               var done =  ex.Initialize(
                    new FileInfo(_myParent.GetCurrentFile),
                    ai,

                    _privateKeyOffsets,
                    _gameserverPortOffsets,
                    _loginserverPortOffsets,

                    _tableKeysPattern1Key1,
                    _tableKeysPattern1Key2,
                    _tableKeysPattern1Key3,

                    _tableKeysPattern3Key1,
                     _tableKeysPattern3Key2,
                     _tableKeysPattern3Key3,

                     _urlOffsets,
                    _versionOriginal, 
                    _versionDisplay,
                    _multiclientOffset,
                    _launcherCheckOffset,
                    _movePacketIntervalOffset,
                    _rotatePacketIntervalOffset,
                    _openWebsiteOffset);
                if (!done) return;

                _myParent.AddNewExecutable(ex);
                MessageBox.Show("New file definition successfully added.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
