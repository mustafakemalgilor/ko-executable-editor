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
using System.Windows.Forms;

namespace KOExecutableEditor
{
    public partial class frmAuthor : Form
    {
        private AuthorInformation _ai;
        public frmAuthor()
        {
            InitializeComponent();
        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {

        }

        public AuthorInformation GetAuthorInformation()
        {
            ShowDialog();
            return _ai;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            _ai = new AuthorInformation {Name = tbAuthor.Text, Definition = tbDescription.Text, URL = tbURL.Text};
            Close();
        }
    }
}
