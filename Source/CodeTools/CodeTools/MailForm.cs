using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeTools
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void btFindFiles_Click(object sender, EventArgs e)
        {
            FindFiles frmFindFiles = new FindFiles();
            frmFindFiles.Show();
        }
    }
}
