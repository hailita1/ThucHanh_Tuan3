namespace Form_Bai1_Tuan3_NgheNhac
{
    partial class fPhatNhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhatNhac));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTapTin = new System.Windows.Forms.ListBox();
            this.axWMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.cboODia = new System.Windows.Forms.ComboBox();
            this.cboThuMuc = new System.Windows.Forms.ComboBox();
            this.rtbLoiBaiHat = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTapTin);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tập tin";
            // 
            // lstTapTin
            // 
            this.lstTapTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTapTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTapTin.FormattingEnabled = true;
            this.lstTapTin.ItemHeight = 16;
            this.lstTapTin.Location = new System.Drawing.Point(3, 19);
            this.lstTapTin.Name = "lstTapTin";
            this.lstTapTin.Size = new System.Drawing.Size(250, 131);
            this.lstTapTin.TabIndex = 0;
            this.lstTapTin.DoubleClick += new System.EventHandler(this.LstTapTin_DoubleClick);
            // 
            // axWMP1
            // 
            this.axWMP1.Enabled = true;
            this.axWMP1.Location = new System.Drawing.Point(12, 247);
            this.axWMP1.Name = "axWMP1";
            this.axWMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP1.OcxState")));
            this.axWMP1.Size = new System.Drawing.Size(256, 228);
            this.axWMP1.TabIndex = 4;
            // 
            // cboODia
            // 
            this.cboODia.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboODia.FormattingEnabled = true;
            this.cboODia.Location = new System.Drawing.Point(93, 12);
            this.cboODia.Name = "cboODia";
            this.cboODia.Size = new System.Drawing.Size(172, 24);
            this.cboODia.TabIndex = 5;
            this.cboODia.SelectedIndexChanged += new System.EventHandler(this.CboODia_SelectedIndexChanged);
            // 
            // cboThuMuc
            // 
            this.cboThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThuMuc.FormattingEnabled = true;
            this.cboThuMuc.Location = new System.Drawing.Point(92, 55);
            this.cboThuMuc.Name = "cboThuMuc";
            this.cboThuMuc.Size = new System.Drawing.Size(173, 24);
            this.cboThuMuc.TabIndex = 6;
            this.cboThuMuc.SelectedIndexChanged += new System.EventHandler(this.CboThuMuc_SelectedIndexChanged);
            // 
            // rtbLoiBaiHat
            // 
            this.rtbLoiBaiHat.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbLoiBaiHat.Location = new System.Drawing.Point(274, 0);
            this.rtbLoiBaiHat.Name = "rtbLoiBaiHat";
            this.rtbLoiBaiHat.Size = new System.Drawing.Size(262, 479);
            this.rtbLoiBaiHat.TabIndex = 7;
            this.rtbLoiBaiHat.Text = "";
            // 
            // fPhatNhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 479);
            this.Controls.Add(this.rtbLoiBaiHat);
            this.Controls.Add(this.cboThuMuc);
            this.Controls.Add(this.cboODia);
            this.Controls.Add(this.axWMP1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fPhatNhac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phát nhạc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWMP1;
        private System.Windows.Forms.ListBox lstTapTin;
        private System.Windows.Forms.ComboBox cboODia;
        private System.Windows.Forms.ComboBox cboThuMuc;
        private System.Windows.Forms.RichTextBox rtbLoiBaiHat;
    }
}

