using QuanLyNhanSu.MODULE.XyLuDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    [Serializable]
    public class TaiKhoan 
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public Person ThongTin { get; set; }
    }
}
