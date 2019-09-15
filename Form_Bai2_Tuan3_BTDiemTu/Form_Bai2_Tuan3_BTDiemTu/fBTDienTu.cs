using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Bai2_Tuan3_BTDiemTu
{
    public partial class fBTDienTu : Form
    {
        List<BaiTapDienTu> lst = new List<BaiTapDienTu>();
        public fBTDienTu()
        {
            InitializeComponent();
            lst = StaticData.baitap;
            txtCauHoi.Text = lst[0].Debai;
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            int diem = 0;
            string str1 = txtCau1.Text;
            string str2 = txtCau2.Text;
            string str3 = txtCau3.Text;
            string str4 = txtCau4.Text;
            string str5 = txtCau5.Text;
            string str6 = txtCau6.Text;
            string str7 = txtCau7.Text;
            string str8 = txtCau8.Text;
            string str9 = txtCau9.Text;
            string str10 = txtCau10.Text;
            if (str1.Equals(lst[0].Dapantungcau[0]))
            {
                txtCau1.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau1.BackColor = Color.Red;
            }
            if (str2.Equals(lst[0].Dapantungcau[1]))
            {
                txtCau2.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau2.BackColor = Color.Red;
            }
            if (str3.Equals(lst[0].Dapantungcau[2]))
            {
                txtCau3.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau3.BackColor = Color.Red;
            }
            if (str4.Equals(lst[0].Dapantungcau[3]))
            {
                txtCau4.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau4.BackColor = Color.Red;
            }
            if (str5.Equals(lst[0].Dapantungcau[4]))
            {
                txtCau5.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau5.BackColor = Color.Red;
            }
            if (str6.Equals(lst[0].Dapantungcau[5]))
            {
                txtCau6.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau6.BackColor = Color.Red;
            }
            if (str7.Equals(lst[0].Dapantungcau[6]))
            {
                txtCau7.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau7.BackColor = Color.Red;
            }
            if (str8.Equals(lst[0].Dapantungcau[7]))
            {
                txtCau8.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau8.BackColor = Color.Red;
            }
            if (str9.Equals(lst[0].Dapantungcau[8]))
            {
                txtCau9.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau9.BackColor = Color.Red;
            }
            if (str10.Equals(lst[0].Dapantungcau[9]))
            {
                txtCau1.BackColor = Color.Green;
                diem++;
            }
            else
            {
                txtCau10.BackColor = Color.Red;
            }
            MessageBox.Show("Điểm của bạn là: " + diem, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            txtCau1.Text = "";
            txtCau1.BackColor = Color.White;
            txtCau2.Text = "";
            txtCau2.BackColor = Color.White;
            txtCau3.Text = "";
            txtCau3.BackColor = Color.White;
            txtCau4.Text = "";
            txtCau4.BackColor = Color.White;
            txtCau5.Text = "";
            txtCau5.BackColor = Color.White;
            txtCau6.Text = "";
            txtCau6.BackColor = Color.White;
            txtCau7.Text = "";
            txtCau7.BackColor = Color.White;
            txtCau8.Text = "";
            txtCau8.BackColor = Color.White;
            txtCau9.Text = "";
            txtCau9.BackColor = Color.White;
            txtCau10.Text = "";
            txtCau10.BackColor = Color.White;
        }

        private void BtnDapAn_Click(object sender, EventArgs e)
        {
            txtCauHoi.Text = lst[0].Dapan;
            /*txtCau1.Text = lst[0].Dapantungcau[0];
            txtCau2.Text = lst[0].Dapantungcau[1];
            txtCau3.Text = lst[0].Dapantungcau[2];
            txtCau4.Text = lst[0].Dapantungcau[3];
            txtCau5.Text = lst[0].Dapantungcau[4];
            txtCau6.Text = lst[0].Dapantungcau[5];
            txtCau7.Text = lst[0].Dapantungcau[6];
            txtCau8.Text = lst[0].Dapantungcau[7];
            txtCau9.Text = lst[0].Dapantungcau[8];
            txtCau10.Text = lst[0].Dapantungcau[9];*/
            btnOk.Enabled = false;
            btnLamLai.Enabled = false;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
    }
}
