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

namespace ThucHanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo item in drives)
            {
                cb_Disk.Items.Add(item.Name);
            }
        }

        private void cb_Disk_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_File.Items.Clear();
            if (cb_Disk.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn hãy chọn thư mục");
            }
            else if (cb_Disk.SelectedIndex == 0)
            {
                DirectoryInfo Directory = new DirectoryInfo("C:\\");
                DirectoryInfo[] Directories = Directory.GetDirectories("*.*");
                FileInfo[] File = Directory.GetFiles();
                foreach (DirectoryInfo item in Directories)
                {
                    cb_File.Items.Add(item.Name);
                }
            }
            else if (cb_Disk.SelectedIndex == 1)
            {
                DirectoryInfo Directory = new DirectoryInfo("D:\\");
                DirectoryInfo[] Directories = Directory.GetDirectories("*.*");
                FileInfo[] File = Directory.GetFiles();
                foreach (DirectoryInfo item in Directories)
                {
                    cb_File.Items.Add(item.Name);
                }
            }
            else if (cb_Disk.SelectedIndex == 2)
            {
                DirectoryInfo Directory = new DirectoryInfo("E:\\");
                DirectoryInfo[] Directories = Directory.GetDirectories("*.*");
                FileInfo[] File = Directory.GetFiles();
                foreach (DirectoryInfo item in Directories)
                {
                    cb_File.Items.Add(item.Name);
                }
            }
            else if (cb_Disk.SelectedIndex == 3)
            {
                DirectoryInfo Directory = new DirectoryInfo("F:\\");
                DirectoryInfo[] Directories = Directory.GetDirectories("*.*");
                FileInfo[] File = Directory.GetFiles();
                foreach (DirectoryInfo item in Directories)
                {
                    cb_File.Items.Add(item.Name);
                }
            }
        }

        private void cb_File_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_BaiHat.Items.Clear();
            Rtxt_Sub.Text = "";
            string[] files = Directory.GetFiles(cb_Disk.Text + cb_File.Text);
            foreach (string item in files)
            {
                lb_BaiHat.Items.Add(item);
            }
        }

        private void lb_BaiHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_BaiHat.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn 1 bài hát");
            }
            else
            {
                string check = ".rtf";
                if (lb_BaiHat.SelectedItem.ToString().Contains(check) == true)
                {
                    MessageBox.Show("Hãy chọn định dạng MP3");
                }
                else
                {
                    Rtxt_Sub.Text = "";
                    string filePath = lb_BaiHat.SelectedItem.ToString() + "_Lyric.rtf";
                    if (File.Exists(filePath) == true)
                    {
                        FileStream fs = new FileStream(filePath, FileMode.Open);
                        StreamReader rd = new StreamReader(fs, Encoding.UTF8);
                        string loibaihat = rd.ReadToEnd();
                        Rtxt_Sub.Text = loibaihat;
                    }
                    else if (File.Exists(filePath) == false)
                    {
                        Rtxt_Sub.Text = "Không có lời bài hát";
                    }
                    axWindowsMediaPlayer1.URL = lb_BaiHat.SelectedItem.ToString();
                }
            }
        }
    }
}
