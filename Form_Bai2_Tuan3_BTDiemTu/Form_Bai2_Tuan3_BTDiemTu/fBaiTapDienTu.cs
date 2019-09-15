using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_Bai2_Tuan3_BTDiemTu
{
    public partial class fBaiTapDienTu : DevExpress.XtraEditors.XtraForm
    {
        public fBaiTapDienTu()
        {
            InitializeComponent();
        }

        private void BàiTậpĐiệnTử1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<BaiTapDienTu> bt = new List<BaiTapDienTu>();
            string Debai = "It can take a long time to become successful in your chosen field, however talented you are." +
                " One thing you have to be (1) _______ of is that you will face criticism along the way." +
                " The world is (2)_________ of people who would rather say something negative than positive." +
                " If you’ve made up your (3)_______ to achieve a certain goal, such as writing a novel," +
                " (4)_________ the negative criticism of others prevent you from reaching your target," +
                " and let the constructive criticism have a positive effect on your work." +
                " If someone says you’re totally in the (5)______ of talent, ignore them. That’s negative criticism." +
                " If (6), __________, someone advises you to revise your work and gives you a good reason" +
                " for doing so, you should consider their suggestions carefully." +
                " There are many film stars (7)__________ were once out of work . " +
                "There are many famous novelists who made a complete mess of their first novel – or who didn’t, " +
                "but had to keep on approaching hundreds of publishers before they could get it (8) ________. " +
                "Being successful does depend on luck, to a (9)________ extent." +
                " But things are more likely to (10) ________ well if you persevere and stay positive.";
            string Dapan = "It can take a long time to become successful in your chosen field, however talented you are." +
                " One thing you have to be (1)aware of is that you will face criticism along the way." +
                " The world is (2)full of people who would rather say something negative than positive." +
                " If you’ve made up your (3)mind to achieve a certain goal, such as writing a novel," +
                " (4)don’t let the negative criticism of others prevent you from reaching your target," +
                " and let the constructive criticism have a positive effect on your work." +
                " If someone says you’re totally in the (5)lack of talent, ignore them. That’s negative criticism." +
                " If (6), however, someone advises you to revise your work and gives you a good reason" +
                " for doing so, you should consider their suggestions carefully." +
                " There are many film stars (7)who were once out of work . " +
                "There are many famous novelists who made a complete mess of their first novel – or who didn’t, " +
                "but had to keep on approaching hundreds of publishers before they could get it (8) published. " +
                "Being successful does depend on luck, to a (9)certain extent." +
                " But things are more likely to (10)turn out well if you persevere and stay positive.";
            List<string> lst = new List<string>();
            lst.Add("aware");
            lst.Add("full");
            lst.Add("mind");
            lst.Add("don’t let");
            lst.Add("lack");
            lst.Add("however");
            lst.Add("who");
            lst.Add("published");
            lst.Add("certain");
            lst.Add("turn out");

            bt.Add(new BaiTapDienTu(Debai,Dapan,lst));
            StaticData.baitap = bt;
            fBTDienTu btdt = new fBTDienTu();
            this.Hide();
            btdt.ShowDialog();
            this.Show();
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Bạn có muốn thoát không ?","Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void BàiTậpĐiệnTử1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<BaiTapDienTu> bt = new List<BaiTapDienTu>();
            string Debai = "It can take a long time to become successful in your chosen field, however talented you are." +
                " One thing you have to be (1) _______ of is that you will face criticism along the way." +
                " The world is (2)_________ of people who would rather say something negative than positive.";
            string Dapan = "It can take a long time to become successful in your chosen field, however talented you are." +
                " One thing you have to be (1)aware of is that you will face criticism along the way." +
                " The world is (2)full of people who would rather say something negative than positive.";
            List<string> lst = new List<string>();
            lst.Add("aware");
            lst.Add("full");

            bt.Add(new BaiTapDienTu(Debai, Dapan, lst));
            StaticData.baitap = bt;
            fBTDienTu btdt = new fBTDienTu();
            this.Hide();
            btdt.ShowDialog();
            this.Show();
        }

        private void BàiTậpĐiệnTử1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa có bài tập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BàiTậpĐiệnTử1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa có bài tập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
