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
    /// Interaction logic for DoiMatKhau.xaml
    /// </summary>
    public partial class DoiMatKhau : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string query;
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\D\QuanLyNhanSu\QuanLyNhanSu\QuanLyNhanSu\MODULE\Database\Database.mdf;Integrated Security=True";

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = connection;
            query = "SELECT * FROM [dbo].[TaiKhoan]";
            con.Open();
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Hashtable AccountList = new Hashtable();
            while (dr.Read())
            {
                AccountList.Add(dr["Id"].ToString().ToLower(), MaHoa.BinaryCode_GiaiMa(dr["Password"].ToString()));
            }
            con.Close();
            if (AccountList.ContainsKey((txtTaiKhoan.Text.ToLower())))
            {
                if (AccountList[txtTaiKhoan.Text.ToLower()].ToString() == pwbMatKhauCu.Password)
                {
                    if (pwbMatKhau1.Password != pwbMatKhau2.Password)
                        MessageBox.Show("Mật khẩu xác nhận không khớp", "LỖI", MessageBoxButton.OK, MessageBoxImage.Error);
                    con = new SqlConnection();
                    con.ConnectionString = connection;
                    query = "UPDATE [dbo].[TaiKhoan] SET Password=@Password WHERE Id=@Id";
                    con.Open();
                    cmd = new SqlCommand(query, con);                
                    cmd.Parameters.AddWithValue("@Password", MaHoa.BinaryCode(pwbMatKhau2.Password));
                    cmd.Parameters.AddWithValue("@Id", txtTaiKhoan.Text.ToLower());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cập nhật thành công, vui lòng đăng nhập lại", "YÊU CẦU", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    Close();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "LỖI", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "LỖI", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }        
    }
}
