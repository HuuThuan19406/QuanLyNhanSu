using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyNhanSu
{
    /// <summary>
    /// Interaction logic for ThemSuaPhongBan.xaml
    /// </summary>
    public partial class ThemSuaPhongBan : Window
    {
        public ThemSuaPhongBan()
        {
            InitializeComponent();
            Icon = ChuyenDoi.BitMapImage(MainWindow.base64_defaultAvatar);
            this.DataContext = this;
        }
        public string tenPhongBan { get; set; }
        public string PdsChucVu { get; set; } = "";
        public List<string> dsChucVu
        {
            get
            {
                string[] stringCut = new string[] { ",", ", ", ";", "; " },
                st = PdsChucVu.Split(stringCut, StringSplitOptions.None);
                List<string> tmp = new List<string>();
                for (int i = 0; i < st.Length; i++)
                    if (!String.IsNullOrWhiteSpace(st[i]))
                    {
                        if (st[i].Trim().Length > 1)
                            tmp.Add(st[i].Trim().ToUpper()[0] + st[i].Trim().ToLower().Substring(1));
                        else
                            st[i].Trim().ToUpper();
                    }
                return tmp;
            }
        }
        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
