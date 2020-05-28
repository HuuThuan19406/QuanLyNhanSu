using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    [Serializable]
    public class SetUp
    {
        public string FontChu { get; set; }
        public string HauToSoKhenThuong { get; set; }
        public TaiKhoan DangNhapMacDinh { get; set; } = new TaiKhoan();
        public static bool operator ==(SetUp setUp1,SetUp setUp2)
        {
            return setUp1.FontChu == setUp2.FontChu &&
                   setUp1.DangNhapMacDinh.Id == setUp2.DangNhapMacDinh.Id;
        }
        public static bool operator !=(SetUp setUp1, SetUp setUp2)
        {
            return setUp1.FontChu != setUp2.FontChu ||
                   setUp1.DangNhapMacDinh.Id != setUp2.DangNhapMacDinh.Id;
        }
    }
}
