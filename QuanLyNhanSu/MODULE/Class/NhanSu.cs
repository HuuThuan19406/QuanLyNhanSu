using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class NhanSu : IComparable
    {
        public NhanSu()
        {

        }
        public NhanSu(string HoTen, string CMND, string MaNhanVien, string GioiTinh, string NgaySinh, string QueQuan, string SoDienThoai, string BoPhan, string ChucVu, string NgayVao, string Avatar)
        {
            this.HoTen = HoTen;
            this.CMND = CMND;
            this.MaNhanVien = MaNhanVien;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.QueQuan = QueQuan;
            this.SoDienThoai = SoDienThoai;
            this.BoPhan = BoPhan;
            this.ChucVu = ChucVu;
            this.NgayVao = NgayVao;
            this.Avatar = Avatar;
        }
        private string hoTen;
        public string HoTen 
        {
            get
            {
                return hoTen;
            }
            set 
            {
                hoTen = value;
                GetTen();
            }
        }
        public string CMND { get; set; }
        public string MaNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string SoDienThoai { get; set; }
        public string BoPhan { get; set; }
        public string ChucVu { get; set; }
        public string NgayVao { get; set; }
        public string Avatar { get; set; }
        public string Ten { get; set; }
        public int CompareTo(object obj)
        {
            NhanSu nhanSu = obj as NhanSu;
            return string.Compare(this.HoTen, nhanSu.HoTen) * (-1);
        }
        public void GetTen()
        {
            Ten = hoTen.Split(' ')[hoTen.Split(' ').Length - 1];
        }
    }
}
