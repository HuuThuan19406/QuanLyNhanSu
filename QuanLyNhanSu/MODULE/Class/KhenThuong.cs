﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class KhenThuong
    {
        public string MaNhanSu { get; set; }
        public DateTime NgayXet { get; set; }
        public string LyDoXet { get; set; }
        public string HinhThuc { get; set; }
        public string SoVaoSo { get; set; }       

        public KhenThuong()
        {

        }

        public KhenThuong(string maNhanSu, DateTime ngayXet, string lyDoXet, string hinhThuc, string soVaoSo)
        {
            MaNhanSu = maNhanSu;
            NgayXet = ngayXet;
            LyDoXet = lyDoXet;
            HinhThuc = hinhThuc;
            SoVaoSo = soVaoSo;
        }

    }

}