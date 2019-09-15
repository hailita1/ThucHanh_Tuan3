﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Bai2_Tuan3_BTDiemTu
{
    class BaiTapDienTu
    {
        private string debai;
        private string dapan;
        private List<string> dapantungcau;
        public BaiTapDienTu(string debai, string dapan,List<string> dapantungcau)
        {
            this.debai = debai;
            this.dapan = dapan;
            this.dapantungcau = dapantungcau;
        }

        public string Debai { get => debai; set => debai = value; }
        public string Dapan { get => dapan; set => dapan = value; }
        public List<string> Dapantungcau { get => dapantungcau; set => dapantungcau = value; }
    }
}
