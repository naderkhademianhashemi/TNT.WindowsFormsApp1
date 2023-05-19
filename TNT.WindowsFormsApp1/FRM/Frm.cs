using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TNT.WindowsFormsApp1.FRM
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void btnParcels_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            int from = Convert.ToInt32(txtFrom.Text);
            int to = Convert.ToInt32(txtTo.Text);
            if (to < from)
            {
                MessageBox.Show("error");
                return;
            }
            p.StartInfo.Arguments =
                        RSRC.Setting.strUrl
                        + from + " --new-window"; ;
            p.StartInfo.FileName = RSRC.Setting.chromApp;
            p.Start();
            for (int i = from + 1; i <= to; i++)
            {
                p.StartInfo.Arguments = RSRC.Setting.strUrl + i;
                p.StartInfo.FileName = RSRC.Setting.chromApp;
                p.Start();
            }
        }

        private void btnMyParcel_Click(object sender, EventArgs e)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.Arguments = RSRC.Setting.strUrl
                        + Convert.ToInt32(txtMyParcel.Text) + " --new-window";
            p.StartInfo.FileName = RSRC.Setting.chromApp;
            p.Start();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtPathBrows.Text = GetPath();
            txtFolderName.Text = txtPathBrows.Text;
        }

        private void btnSave2File_Click(object sender, EventArgs e)
        {
            File.AppendAllText(txtPathBrows.Text, "\n" + txtPathSave.Text);
            MessageBox.Show(RSRC.Farsi.SuccessCreated);
        }
        public string GetPath()
        {
            var path = string.Empty;
            var fdlg = new OpenFileDialog();
            fdlg.Title = RSRC.Farsi.SelectFile;
            fdlg.InitialDirectory = RSRC.Setting.DefaultPath;
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
                path = fdlg.FileName;
            return path;
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            txtFrom.Text = Properties.Settings.Default.From;
            txtTo.Text = Properties.Settings.Default.To;
            txtPathBrows.Text = RSRC.Setting.DefaultPath;
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.From = txtFrom.Text;
            Properties.Settings.Default.To = txtTo.Text;
            Properties.Settings.Default.Save();
        }

        private void btnShowContent_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var items = File.ReadAllLines(txtPathBrows.Text);
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = listBox1.SelectedItem.ToString();
            textBox1.Text = select;
            if (select.Trim().Length == 9)
                OpenParcelInBrowser(textBox1.Text);
        }

        private void OpenParcelInBrowser(string text)
        {
            var p = new System.Diagnostics.Process();
            p.StartInfo.Arguments = RSRC.Setting.strUrl
                        + Convert.ToInt32(text) + " --new-window";
            p.StartInfo.FileName = RSRC.Setting.chromApp;
            p.Start();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            var folderPath = Directory.GetParent(txtFolderName.Text);
            var fileName = Guid.NewGuid() + ".txt";
            var filePath = folderPath + "\\" + fileName;
            File.Create(filePath);
            MessageBox.Show(RSRC.Farsi.SuccessCreated);
        }
    }
}
