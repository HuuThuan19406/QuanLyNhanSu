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
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\MODULE\Database\CSDL.mdf;Integrated Security=True";
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
                    {
                        new Message("LỖI", "Mật khẩu xác nhận không khớp", true, Message.Options.Error);
                        pwbMatKhau1.Clear();
                        pwbMatKhau2.Clear();
                        pwbMatKhau1.Focus();
                        return;
                    }
                    if (pwbMatKhauCu.Password == pwbMatKhau2.Password)
                    {
                        new MessageYesNo("CẢNH BÁO", "Mật khẩu mới giống hệt mật khẩu hiện tại, không có sự thay đổi ", MessageYesNo.Options.Warning);
                        if (!MessageYesNo.Yes)
                        {
                            pwbMatKhau1.Clear();
                            pwbMatKhau2.Clear();
                            pwbMatKhau1.Focus();
                            return;
                        }
                    }
                    con = new SqlConnection();
                    con.ConnectionString = connection;
                    query = "UPDATE [dbo].[TaiKhoan] SET Password=@Password WHERE Id=@Id";
                    con.Open();
                    cmd = new SqlCommand(query, con);                
                    cmd.Parameters.AddWithValue("@Password", MaHoa.BinaryCode(pwbMatKhau2.Password));
                    cmd.Parameters.AddWithValue("@Id", txtTaiKhoan.Text.ToLower());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    new Message("THÔNG BÁO", "Cập nhật thành công, vui lòng đăng nhập lại", false, Message.Options.Successful);
                    Close();
                }
                else
                {
                    new Message("LỖI", "Sai mật khẩu", true, Message.Options.Error);
                    pwbMatKhauCu.Clear();
                    pwbMatKhauCu.Focus();
                }
            }
            else
            {
                new Message("LỖI", "Tài khoản không tồn tại", true, Message.Options.Warning);
                txtTaiKhoan.Clear();
                pwbMatKhauCu.Clear();
                pwbMatKhau1.Clear();
                pwbMatKhau2.Clear();
                txtTaiKhoan.Focus();
            }
        }        
    }
}
