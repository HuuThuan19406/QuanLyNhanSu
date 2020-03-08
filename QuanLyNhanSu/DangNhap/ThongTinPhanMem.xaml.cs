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
    /// Interaction logic for ThongTinPhanMem.xaml
    /// </summary>
    public partial class ThongTinPhanMem : Window
    {
        public ThongTinPhanMem()
        {
            InitializeComponent();
            Icon = ChuyenDoi.BitMapImage(MainWindow.base64_defaultAvatar);
            txbTacGia.Text += HienThi.author;
            lblPhienBan.Content += HienThi.version;
            lblThoiGianPhatHanh.Content += HienThi.updateDay;
            lblLoaiPhanMem.Content += HienThi.level[3];
            lblHotline.Content += HienThi.hotline;
            lblEmail.Content += HienThi.email;
            txbDiaChiTruSo.Text += HienThi.diaChiTruSo;
            lblFooter.Text = HienThi.FooterInfo();
        }
    }
}
