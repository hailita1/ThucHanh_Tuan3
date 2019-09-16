namespace ThucHanh3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cb_Disk = new System.Windows.Forms.ComboBox();
            this.cb_File = new System.Windows.Forms.ComboBox();
            this.lb_BaiHat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Rtxt_Sub = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Disk
            // 
            this.cb_Disk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Disk.FormattingEnabled = true;
            this.cb_Disk.Location = new System.Drawing.Point(171, 15);
            this.cb_Disk.Name = "cb_Disk";
            this.cb_Disk.Size = new System.Drawing.Size(150, 21);
            this.cb_Disk.TabIndex = 0;
            this.cb_Disk.SelectedIndexChanged += new System.EventHandler(this.cb_Disk_SelectedIndexChanged);
            // 
            // cb_File
            // 
            this.cb_File.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_File.FormattingEnabled = true;
            this.cb_File.Location = new System.Drawing.Point(171, 68);
            this.cb_File.Name = "cb_File";
            this.cb_File.Size = new System.Drawing.Size(150, 21);
            this.cb_File.TabIndex = 1;
            this.cb_File.SelectedIndexChanged += new System.EventHandler(this.cb_File_SelectedIndexChanged);
            // 
            // lb_BaiHat
            // 
            this.lb_BaiHat.FormattingEnabled = true;
            this.lb_BaiHat.Location = new System.Drawing.Point(41, 132);
            this.lb_BaiHat.Name = "lb_BaiHat";
            this.lb_BaiHat.Size = new System.Drawing.Size(437, 173);
            this.lb_BaiHat.TabIndex = 2;
            this.lb_BaiHat.SelectedIndexChanged += new System.EventHandler(this.lb_BaiHat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn thư mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tập tin";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(41, 311);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(437, 228);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Rtxt_Sub
            // 
            this.Rtxt_Sub.Location = new System.Drawing.Point(484, 12);
            this.Rtxt_Sub.Name = "Rtxt_Sub";
            this.Rtxt_Sub.ReadOnly = true;
            this.Rtxt_Sub.Size = new System.Drawing.Size(408, 527);
            this.Rtxt_Sub.TabIndex = 8;
            this.Rtxt_Sub.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 558);
            this.Controls.Add(this.Rtxt_Sub);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_BaiHat);
            this.Controls.Add(this.cb_File);
            this.Controls.Add(this.cb_Disk);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình nghe nhạc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Disk;
        private System.Windows.Forms.ComboBox cb_File;
        private System.Windows.Forms.ListBox lb_BaiHat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.RichTextBox Rtxt_Sub;
    }
}

