using QuanLyNhanSu.MODULE.XyLuDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    [Serializable]
    public class KhenThuong : IComparable
    {
        public string MaNhanVien { get; set; }
        public string BoPhanCongTac { get; set; }
        public DateTime NgayXet { get; set; }
        public string LyDoXet { get; set; }
        public string HinhThuc { get; set; }
        public double GiaTri { get; set; }
        public string SoVaoSo { get; set; }
        public bool CoQuyetDinh { get; set; }        

        public KhenThuong()
        {

        }

        public KhenThuong(string soVaoSo, DateTime ngayXet, string maNhanVien, string boPhanCongTac, string lyDoXet, string hinhThuc, double giaTri, bool coQuyetDinh)
        {
            MaNhanVien = maNhanVien;
            BoPhanCongTac = boPhanCongTac;
            NgayXet = ngayXet;
            LyDoXet = lyDoXet;
            HinhThuc = hinhThuc;
            GiaTri = giaTri;
            SoVaoSo = soVaoSo;
            CoQuyetDinh = coQuyetDinh;
        }

        public static int getSoTrongMa(string maKhenThuong)
        {
            return int.Parse(maKhenThuong.Split('/')[0]);
        }

        public override string ToString()
        {
            NhanSu nhanSu = MainDatabase.dsNhanSu[MaNhanVien] as NhanSu;
            return String.Join(",",
                    nhanSu.HoTen, nhanSu.MaNhanVien, NgayXet.ToString("dd/MM/yyyy"), SoVaoSo, LyDoXet, HinhThuc, GiaTri.ToString("#.###"), CoQuyetDinh);
        }

        public int CompareTo(object obj)
        {
            return NgayXet.CompareTo((obj as KhenThuong).NgayXet);
        }
    }

}