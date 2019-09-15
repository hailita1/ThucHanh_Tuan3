using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Form_Bai1_Tuan3_NgheNhac
{
    public partial class fPhatNhac : DevExpress.XtraEditors.XtraForm
    {
        public List<string> splitStr(char c)
        {
            List<string> s = new List<string>();
            string taptin = lstTapTin.SelectedItem.ToString();
            string[] str = taptin.Split(c);
            foreach (string lst in str)
            {
                s.Add(lst);
            }
            return s;
        }
        public fPhatNhac()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo dr in drives)
            {
                cboODia.Items.Add(dr.Name);
            }

        }

        private void CboODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboThuMuc.SelectedItem = -1;
            DirectoryInfo directory = new DirectoryInfo(cboODia.Text);
            DirectoryInfo[] directories = directory.GetDirectories("*.*");
            FileInfo[] files = directory.GetFiles();
            foreach(DirectoryInfo dir in directories)
            {
                cboThuMuc.Items.Add(cboODia.Text + dir.Name);
            }
        }

        private void CboThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboODia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ổ đĩa trước !", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cboThuMuc.SelectedIndex = -1;
            }
            else
            {
                lstTapTin.Items.Clear();
                rtbLoiBaiHat.Text = "";
                string[] files = Directory.GetFiles(cboThuMuc.Text);
                foreach(string str in files)
                {
                    lstTapTin.Items.Add(str);
                }
            }
        }
        public void LoadMyFile()
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                // richTextBox1.LoadFile(openFile1.FileName);
                MessageBox.Show(openFile1.FileName);

            }
        }
        private void LstTapTin_DoubleClick(object sender, EventArgs e)
        {
            List<string> s1 = splitStr('.');
            List<string> s = splitStr('\\');
            //MessageBox.Show(s[s.Count - 1]);

            string giaitri;
            if ("txt".Equals(s1[s1.Count-1]))
            {
                FileStream fs = new FileStream(s[s.Count - 1], FileMode.Open);
                StreamReader rd = new StreamReader(fs, Encoding.UTF8);
                giaitri = rd.ReadToEnd();
                rtbLoiBaiHat.Text = giaitri;

            }
            else if ("mp3".Equals(s1[s1.Count - 1]))
            {
                axWMP1.URL = s1[s1.Count - 2] + ".mp3";
            }
            else
            {
                MessageBox.Show("Tệp không hợp lệ, vui lòng chọn lại !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
