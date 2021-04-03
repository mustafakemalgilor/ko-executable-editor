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
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KOExecutableEditor
{
    public partial class frmMain : Form
    {

        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);   



        private Executable _currentSignatureExecutable;
        public byte[] GetByteStream { get; private set; }
        public string GetCurrentFile { get; private set; }
        public List<Executable> GetExecutableList { get; private set; }

        private readonly OffsetHelper _ofHelper = new OffsetHelper();

        static byte[] CalculateHash(string fname)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fname))
                {
                    return md5.ComputeHash(stream);
                }
            }
        }

        #region Executable Signature List Load / Save / Insert

        public void AddNewExecutable(Executable x)
        {
            GetExecutableList.Add(x);
            SaveExecutableList();

        }

        void SaveExecutableList()
        {
            var x = new XmlSerializer(typeof(List<Executable>));

            using (TextWriter writer = new StreamWriter(@".\executableSignatures.xml"))
            {
                x.Serialize(writer, GetExecutableList);
            }
        }

        void LoadExecutableList()
        {
            // Check if file exist.
            if (!File.Exists(@".\executableSignatures.xml"))
                return;
            var x = new XmlSerializer(typeof(List<Executable>));
            using (TextReader reader = new StreamReader(@".\executableSignatures.xml"))
            {
                var dsr = x.Deserialize(reader);

                foreach (var v in (List<Executable>)dsr)
                {
                    GetExecutableList.Add(v);
                }
            }
            Text = string.Format("Knight OnLine Executable Editor(2015) :: {0} signature(s) loaded.",
                GetExecutableList.Count);
        }

        #endregion


        public frmMain()
        {
            GetExecutableList = new List<Executable>();
            InitializeComponent();
            LoadExecutableList();
            lblPentagram.Links.Add(0, "http://insomniacoder.blogspot.com".Length, "http://insomniacoder.blogspot.com");
            PromptLoadFile();
            BringToFront();
            SetForegroundWindow(Handle.ToInt32());
        }

        private void Form1_Load(object sender, EventArgs e) {}


        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var edit = new frmEdit(_currentSignatureExecutable,this))
            {
                edit.ShowDialog();
            }
        }


        #region Load / Save / Close file

        void LoadFile(string path)
        {
            try
            {


                var fiSig = new FileSignature();
                fiSig.Initialize(new PeHeaderReader(path));
                var matchingExecutables = new List<Executable>();
                foreach (var x in GetExecutableList)
                {

                    if (fiSig.Compare(x.FileSignature))
                    {
                        matchingExecutables.Add(x);
                    }
                }

                if (matchingExecutables.Count >= 1)
                {
                    _currentSignatureExecutable = matchingExecutables[0];
                    UpdateSignatureUI();
                }
                else
                {
                    var dr =
                        MessageBox.Show("No matching signature found for specified file. \nDo you want to define it?",
                            "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        using (var fi = new frmFindOffsets(this))
                        {
                            fi.ShowDialog();
                            // Reload
                            CloseFile();
                            LoadFile(path);
                        }
                    }
                    else
                    {
                        GetByteStream = null;
                        OpenFile.Reset();
                        SetFileOperations(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occured while trying to load file.\nDetails : "+ ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
        }
        void PromptLoadFile()
        {
            CloseFile();
            GetByteStream = null;
            try
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    using (var fs = new FileStream(OpenFile.FileName, FileMode.Open))
                    {
                        var fi = new FileInfo(OpenFile.FileName);
                        using (var br = new BinaryReader(fs))
                        {
                            GetByteStream = new byte[fi.Length];
                            br.Read(GetByteStream, 0, (int) fi.Length);
                        }
                        lblFilename.Text = fi.Name;
                        lblSize.Text = fi.Length + " byte(s)";
                    }
                    SetFileOperations(true);
                    GetCurrentFile = OpenFile.FileName;
                    lblFileMD5.Text = BitConverter.ToString(CalculateHash(OpenFile.FileName));

                }
                else
                    return;
                LoadFile(OpenFile.FileName);
            }
            catch (IOException)
            {
                MessageBox.Show("File is currently used by another program.\nTry closing it first.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);  
            }
           

        }

        void SaveToFile(string fullPath)
        {
            var fi = new FileInfo(fullPath);
            if (fi.Exists)
            {
                // Delete the existing file
                fi.Delete();
            }
            File.WriteAllBytes(fullPath, GetByteStream);

            MessageBox.Show(string.Format("The file {0} is saved successfully.", fi.Name), "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void CloseFile()
        {
            GetByteStream = null;
            _currentSignatureExecutable = null;
            ResetUI();
        }

        #endregion

        #region UI Operations


        public void SetFileOperations(bool val)
        {
            tsSave.Enabled = val;
            tsSaveAs.Enabled = val;
            tsCloseFile.Enabled = val;
            gbDetails.Enabled = val;
            if (val) return;

            lblFilename.Text = "";
            lblSize.Text = "";
            lblVersion.Text = "";
        }

        private void ResetUI()
        {
            OpenFile.Reset();
            SetFileOperations(false);
            GetCurrentFile = "";
            lblURL.Links.Clear();
            lblAuthor.Text = "-";
            lblURL.Text = "-";
            lblOriginalFilename.Text = "-";
            lblOriginalFileSize.Text = "-";
            lblTimestamp.Text = "-";
            lblOriginalMD5.Text = "-";
            lblFileMD5.Text = "-";
            tbDesciption.Text = "";
            lblGameserverPort.Text = "";
            lblLoginPort.Text = "";
        }

        void UpdateSignatureUI()
        {
            lblOriginalFilename.Text = _currentSignatureExecutable.FileInformation.OriginalName;
            lblOriginalFileSize.Text = _currentSignatureExecutable.FileInformation.Size + " byte(s)";
            lblTimestamp.Text = _currentSignatureExecutable.AuthorInformation.Timestamp.ToLongDateString();
            lblAuthor.Text = _currentSignatureExecutable.AuthorInformation.Name;
            lblURL.Text = _currentSignatureExecutable.AuthorInformation.URL;
            lblOriginalMD5.Text = _currentSignatureExecutable.FileInformation.MD5Hash;
            tbDesciption.Text = _currentSignatureExecutable.AuthorInformation.Definition;
            lblURL.Links.Add(0, lblURL.Text.Length, lblURL.Text);

            lblVersion.Text = _ofHelper.ReadVersion_Original(GetByteStream, _currentSignatureExecutable.VersionOriginal).ToString();
            lblLoginPort.Text = "";
            lblGameserverPort.Text = "";
            foreach (var v in _currentSignatureExecutable.LoginserverPortOffsetList)
                lblLoginPort.Text += _ofHelper.ReadPort(GetByteStream, v) + ",";
            foreach (var v in _currentSignatureExecutable.GameserverPortOffsetList)
                lblGameserverPort.Text += _ofHelper.ReadPort(GetByteStream, v) + ",";

        }

        #endregion

        #region Menu click events

        private void tsSave_Click(object sender, EventArgs e)
        {
            DialogResult dr =
                MessageBox.Show(
                    "The save operation will overwrite the existing executable file.\nDo you want to backup old one?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (File.Exists(GetCurrentFile))
                {
                    File.Copy(GetCurrentFile, GetCurrentFile + ".backup", true);
                }
            }

            SaveToFile(GetCurrentFile);
        }

        private void tsSaveAs_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(SaveFile.FileName);
            }
        }
        private void tsExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void tsLoad_Click(object sender, EventArgs e)
        {
            PromptLoadFile();
        }
        private void tsCloseFile_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        #endregion



        private void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        static void ExitApplication()
        {
            Application.Exit();
        }

        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fi = new frmFindOffsets(this))
            {
                fi.ShowDialog();
            }
        }

      
    }
}
