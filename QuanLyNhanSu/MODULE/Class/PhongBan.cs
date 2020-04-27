using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    [Serializable]
    public class PhongBan : IComparable
    {
        public string TenPhongBan { get; set; }
        public List<string> dsChucVu { get; set; }
        public List<NhanSu> dsNhanSu { get; set; }

        public int CompareTo(Object obj)
        {
            PhongBan phongBanSS = obj as PhongBan;
            return String.Compare(this.TenPhongBan, phongBanSS.TenPhongBan);
        }
    }
}
