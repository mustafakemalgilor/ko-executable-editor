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
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Forms;

namespace KOExecutableEditor
{
    [SuppressMessage("ReSharper", "ReturnValueOfPureMethodIsNotUsed")]
    public partial class frmEdit : Form
    {
        private readonly OffsetHelper _ofHelper = new OffsetHelper();
        private readonly Executable _protoExecutable;
        private readonly frmMain _myParent;

        private readonly BindingList<HexPair<long>> _privateKeyOffsetAndValues = new BindingList<HexPair<long>>();
        private readonly BindingList<DecPair<long>> _gameserverPortOffsetAndValues = new BindingList<DecPair<long>>();
        private readonly BindingList<DecPair<long>> _loginserverPortOffsetAndValues = new BindingList<DecPair<long>>();
        private readonly BindingList<HexPair<long>> _tablekeysp1K1 = new BindingList<HexPair<long>>();
        private readonly BindingList<HexPair<long>> _tablekeysp1K2 = new BindingList<HexPair<long>>();
        private readonly BindingList<HexPair<long>> _tablekeysp1K3 = new BindingList<HexPair<long>>();
        private readonly BindingList<HexPair<long>> _tablekeysp3K1 = new BindingList<HexPair<long>>();
        private readonly BindingList<HexPair<long>> _tablekeysp3K2 = new BindingList<HexPair<long>>();
        private readonly BindingList<HexPair<long>> _tablekeysp3K3 = new BindingList<HexPair<long>>();
        private readonly BindingList<StrPair<long>> _urlOffsetAndValues = new BindingList<StrPair<long>>(); 
        private readonly List<DecPair<long>> _urlLength = new List<DecPair<long>>(); 

        public frmEdit(Executable protoExecutable,frmMain parent)
        {
            _myParent = parent;
            _protoExecutable = protoExecutable;
            InitializeComponent();
 
        }

        private static IEnumerable<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        private static List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {
                if (c is ListBox) list.Add(c);
                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
            }

            return list;
        }

