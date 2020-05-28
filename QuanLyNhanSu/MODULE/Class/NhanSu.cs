using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.MODULE.XyLuDatabase;

namespace QuanLyNhanSu
{
    [Serializable]
    public class NhanSu : Person, IComparable
    {
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
        public string BoPhan { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVao { get; set; }
        public string Avatar { get; set; }

        public NhanSu()
        {
        }

        public NhanSu(string hoTen, string cMND, string maNhanVien, string boPhan, string chucVu, DateTime ngayVao, string avatar)
        {
            HoTen = hoTen;
            CMND = cMND;
            MaNhanVien = maNhanVien;
            BoPhan = boPhan;
            ChucVu = chucVu;
            NgayVao = ngayVao;
            Avatar = avatar;
        }       
        
        public int CompareTo(object obj)
        {
            NhanSu nhanSu = obj as NhanSu;
            return string.Compare(this.HoTen, nhanSu.HoTen) * (-1);
        }
        public void GetTen()
        {
            Ten = hoTen.Split(' ')[hoTen.Split(' ').Length - 1];
        }
        public static string createMaNhanVien(int length)
        {
            Random rd = new Random();
            string maNhanVien = "";
            for (int i = 1; i <= length; i++)
            {
                if (rd.Next(2) == 0)
                    maNhanVien += Convert.ToChar(rd.Next(65, 91));
                else
                    maNhanVien += Convert.ToChar(rd.Next(48, 58));
            }
            return maNhanVien;
        }
        public override string ToString()
        {
            return String.Join(",", 
                HoTen, CMND, MaNhanVien, GioiTinh, NgaySinh.ToString("dd/MM/yyyy"), QueQuan, SoDienThoai, BoPhan, ChucVu, NgayVao.ToString("dd/MM/yyyy"));            
        }
    }
}
