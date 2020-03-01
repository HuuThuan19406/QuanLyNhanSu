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

namespace QuanLyNhanSu
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        WaitForLoading frmWait;
        public static Hashtable AccountList;
        public static string idDangNhap { get; set; }
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\D\QuanLyNhanSu\QuanLyNhanSu\QuanLyNhanSu\MODULE\Database\Database.mdf;Integrated Security=True";

        public DangNhap()
        {
            InitializeComponent();
            Icon = ChuyenDoi.BitMapImage(MainWindow.base64_defaultAvatar);
            txtTaiKhoan.Text = "tester";
            pwbMatKhau.Password = "123456";
            frmWait = new WaitForLoading();
            frmWait.Hide();            
        }

        private void Tai_dsTaiKhoan()
        {
            string active = "SELECT * FROM [dbo].[TaiKhoan]";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection;
            con.Open();
            SqlCommand cmd = new SqlCommand(active, con);
            SqlDataReader dr = cmd.ExecuteReader();
            AccountList = new Hashtable();
            while (dr.Read())
            {
                AccountList.Add(dr["Id"].ToString().ToLower(), MaHoa.BinaryCode_GiaiMa(dr["Password"].ToString()));
            }
            con.Close();
        }
        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            Tai_dsTaiKhoan();
            if (AccountList.ContainsKey((txtTaiKhoan.Text.ToLower())))
            {
                if (AccountList[txtTaiKhoan.Text.ToLower()].ToString() == pwbMatKhau.Password)
                {
                    frmWait.Show();
                    idDangNhap = txtTaiKhoan.Text.ToLower();
                    MainWindow frmMain = new MainWindow();
                    frmMain.Show();
                    frmWait.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "LỖI", MessageBoxButton.OK, MessageBoxImage.Error);
                    pwbMatKhau.Clear();
                    MessageBox.Show("THÔNG TIN MẶC ĐỊNH" +
                                    "\nTài khoản: tester" +
                                    "\nMật khẩu: 123456", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "LỖI", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("THÔNG TIN MẶC ĐỊNH" +
                                "\nTài khoản: tester" +
                                "\nMật khẩu: 123456", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            frmWait.Close();
        }

        private void lblQuenMatKhau_MouseEnter(object sender, MouseEventArgs e)
        {
            lblDoiMatKhau.Foreground = Brushes.MediumBlue;
            lblDoiMatKhau.FontSize += 2;
        }

        private void lblQuenMatKhau_MouseLeave(object sender, MouseEventArgs e)
        {
            lblDoiMatKhau.Foreground = Brushes.Black;
            lblDoiMatKhau.FontSize -= 2;
        }

        private void lblQuenMatKhau_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DoiMatKhau frmquenMatKhau = new DoiMatKhau();
            frmquenMatKhau.ShowDialog();
        }
    }
}