        private void LoadOffsets()
        {
            foreach (var i in _protoExecutable.PrivateKeyOffsetList)
                _privateKeyOffsetAndValues.Add(new HexPair<long>(i, _ofHelper.ReadPrivateKey(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.GameserverPortOffsetList)
                _gameserverPortOffsetAndValues.Add(new DecPair<long>(i,(ushort) _ofHelper.ReadPort(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.LoginserverPortOffsetList)
                _loginserverPortOffsetAndValues.Add(new DecPair<long>(i,(ushort) _ofHelper.ReadPort(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.TableKeysPattern1Key1)
                _tablekeysp1K1.Add(new HexPair<long>(i, (ulong)_ofHelper.ReadTBLKey_Pattern1(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.TableKeysPattern1Key2)
                _tablekeysp1K2.Add(new HexPair<long>(i, (ulong)_ofHelper.ReadTBLKey_Pattern1(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.TableKeysPattern1Key3)
                _tablekeysp1K3.Add(new HexPair<long>(i, (ulong)_ofHelper.ReadTBLKey_Pattern1(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.TableKeysPattern3Key1)
                _tablekeysp3K1.Add(new HexPair<long>(i, (ulong)_ofHelper.ReadTBLKey_Pattern3(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.TableKeysPattern3Key2)
                _tablekeysp3K2.Add(new HexPair<long>(i, (ulong)_ofHelper.ReadTBLKey_Pattern3(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.TableKeysPattern3Key3)
                _tablekeysp3K3.Add(new HexPair<long>(i, (ulong)_ofHelper.ReadTBLKey_Pattern3(_myParent.GetByteStream, i)));
            foreach (var i in _protoExecutable.URLOffsetList)
            {
                _urlOffsetAndValues.Add(new StrPair<long>(i.Offset, _ofHelper.ReadURL(_myParent.GetByteStream, i.Offset)));
                _urlLength.Add(new DecPair<long>(i.Offset, i.Length));
            }
        }

        private void SetDataSource()
        {
            foreach (var lb in GetAllControls(this))
            {
                var box = lb as ListBox;
                if (box == null) continue;

                box.DisplayMember = "Value";
                box.ValueMember = "Value";

            }
            lbPrivateKeys.DataSource = new BindingSource(_privateKeyOffsetAndValues, null);
            lbGameserverPorts.DataSource = new BindingSource(_gameserverPortOffsetAndValues, null);
            lbLoginserverPorts.DataSource = new BindingSource(_loginserverPortOffsetAndValues, null);
            lbKey1.DataSource = new BindingSource(_tablekeysp1K1, null);
            lbKey2.DataSource = new BindingSource(_tablekeysp1K2, null);
            lbKey3.DataSource = new BindingSource(_tablekeysp1K3, null);
            lbKey1P.Enabled = _tablekeysp3K1 != null;
            lbKey2P.Enabled = _tablekeysp3K2 != null;
            lbKey3P.Enabled = _tablekeysp3K3 != null;
            if (lbKey1P.Enabled)
                lbKey1P.DataSource = new BindingSource(_tablekeysp3K1, null);
            if (lbKey2P.Enabled)
                lbKey2P.DataSource = new BindingSource(_tablekeysp3K2, null);
            if (lbKey3P.Enabled)
                lbKey3P.DataSource = new BindingSource(_tablekeysp3K3, null);
            lbURLs.DataSource = new BindingSource(_urlOffsetAndValues, null);
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            nMove.DecimalPlaces = 2;
            nRotate.DecimalPlaces = 2;
            nMove.Increment = 0.1M;
            nRotate.Increment = 0.1M;

            LoadOffsets();
            SetDataSource();


            gbPrivateKeys.Enabled = _privateKeyOffsetAndValues.Count > 0;
            gbGameserverPorts.Enabled = _gameserverPortOffsetAndValues.Count > 0;
            gbLoginserverPorts.Enabled = _loginserverPortOffsetAndValues.Count > 0;
            gbURLs.Enabled = _urlOffsetAndValues.Count > 0;

            cbEnableMulti.Enabled = _protoExecutable.MutexOffset > 0;
            if (cbEnableMulti.Enabled)
            {
                cbEnableMulti.Checked = _ofHelper.checkMulticlientEnabled(_myParent.GetByteStream, _protoExecutable.MutexOffset);
            }

            gbTableKeys.Text =
                string.Format("Table Keys (K1P1 : {0}, K2P1 : {1}, K3P1 : {2}, K1P3 : {3}, K2P3 : {4}, K3P3 : {5})",
                    _tablekeysp1K1.Count,
                    _tablekeysp1K2.Count, _tablekeysp1K3.Count, 0, 0, 0);


            btnUpdateVersionDisplay.Enabled = nVersionDisplay.Enabled = _protoExecutable.VersionDisplay > 0;
            if (btnUpdateVersionDisplay.Enabled)
            {
                nVersionDisplay.Value = _ofHelper.ReadVersion_Display(_myParent.GetByteStream,
                    _protoExecutable.VersionDisplay);
            }

            btnUpdateVersionOriginal.Enabled = nVersionOriginal.Enabled = _protoExecutable.VersionOriginal > 0;
            if (btnUpdateVersionOriginal.Enabled)  
            {
                nVersionOriginal.Value = _ofHelper.ReadVersion_Original(_myParent.GetByteStream,
                 _protoExecutable.VersionOriginal); 
            }


           
        }


        
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            var who = sender as ListBox;
            if (who == null)
                return;

            switch (who.Name)
            {
                case "lbPrivateKeys":
                {
                    tbPrivateKey.Enabled = btnUpdateAllPK.Enabled = btnUpdateSelectedPK.Enabled = who.SelectedIndex > -1;
                    if (!tbPrivateKey.Enabled) return;
                    tbPrivateKey.Text = Convert.ToString(lbPrivateKeys.SelectedValue);
                }
                break;
                case "lbGameserverPorts":
                {
                    nGameserverPort.Enabled =
                        btnUpdateSelectedGSPort.Enabled = btnUpdateAllGSPort.Enabled = who.SelectedIndex > -1;
                    if (!nGameserverPort.Enabled) return;
                    nGameserverPort.Value = Convert.ToDecimal(who.SelectedValue);
                }
                break;
                case "lbLoginserverPorts":
                {
                    nLoginserverPort.Enabled =
                        btnUpdateSelectedLSPort.Enabled = btnUpdateAllLSPort.Enabled = who.SelectedIndex > -1;
                    if (!nLoginserverPort.Enabled) return;
                    nLoginserverPort.Value = Convert.ToDecimal(who.SelectedValue);
                }
                break;
                case "lbKey1":
                case "lbKey2":
                case "lbKey3":
                case "lbKey1P":
                case "lbKey2P":
                case "lbKey3P":
                    break;
                case "lbURLs":
                    tbSelectedURL.Enabled = lbURLs.Enabled = who.SelectedIndex > -1;
                    if (!tbSelectedURL.Enabled) return;
                    var key = _urlOffsetAndValues[lbURLs.SelectedIndex].Key;
                    foreach (var v in _urlLength)
                    {
                        if (v.Key == key)
                            tbSelectedURL.MaxLength = (int) v.Value;
                    }

                    tbSelectedURL.Text = ((String) lbURLs.SelectedValue);
                    break;

            }

        }

        private void btnUpdateURL_Click(object sender, EventArgs e)
        {
            var key = _urlOffsetAndValues[lbURLs.SelectedIndex].Key;
            _ofHelper.WriteNewURL(_myParent.GetByteStream, key, tbSelectedURL.Text,
                tbSelectedURL.MaxLength - tbSelectedURL.Text.Length);
           
            _urlOffsetAndValues[lbURLs.SelectedIndex].Value = tbSelectedURL.Text;
            _urlOffsetAndValues.ResetBindings();
            MessageBox.Show("The URL is updated successfully.", "Information", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void tbSelectedURL_TextChanged(object sender, EventArgs e)
        {
            lblRemaining.Text = string.Format("{0} character(s) remaining.",
                tbSelectedURL.MaxLength - tbSelectedURL.Text.Length);
        }

        private void btnUpdateSelectedPK_Click(object sender, EventArgs e)
        {
            try
            {
                UInt64.Parse(tbPrivateKey.Text.Replace("0x",""), NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("The value entered is not a valid hexadecimal number.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            var key = _privateKeyOffsetAndValues[lbPrivateKeys.SelectedIndex].Key;
            _ofHelper.WriteNewPrivateKey(_myParent.GetByteStream,key,Convert.ToUInt64(tbPrivateKey.Text,16));
            _privateKeyOffsetAndValues[lbPrivateKeys.SelectedIndex].Value.Update(Convert.ToUInt64(tbPrivateKey.Text.Replace("0x", ""), 16)); 
            _privateKeyOffsetAndValues.ResetBindings();
            MessageBox.Show("The key is updated successfully.", "Information", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void btnUpdateAllPK_Click(object sender, EventArgs e)
        {
            try
            {
                UInt64.Parse(tbPrivateKey.Text.Replace("0x", ""), NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("The value entered is not a valid hexadecimal number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var v in _privateKeyOffsetAndValues)
            {
                _ofHelper.WriteNewPrivateKey(_myParent.GetByteStream, v.Key, Convert.ToUInt64(tbPrivateKey.Text, 16));
                v.Value.Update(Convert.ToUInt64(tbPrivateKey.Text.Replace("0x", ""), 16)); 
            }
            _privateKeyOffsetAndValues.ResetBindings();
            MessageBox.Show("All existing key(s) are updated successfully.", "Information", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void btnUpdateSelectedGSPort_Click(object sender, EventArgs e)
        {
            var key = _gameserverPortOffsetAndValues[lbGameserverPorts.SelectedIndex];
            _ofHelper.WriteNewPort(_myParent.GetByteStream, key.Key, (ushort) nGameserverPort.Value);
            _gameserverPortOffsetAndValues[lbGameserverPorts.SelectedIndex].Value = (long) nGameserverPort.Value;
            _gameserverPortOffsetAndValues.ResetBindings();
            MessageBox.Show("Selected gameserver port is updated successfully.", "Information", MessageBoxButtons.OK
               , MessageBoxIcon.Information);
        }

        private void btnUpdateSelectedLSPort_Click(object sender, EventArgs e)
        {
            var key = _loginserverPortOffsetAndValues[lbLoginserverPorts.SelectedIndex];
            _ofHelper.WriteNewPort(_myParent.GetByteStream, key.Key, (ushort)nLoginserverPort.Value);
            _loginserverPortOffsetAndValues[lbLoginserverPorts.SelectedIndex].Value = (long)nLoginserverPort.Value;
            _loginserverPortOffsetAndValues.ResetBindings();
            MessageBox.Show("Selected loginserver port is updated successfully.", "Information", MessageBoxButtons.OK
               , MessageBoxIcon.Information);
        }

        private void btnUpdateAllKeys_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32.Parse(tbKey1.Text.Replace("0x",""), NumberStyles.HexNumber);
                UInt32.Parse(tbKey2.Text.Replace("0x", ""), NumberStyles.HexNumber);
                UInt32.Parse(tbKey3.Text.Replace("0x", ""), NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("One of the key(s) is not in valid format. The input should be in hexadecimal(0xffff) format.\nPlease correct it and try again.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            foreach (var v in _tablekeysp1K1)
            {
                _ofHelper.WriteNewKey_Pattern1(_myParent.GetByteStream, v.Key, Convert.ToUInt32(tbKey1.Text, 16));
                v.Value.Update(Convert.ToUInt32(tbKey1.Text, 16));
            }
            foreach (var v in _tablekeysp1K2)
            {
                _ofHelper.WriteNewKey_Pattern1(_myParent.GetByteStream, v.Key, Convert.ToUInt32(tbKey2.Text, 16));
                v.Value.Update(Convert.ToUInt32(tbKey2.Text, 16));
            }
            foreach (var v in _tablekeysp1K3)
            {
                _ofHelper.WriteNewKey_Pattern1(_myParent.GetByteStream, v.Key, Convert.ToUInt32(tbKey3.Text, 16));
                v.Value.Update(Convert.ToUInt32(tbKey3.Text, 16));
            }

            foreach (var v in  _tablekeysp3K1)
            {
                _ofHelper.WriteNewKey_Pattern3(_myParent.GetByteStream, v.Key, Convert.ToUInt32(tbKey1.Text, 16));
                v.Value.Update(Convert.ToUInt32(tbKey1.Text, 16));
            }
            foreach (var v in _tablekeysp3K2)
            {
                _ofHelper.WriteNewKey_Pattern3(_myParent.GetByteStream, v.Key, Convert.ToUInt32(tbKey2.Text, 16));
                v.Value.Update(Convert.ToUInt32(tbKey2.Text, 16));
            }
            foreach (var v in _tablekeysp3K3)
            {
                _ofHelper.WriteNewKey_Pattern3(_myParent.GetByteStream, v.Key, Convert.ToUInt32(tbKey3.Text, 16));
                v.Value.Update(Convert.ToUInt32(tbKey3.Text, 16));
            }

            _tablekeysp1K1.ResetBindings();
            _tablekeysp1K2.ResetBindings();
            _tablekeysp1K3.ResetBindings();
            _tablekeysp3K1.ResetBindings();
            _tablekeysp3K2.ResetBindings();
            _tablekeysp3K3.ResetBindings();

            MessageBox.Show("The key(s) are successfully updated.");

        }
    }

    public class StrPair<T>
    {
         public StrPair(T v, string v2)
        {
            Key = v;
             Value = v2;
        }
        public T Key { get; set; }
        public string Value { get; set; }  
    }

    public class HexPair<T>
    {
        public HexPair(T v, ulong v2)
        {
            Key = v;
            Value = new HexValue(v2);
        }
        public T Key { get; set; }
        public HexValue Value { get; set; }
    }

    public class DecPair<T>
    {
        public DecPair(T v, T v2)
        {
            Key = v;
            Value = v2;
        }
        public T Key { get; set; }
        public T Value { get; set; }
    }

    public class HexValue
    {
        public HexValue(ulong va)
        {
            _value = va;
        }

        public void Update(ulong va)
        {
            _value = va;
        }
        public override string ToString() { return "0x" + _value.ToString("X"); }
        private  ulong _value;
    }

    class DecValue
    {
       public DecValue(ulong va)
        {
            _value = va;
        }
       public void Update(ulong va)
       {
           _value = va;
       }
        public override string ToString() { return  _value.ToString(); }
        private  ulong _value;  
    }
}
