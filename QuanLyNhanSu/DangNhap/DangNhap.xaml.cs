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
using System.ComponentModel;
using QuanLyNhanSu.MODULE.XyLuDatabase;
using System.Windows.Threading;

namespace QuanLyNhanSu
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public static Hashtable danhSachNhanSu;  
        public DangNhap()
        {
            InitializeComponent();
            MainDatabase.LoadData_TaiKhoan();
            MainDatabase.LoadData_SetUp();
            DienThongTin();
            AddTimers();
            Icon = ChuyenDoi.BitMapImage(MainWindow.base64_defaultAvatar);
        }

        DispatcherTimer timerOpen_lbMenu = new DispatcherTimer();
        DispatcherTimer timerClose_lbMenu = new DispatcherTimer();
        double locationTop_lbMenu = 0;
        private void AddTimers()
        {            
            timerOpen_lbMenu.Interval = TimeSpan.FromMilliseconds(4);
            timerOpen_lbMenu.Tick += (s, a) =>
            {
                lbMenu.Margin = new Thickness(0, locationTop_lbMenu, 0, 0);
                lbMenu.Opacity = locationTop_lbMenu * 2.5 / 100;
                locationTop_lbMenu++;
                if (locationTop_lbMenu == 40)
                    timerOpen_lbMenu.Stop();
            };

            timerClose_lbMenu.Interval = TimeSpan.FromMilliseconds(4);
            timerClose_lbMenu.Tick += (s, a) =>
            {
                lbMenu.Margin = new Thickness(0, locationTop_lbMenu, 0, 0);
                lbMenu.Opacity = locationTop_lbMenu * 2.5 / 100;
                locationTop_lbMenu--;
                if (locationTop_lbMenu == 0)
                {
                    lbMenu.Visibility = Visibility.Hidden;
                    timerClose_lbMenu.Stop();
                }
            };
        }
    
        private void DienThongTin()
        {
            txtTaiKhoan.Text = MainDatabase.setUp.DangNhapMacDinh.Id;
            pwbMatKhau.Password = MainDatabase.setUp.DangNhapMacDinh.Password;
            txtHienThiMatKhau.Text = pwbMatKhau.Password;
        }

        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            if(txtTaiKhoan.Text=="")
            {
                new Message("NHẮC NHỞ", "Chưa nhập tài khoản", true, Message.Options.Warning);
                txtTaiKhoan.Focus();
                return;
            }
            if (pwbMatKhau.Password=="")
            {
                new Message("NHẮC NHỞ", "Chưa nhập mật khẩu", true, Message.Options.Warning);
                pwbMatKhau.Focus();
                return;
            }            
            if (MainDatabase.dsTaiKhoan.ContainsKey((txtTaiKhoan.Text.ToLower())))
            {
                if (((TaiKhoan)MainDatabase.dsTaiKhoan[txtTaiKhoan.Text.ToLower()]).Password  == pwbMatKhau.Password)
                {
                    if (checkLuuDangNhap.IsChecked == true)
                    {
                        MainDatabase.setUp.DangNhapMacDinh.Id = txtTaiKhoan.Text;
                        MainDatabase.setUp.DangNhapMacDinh.Password = pwbMatKhau.Password;
                    }
                    WaitForLoading frmWait = new WaitForLoading();
                    frmWait.Show();
                    frmWait.timer.Interval = TimeSpan.FromMilliseconds(4);
                    frmWait.timer.Tick += (s, a) =>
                    {                       
                        try
                        {
                            using (FileStream file = File.Open(MainDatabase.connectSetUp, FileMode.Open))
                                file.Close();
                        }
                        catch (IOException)
                        {                            
                            frmWait.txbThongTin.Text = "Đang lưu Thông tin đăng nhập mặc định ....";
                            return;
                        }
                        try
                        {
                            using (FileStream file = File.Open(MainDatabase.connectNhanSu, FileMode.Open))
                                file.Close();
                        }
                        catch (IOException)
                        {  
                            frmWait.txbThongTin.Text = "Đang tải Danh sách nhân sự ....";
                            return;
                        }
                        try
                        {
                            using (FileStream file = File.Open(MainDatabase.connectPhongBan, FileMode.Open))
                                file.Close();
                        }
                        catch (IOException)
                        {
                            frmWait.txbThongTin.Text = "Đang tải tài nguyên Phòng ban ....";
                            return;
                        }
                        try
                        {
                            using (FileStream file = File.Open(MainDatabase.connectKhenThuong, FileMode.Open))
                                file.Close();
                        }
                        catch (IOException)
                        {
                            frmWait.txbThongTin.Text = "Đang tải dữ liệu Khen thưởng ....";
                            return;
                        }
                        try
                        {
                            using (FileStream file = File.Open(MainDatabase.connectHinhThucKhenThuong, FileMode.Open))
                                file.Close();
                        }
                        catch (IOException)
                        {
                            frmWait.txbThongTin.Text = "Đang tải dữ liệu hình thức Khen thưởng ....";
                            return;
                        }
                        if (MainDatabase.dsKhenThuong.Count > 0)
                        {
                            frmWait.txbThongTin.Text = "Đang thiết lập tài nguyên cần thiết ....";
                            return;
                        }
                    };
                    frmWait.timer.Start();
                    var working = new BackgroundWorker();
                    working.DoWork += (s, a) =>
                    {
                        MainDatabase.WriteData_SetUp();
                        MainDatabase.LoadData_NhanSu();
                        MainDatabase.LoadData_PhongBan();
                        MainDatabase.FillDataEmtype();
                        MainDatabase.LoadData_KhenThuong();                       
                        MainDatabase.LoadData_HinhThucKhenThuong();
                    };
                    working.RunWorkerCompleted += (s, a) =>
                    {
                        MainWindow frmMain = new MainWindow();
                        frmWait.timer.Stop();
                        frmWait.Close();
                        frmMain.Show();                               
                    };
                    working.RunWorkerAsync();
                 
                    MainDatabase.idDangNhap = txtTaiKhoan.Text.ToLower();                    
                    Close();
                }
                else
                {
                    new Message("LỖI", "Sai mật khẩu", true, Message.Options.Warning);
                    pwbMatKhau.Clear();  
                    new Message("NHẮC NHỞ", "THÔNG TIN MẶC ĐỊNH" +
                                    "\nTài khoản: tester" +
                                    "\nMật khẩu: 123456", false, Message.Options.Information);
                }
            }
            else
            {
                new Message("LỖI", "Tài khoản không tồn tại", true, Message.Options.Error);
                new Message("NHẮC NHỞ", "THÔNG TIN MẶC ĐỊNH" +
                                    "\nTài khoản: tester" +
                                    "\nMật khẩu: 123456", false, Message.Options.Information);
            }
        }

        private void lblQuenMatKhau_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoiMatKhau frmquenMatKhau = new DoiMatKhau();
            frmquenMatKhau.ShowDialog();
        }  

        private void lblTaiKhoanKhac_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtTaiKhoan.Clear();
            pwbMatKhau.Clear();
            txtTaiKhoan.Focus();
        }

        private void lblDoiMatKhau_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoiMatKhau frmquenMatKhau = new DoiMatKhau();
            frmquenMatKhau.ShowDialog();
        }

        private void btnHienMatKhau_Click(object sender, RoutedEventArgs e)
        {
            txtHienThiMatKhau.Text = pwbMatKhau.Password;
            txtHienThiMatKhau.Focus();
            btnAnMatKhau.Visibility = Visibility.Visible;
            btnHienMatKhau.Visibility = Visibility.Hidden;
        }

        private void btnAnMatKhau_Click(object sender, RoutedEventArgs e)
        {
            pwbMatKhau.Password = txtHienThiMatKhau.Text;
            btnHienMatKhau.Visibility = Visibility.Visible;
            btnAnMatKhau.Visibility = Visibility.Hidden;
        }

        private void btnMenuList_Click(object sender, RoutedEventArgs e)
        {
            if (lbMenu.Visibility == Visibility.Visible)
            {
                locationTop_lbMenu = 40;
                timerClose_lbMenu.Start();
            }
            else
            {
                locationTop_lbMenu = 10;
                lbMenu.Visibility = Visibility.Visible;
                timerOpen_lbMenu.Start();                            
            }
        }

        private void lbMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbMenu.SelectedIndex == -1)
                return;
            switch ((lbMenu.SelectedItem as ListBoxItem).Content.ToString().Trim())
            {
                case "Đổi mật khẩu":
                    lbMenu.SelectedIndex = -1;
                    DoiMatKhau frmquenMatKhau = new DoiMatKhau();
                    frmquenMatKhau.ShowDialog();
                    return;
                case "Quên mật khẩu":
                    lbMenu.SelectedIndex = -1;
                    new Message("Vui lòng liên hệ admin để được cấp lại mật khẩu mới");
                    return;
                case "Thông tin":
                    lbMenu.SelectedIndex = -1;
                    ThongTinPhanMem frmThongTinPhanMem = new ThongTinPhanMem();
                    frmThongTinPhanMem.ShowDialog();
                    return;
                case "Thoát":
                    Close();
                    return;
            }
        }
    }
}
