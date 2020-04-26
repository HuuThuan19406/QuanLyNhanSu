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

namespace QuanLyNhanSu
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public static Hashtable danhSachNhanSu;
        public static Hashtable AccountList;
        public static string idDangNhap { get; set; }
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\MODULE\Database\CSDL.mdf;Integrated Security=True";

        public DangNhap()
        {
            InitializeComponent();
            Icon = ChuyenDoi.BitMapImage(MainWindow.base64_defaultAvatar);
            string[] r = new string[] { "\n" };
            string[] s = ThaoTacFile.Doc("signin.txt").Split(r, StringSplitOptions.RemoveEmptyEntries);
            if (s == null)
            {
                txtTaiKhoan.Text = "tester";
                pwbMatKhau.Password = "123456";
                return;
            }
            string[] execute;
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i].Trim() == "%SignIn") && (i + 1 < s.Length))
                {
                    j = i + 1;
                    while ((j < s.Length) && (s[j] != "SignIn%"))
                    {
                        execute = s[j].Split(new string[] { " <- " }, StringSplitOptions.RemoveEmptyEntries);
                        switch (execute[0].Trim())
                        {
                            case "Id":
                                txtTaiKhoan.Text = execute[1];
                                break;
                            case "Password":
                                pwbMatKhau.Password = MaHoa.BinaryCode_GiaiMa(MaHoa.BinaryCode_GiaiMa(execute[1]));
                                break;
                        }
                        j++;
                    }
                }
            }            
            //frmWait = new WaitForLoading();
            //frmWait.Hide();            
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
            if (AccountList == null) 
                Tai_dsTaiKhoan();
            if (AccountList.ContainsKey((txtTaiKhoan.Text.ToLower())))
            {
                if (AccountList[txtTaiKhoan.Text.ToLower()].ToString() == pwbMatKhau.Password)
                {
                    if (checkLuuDangNhap.IsChecked == true)
                    {
                        string s = "";
                        s += "%SignIn\n \tId <- " + txtTaiKhoan.Text + "\n";
                        s += "\tPassword <- " + MaHoa.BinaryCode(MaHoa.BinaryCode(pwbMatKhau.Password));
                        s += "\nSignIn%";
                        s += "\n*Created <- Time = " + HienThi.NowTime();
                        ThaoTacFile.Ghi("signin.txt", s);
                    }
                    WaitForLoading frmWait = new WaitForLoading();
                    frmWait.Show();
                    var working = new BackgroundWorker();
                    working.DoWork += (s, a) =>
                    {
                        Thread.Sleep(1000);
                        danhSachNhanSu = InsertDataToNhanSu(connection, "[dbo].[ThongTin]");
                    };
                    working.RunWorkerCompleted += (s, a) =>
                    {
                        MainWindow frmMain = new MainWindow();
                        frmMain.Show();
                        frmWait.Close();
                    };
                    working.RunWorkerAsync();
                    //frmWait.Show();
                    idDangNhap = txtTaiKhoan.Text.ToLower();

                    //frmWait.Close();
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
        public Hashtable InsertDataToNhanSu(string connection, string SELECT_FROM)
        {
            SqlConnection con = new SqlConnection(); //Tạo mới connection
            con.ConnectionString = connection;
            con.Open(); //Mở kết nối Database
            string query = "SELECT * FROM " + SELECT_FROM; //Lệnh truy vấn
            SqlCommand cmd = new SqlCommand(query, con); //Thực hiện truy vấn
            SqlDataReader dr = cmd.ExecuteReader(); //Thực hiện đọc (truyền tạm vào dr là trung gian)
            Hashtable danhSachNhanSu = new Hashtable();
            while (dr.Read())
            {
                NhanSu nhanSu = new NhanSu();
                nhanSu.HoTen = dr["HoVaTen"].ToString();
                nhanSu.CMND = dr["CMND"].ToString();
                nhanSu.MaNhanVien = dr["MaNhanVien"].ToString();
                nhanSu.GioiTinh = dr["GioiTinh"].ToString();
                nhanSu.NgaySinh = Convert.ToDateTime(dr["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                nhanSu.NgayVao = Convert.ToDateTime(dr["NgayVao"].ToString()).ToString("dd/MM/yyyy");
                nhanSu.QueQuan = dr["QueQuan"].ToString();
                nhanSu.SoDienThoai = dr["SoDienThoai"].ToString();
                nhanSu.ChucVu = dr["ChucVu"].ToString();
                nhanSu.BoPhan = dr["BoPhan"].ToString();
                nhanSu.Avatar = dr["Avatar"].ToString();
                danhSachNhanSu.Add(nhanSu.MaNhanVien, nhanSu);
            }
            con.Close(); //Ngắt kết nối
            return danhSachNhanSu;
        }
    }
}
