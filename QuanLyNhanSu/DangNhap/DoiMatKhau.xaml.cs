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
using QuanLyNhanSu.MODULE.XyLuDatabase;

namespace QuanLyNhanSu
{
    /// <summary>
    /// Interaction logic for DoiMatKhau.xaml
    /// </summary>
    public partial class DoiMatKhau : Window
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            if (MainDatabase.dsTaiKhoan.ContainsKey((txtTaiKhoan.Text.ToLower())))
            {
                if (((TaiKhoan)MainDatabase.dsTaiKhoan[txtTaiKhoan.Text.ToLower()]).Password == pwbMatKhauCu.Password)
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
                    MainDatabase.dsTaiKhoan[txtTaiKhoan.Text.ToLower()] = new TaiKhoan()
                    {
                        User = ((TaiKhoan)MainDatabase.dsTaiKhoan[txtTaiKhoan.Text.ToLower()]).User,
                        Id = ((TaiKhoan)MainDatabase.dsTaiKhoan[txtTaiKhoan.Text.ToLower()]).Id,
                        Password = pwbMatKhau2.Password
                    };
                    MainDatabase.WriteData_TaiKhoan();
                    new Message("THÔNG BÁO", "Cập nhật thành công, vui lòng đăng nhập lại", true, Message.Options.Successful);
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
