using CodeTools.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeTools
{
    public partial class FindFiles : Form
    {
        public FindFiles()
        {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            string ext = "*";
            if (string.IsNullOrEmpty(tbPath.Text))
            {
                FolderBrowserDialog folder = new FolderBrowserDialog(); folder.Description = "选择路径"; if (folder.ShowDialog() == DialogResult.OK)
                {
                    tbPath.Text = folder.SelectedPath;
                }
            }
            if (!string.IsNullOrEmpty(cbExt.Text))
            {
                ext = cbExt.Text;
            }
            if (!Directory.Exists(tbPath.Text))
            {
                MessageBox.Show("请选择!");
                tbPath.Focus();
                return;
            }
            try
            {
                var list = FileGet.getFile(tbPath.Text, ext);
                if (list != null && list.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in list)
                    {
                        sb.AppendLine(item.FullName);
                    }
                    tbList.Text = sb.ToString();
                }
                else
                {
                    tbList.Text = string.Empty;
                    MessageBox.Show("未找到相关文件!");
                }
            }
            catch(Exception ex)
            {
                tbList.Text = string.Empty;
                MessageBox.Show("错误："+ex.Message);
            }
        }
    }
}
