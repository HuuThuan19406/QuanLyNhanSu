﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class KhenThuong : IComparable
    {
        public NhanSu NhanSu { get; set; } = new NhanSu();
        public DateTime NgayXet { get; set; }
        public string LyDoXet { get; set; }
        public string HinhThuc { get; set; }
        public string SoVaoSo { get; set; }
        public bool CoQuyetDinh { get; set; }

        public KhenThuong()
        {

        }

        public KhenThuong(NhanSu nhanSu, DateTime ngayXet, string lyDoXet, string hinhThuc, string soVaoSo)
        {
            NhanSu = nhanSu;
            NgayXet = ngayXet;
            LyDoXet = lyDoXet;
            HinhThuc = hinhThuc;
            SoVaoSo = soVaoSo;
        }

        public override string ToString()
        {
            return String.Join(",",
                    NhanSu.HoTen, NhanSu.MaNhanVien, NgayXet.ToString("dd/MM/yyyy"), SoVaoSo, LyDoXet, HinhThuc, CoQuyetDinh);
        }

        public int CompareTo(object obj)
        {
            return NgayXet.CompareTo(obj);
        }
    }

}