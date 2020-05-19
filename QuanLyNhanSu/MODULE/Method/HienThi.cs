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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Reflection;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Drawing;
using QuanLyNhanSu.MODULE.XyLuDatabase;
using ChatAI_Simple;
using ListView = System.Windows.Controls.ListView;

namespace QuanLyNhanSu
{
    class HienThi
    {
        #region Thông tin phần mềm
        public static string version
        {
            get
            {
                string result = ApplicationDeployment.IsNetworkDeployed
               ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
               : Assembly.GetExecutingAssembly().GetName().Version.ToString();
                return result.Remove(result.Length - 2);
            }
        }
        public static string updateDay { get; } = "19/5/2020";
        public static string author { get; } = "AmonCoding Team - K19406";
        public static string hotline { get; } = "090.999.9999";
        public static string email { get; } = "amoncodingteam@gmail.com";
        public static string diaChiTruSo { get; } = "Quận Thủ Đức, Thành phố Hồ Chí Minh";
        /// <summary>
        /// 0: Miễn phí, 1: Dùng thử, 2: Trả phí, 3: Đầy đủ
        /// </summary>
        public static string[] level { get; } = { "Miễn phí", "Dùng thử", "Trả phí", "Đầy đủ" };
        #endregion

        /// <summary>
        /// Hiển thị thông tin từ Hashtable lên ListView
        /// <para>Nếu Listview có chứa dữ liệu trước đó sẽ bị xóa sạch</para>
        /// </summary>
        /// <param name="listControl">Tên Listview cần đưa thông tin vào</param>
        /// <param name="source">Nguồn chứa thông tin</param>        
        public static void ThongTin<T>(Selector listControl, Hashtable source, bool sort)
        {
            if (source == null)
                return;
            listControl.ItemsSource = null;
            //Xóa List trước khi tải vào
            if (listControl.Items.Count > 0)
                listControl.Items.Clear();
            List<T> list = new List<T>();
            foreach (DictionaryEntry VALUE in source)
            {
                list.Add((T)VALUE.Value);
            }
            if (sort == true)
                list.Sort();
            foreach(T t in list)
            {
                listControl.Items.Add(t);
            }
        }

        public static void ThongTin<T>(Selector listControl, ICollection source, bool sort)
        {
            //if (sort)
            //    (listControl as List<T>).Sort();
            listControl.Items.Clear();
            listControl.ItemsSource = null;            
            listControl.ItemsSource = source;           
        }

        public static void ThongTin<T>(Selector listControl, List<T> source, bool sort)
        {
            if (source == null)
                return;
            listControl.ItemsSource = null;
            //Xóa List trước khi tải vào
            if (listControl.Items.Count > 0)
                listControl.Items.Clear();
            if (sort == true)
                source.Sort();
            foreach(T t in source)
            {
                listControl.Items.Add(t);
            }
        }

        public static void GroupingListview(ListView listView, string nameGroup)
        {
            List<object> tmpList = new List<object>();
            if (listView.ItemsSource == null)
            {                
                foreach (var item in listView.Items)
                    tmpList.Add(item);
                listView.Items.Clear();
                listView.ItemsSource = tmpList;
            }            
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listView.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription(nameGroup);
            view.GroupDescriptions.Add(groupDescription);           
        }

        public static void GroupingListview(ListView listView, List<object> listData, string nameGroup)
        {
            listView.ItemsSource = null;
            listView.Items.Clear();
            listView.ItemsSource = listData;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listView.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription(nameGroup);
            view.GroupDescriptions.Add(groupDescription);
        }

        public static string TenNguoiDung(Hashtable dsUsers)
        {
            try
            {
                NhanSu nhanSu = (NhanSu)dsUsers[MainDatabase.idDangNhap.ToUpper()];
                return nhanSu.Ten;
            }
            catch { return MainDatabase.idDangNhap; }
        }

        public static string ThongTinNguoiDung(string id, Hashtable dsUsers)
        {
            id = id.ToUpper();
            if (dsUsers.ContainsKey(id))
            {
                NhanSu nhanSu = dsUsers[id] as NhanSu;
                return String.Join(" | ",
                        nhanSu.HoTen.ToUpper(), nhanSu.MaNhanVien, nhanSu.ChucVu, nhanSu.BoPhan);
            }
            else
                return id.ToLower();
        }

        public static string TenNguoiDung(string id, Hashtable dsUsers)
        {
            id = id.ToUpper();
            try
            {
                NhanSu nhanSu = (NhanSu)dsUsers[id];
                return nhanSu.HoTen.ToUpper();
            }
            catch { return MainDatabase.idDangNhap.ToUpper(); }
        }

        public static void ShowError(Exception ex)
        {
            new Message("ERROR", ex.Message, false);
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
                    value = "Thứ Hai ";
                    break;
                case "Tuesday":
                    value = "Thứ Ba ";
                    break;
                case "Wednesday":
                    value = "Thứ Tư ";
                    break;
                case "Thursday":
                    value = "Thứ Năm ";
                    break;
                case "Friday":
                    value = "Thứ Sáu ";
                    break;
                case "Saturday":
                    value = "Thứ Bảy ";
                    break;
                case "Sunday":
                    value = "Chủ Nhật ";
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
        public static string GioPhutGiay()
        {
            if (DateTime.Now.ToString("tt")=="AM")
                return DateTime.Now.ToString("hh") + " giờ " + DateTime.Now.ToString("mm") + " phút " + DateTime.Now.ToString("ss") + " giây";
            else
                return (int.Parse(DateTime.Now.ToString("hh")) + 12).ToString() + " giờ " + DateTime.Now.ToString("mm") + " phút " + DateTime.Now.ToString("ss") + " giây";
        }
        public static string NowTime()
        {
            return DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }
        public static string FooterInfo()
        {
            return HienThi.NgayThang()
                   + "\nPhần mềm QUẢN LÝ NHÂN SỰ được tạo và phát triển bởi " + author
                   + "\nLiên hệ hỗ trợ: " + hotline;
        }
        public static string DuongDanHienTai()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }

        public static void NotifySignin(Hashtable dsUser)
        {
            string loiChao = "Xin chào ";
            NotifyIcon notify = new NotifyIcon();
            notify.Icon = new Icon(@".\MODULE\IconDefault.ico");
            notify.BalloonTipTitle = "ĐĂNG NHẬP THÀNH CÔNG";
            if (!MainDatabase.dsNhanSu.ContainsKey(MainDatabase.idDangNhap.ToUpper()))
                loiChao += "tài khoản ";
            loiChao += TenNguoiDung(dsUser) + "\n" + ChaoXaGiao.LoiChuc(HoanCanh.ThoiGian);
            notify.BalloonTipText = loiChao;
            notify.Visible = true;
            notify.ShowBalloonTip(1500);
        }
    }
}
