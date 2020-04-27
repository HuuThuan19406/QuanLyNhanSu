﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public struct ThangNam
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
    }

    class ChamCong
    {        
        public ThangNam ThoiGianChamCong { get; set; }        
        public double LuongCoBan { get; set; }
        public double SoGioTangCa { get; set; }
        public double SoNgayVeSom { get; set; }
        public double SoNgayDiMuon { get; set; }
        public double TroCapHangThang { get; set; }

        public ChamCong()
        {

        }

        public ChamCong(ThangNam thoiGianChamCong, double luongCoBan, double soGioTangCa, double soNgayVeSom, double soNgayDiMuon, double troCapHangThang)
        {
            ThoiGianChamCong = thoiGianChamCong;
            LuongCoBan = luongCoBan;
            SoGioTangCa = soGioTangCa;
            SoNgayVeSom = soNgayVeSom;
            SoNgayDiMuon = soNgayDiMuon;
            TroCapHangThang = troCapHangThang;
        }

    }
}