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
            Icon = ChuyenDoi.BitMapImage(MainWindow.base64_defaultAvatar);
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
                    frmWait.timer.Interval = TimeSpan.FromMilliseconds(1);
                    frmWait.timer.Tick += (s, a) =>
                    {
                        try
                        {
                            FileStream file = new FileStream(MainDatabase.connectSetUp, FileMode.Open);
                            file.Close();
                        }
                        catch (IOException)
                        {
                            frmWait.txbThongTin.Text = "Đang lưu Thông tin đăng nhập mặc định ....";
                        }
                        try
                        {
                            FileStream file = new FileStream(MainDatabase.connectNhanSu, FileMode.Open);
                            file.Close();
                        }
                        catch (IOException)
                        {
                            frmWait.txbThongTin.Text = "Đang tải Danh sách nhân sự ....";
                        }
                        try
                        {
                            FileStream file = new FileStream(MainDatabase.connectPhongBan, FileMode.Open);
                            file.Close();
                        }
                        catch (IOException)
                        {
                            frmWait.txbThongTin.Text = "Đang tải tài nguyên Phòng ban ....";
                        }
                    };
                    frmWait.timer.Start();
                    var working = new BackgroundWorker();
                    working.DoWork += (s, a) =>
                    {
                        Thread.Sleep(500);
                        MainDatabase.WriteData_SetUp();
                        MainDatabase.LoadData_NhanSu();                        
                        MainDatabase.LoadData_PhongBan();                        
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
                
        private void menuItem_Thoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void lblQuenMatKhau_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoiMatKhau frmquenMatKhau = new DoiMatKhau();
            frmquenMatKhau.ShowDialog();
        }       

        private void menuItem_DoiMatKhau_Click(object sender, RoutedEventArgs e)
        {
            DoiMatKhau frmquenMatKhau = new DoiMatKhau();
            frmquenMatKhau.ShowDialog();
        }

        private void menuItem_ThongTinPhanMem_Click(object sender, RoutedEventArgs e)
        {
            ThongTinPhanMem frmThongTinPhanMem = new ThongTinPhanMem();
            frmThongTinPhanMem.Show();            
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
    }
}
