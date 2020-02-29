using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace BaiTapNhom
{
    class HienThi
    {
        /// <summary>
        /// Hiển thị thông tin từ Hashtable lên ListView
        /// <para>Nếu Listview có chứa dữ liệu trước đó sẽ bị xóa sạch</para>
        /// </summary>
        /// <param name="listView">Tên Listview cần đưa thông tin vào</param>
        /// <param name="source">Nguồn chứa thông tin</param>
        
        public static void ThongTinList(ListView listView, Hashtable source)
        {
            listView.ItemsSource = null;
            //Xóa List trước khi tải vào
            if (listView.Items.Count > 0)
                listView.Items.Clear();
            foreach (DictionaryEntry VALUE in source)
            {
                listView.Items.Add(VALUE.Value);
            }
        }

        public static string TenNguoiDung(Hashtable dsUsers)
        {
            try
            {
                NhanSu nhanSu = (NhanSu)dsUsers[DangNhap.idDangNhap];
                return nhanSu.HoTen.ToUpper();
            }
            catch { return DangNhap.idDangNhap; }
        }
        public static string TenNguoiDung(string id, Hashtable dsUsers)
        {
            try
            {
                NhanSu nhanSu = (NhanSu)dsUsers[id.ToUpper()];
                return nhanSu.HoTen.ToUpper();
            }
            catch { return DangNhap.idDangNhap.ToUpper(); }
        }

        /// <summary>
        /// Trả về ngày tháng nhập vào dưới định dạng:
        /// <br/> Thứ __, ngày __ tháng __ năm __
        /// <br/> Ví dụ: Thứ Bảy, ngày 1 tháng 1 năm 2000  
        /// </summary>
        /// <param name="ngayThang">Ngày tháng năm cần hiển thị</param>
        /// <returns>Chuỗi hiển thị ngày tháng</returns>
        public static string NgayThang(DateTime ngayThang)
        {
            string value = "";
            switch (ngayThang.DayOfWeek.ToString())
            {
                case "Monday":
                    value = "Thứ Hai, ";
                    break;
                case "Tuesday":
                    value = "Thứ Ba, ";
                    break;
                case "Wednesday":
                    value = "Thứ Tư, ";
                    break;
                case "Thursday":
                    value = "Thứ Năm, ";
                    break;
                case "Friday":
                    value = "Thứ Sáu, ";
                    break;
                case "Saturday":
                    value = "Thứ Bảy, ";
                    break;
                case "Sunday":
                    value = "Chủ Nhật, ";
                    break;
            }
            value += "ngày " + ngayThang.Day + " tháng " + ngayThang.Month + " năm " + ngayThang.Year;
            return value;
        }
        /// <summary>
        /// Trả về ngày tháng hôm nay dưới định dạng:
        /// <br/> Thứ __, ngày __ tháng __ năm __
        /// <br/> Ví dụ: Thứ Bảy, ngày 1 tháng 1 năm 2000  
        /// </summary>
        /// <param name="ngayThang">Ngày tháng năm cần hiển thị</param>
        /// <returns>Chuỗi hiển thị ngày tháng</returns>
        public static string NgayThang()
        {
            string value = "";
            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Monday":
                    value = "Thứ Hai, ";
                    break;
                case "Tuesday":
                    value = "Thứ Ba, ";
                    break;
                case "Wednesday":
                    value = "Thứ Tư, ";
                    break;
                case "Thursday":
                    value = "Thứ Năm, ";
                    break;
                case "Friday":
                    value = "Thứ Sáu, ";
                    break;
                case "Saturday":
                    value = "Thứ Bảy, ";
                    break;
                case "Sunday":
                    value = "Chủ Nhật, ";
                    break;
            }
            value += "ngày " + DateTime.Today.Day + " tháng " + DateTime.Today.Month + " năm " + DateTime.Today.Year;
            return value;
        }
    }
}
