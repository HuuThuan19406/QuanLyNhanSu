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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;

namespace QuanLyNhanSu
{
    /// <summary>
    /// Interaction logic for XuatFile.xaml
    /// </summary>
    public partial class XuatFile : Window
    {
        public XuatFile()
        {
            InitializeComponent();
            btnClose.Click += (s, a) => Close();
        }

        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            string namePath = "";
            Microsoft.Win32.SaveFileDialog fileSource = new Microsoft.Win32.SaveFileDialog();
            fileSource.Filter = "CSV File(*.csv)| *.csv";
            if (fileSource.ShowDialog() == true)
            {
                namePath = fileSource.FileName;
            }
            else
                return;
            string st = "STT,Họ và tên,CMND/CCCD,Mã nhân viên,Giới tính,Ngày sinh,Quê quán, Số điện thoại,Bộ phận,Chức vụ,Ngày vào";
            for (int i = 0; i < listView.Items.Count; i++)
            {
                var nhanSu = listView.Items[i] as NhanSu;
                st += "\n";
                st += (i + 1).ToString() + ',';
                st += nhanSu.HoTen + ',';
                st += nhanSu.CMND + ',';
                st += nhanSu.MaNhanVien + ',';
                st += nhanSu.GioiTinh + ',';
                st += nhanSu.NgaySinh.ToString("dd/MM/yyyy") + ',';
                st += nhanSu.QueQuan + ',';
                st += nhanSu.SoDienThoai + ',';
                st += nhanSu.BoPhan + ',';
                st += nhanSu.ChucVu + ',';
                st += nhanSu.NgayVao.ToString("dd/MM/yyyy") + ',';                               
            }
            st += "\n\n" + HienThi.GioPhutGiay()
                + "\n" + HienThi.NgayThang()
                + "\nBảng được xuất bởi tài khoản: " + idDangNhap;
            ThaoTacFile.TextFile.Ghi(namePath, st);
            new Message("THÔNG BÁO", "Đã xuất danh sách thành công\nMở xem tại " + fileSource.FileName, false, Message.Options.Successful);
        }
        public ListView listView { get; set; }
        public string idDangNhap { get; set; }

        private void btnPDF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string namePath = "";
                Microsoft.Win32.SaveFileDialog fileSource = new Microsoft.Win32.SaveFileDialog();
                fileSource.Filter = "PDF File(*.pdf)| *.pdf";
                if (fileSource.ShowDialog() == true)
                {
                    namePath = fileSource.FileName;
                }
                else
                    return;                
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@namePath, FileMode.Create));
                document.Open();
                document.SetPageSize(PageSize.A3);
                document.NewPage();
                string CONSOLAS_TTF = System.IO.Path.Combine("CONSOLAS.TTF");
                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(CONSOLAS_TTF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                //Create a specific font object
                Font f = new Font(bf, 10, Font.NORMAL);
                PdfPTable table = new PdfPTable(11);
                table.WidthPercentage = 100;
                float[] widths = new float[] { 15f, 70f, 40f, 45f, 30f, 50f, 70f, 40f, 70f, 70f, 40f };
                table.SetWidths(widths);
                PdfPCell cell = new PdfPCell(new Phrase("DANH SÁCH NHÂN SỰ"));
                cell.Colspan = listView.Items.Count;
                table.AddCell(new Phrase("STT", f));
                table.AddCell(new Phrase("    HỌ VÀ TÊN", f));
                table.AddCell(new Phrase("CMND/CCCD", f));
                table.AddCell(new Phrase("MÃ N.VIÊN", f));
                table.AddCell(new Phrase("G.TÍNH", f));
                table.AddCell(new Phrase("  NGÀY SINH", f));
                table.AddCell(new Phrase("     QUÊ QUÁN", f));
                table.AddCell(new Phrase("   SĐT", f));
                table.AddCell(new Phrase("     BỘ PHẬN", f));
                table.AddCell(new Phrase("     CHỨC VỤ", f));
                table.AddCell(new Phrase(" NGÀY VÀO", f));
                f = new Font(bf, 8, Font.NORMAL);
                for (int i = 0; i < listView.Items.Count; i++)
                {
                    var nhanSu = listView.Items[i] as NhanSu;
                    table.AddCell(new Phrase((i + 1).ToString(), f));
                    table.AddCell(new Phrase(nhanSu.HoTen, f));
                    table.AddCell(new Phrase(nhanSu.CMND, f));
                    table.AddCell(new Phrase(nhanSu.MaNhanVien, f));
                    table.AddCell(new Phrase(nhanSu.GioiTinh, f));
                    table.AddCell(new Phrase(nhanSu.NgaySinh.ToString("dd/MM/yyyy"), f));
                    table.AddCell(new Phrase(nhanSu.QueQuan, f));
                    table.AddCell(new Phrase(nhanSu.SoDienThoai, f));
                    table.AddCell(new Phrase(nhanSu.BoPhan, f));
                    table.AddCell(new Phrase(nhanSu.ChucVu, f));
                    table.AddCell(new Phrase(nhanSu.NgayVao.ToString("dd/MM/yyyy"), f));
                }
                document.Add(table);
                f = new Font(bf, 10, Font.NORMAL);
                document.Add(new Phrase("\n\n" + HienThi.GioPhutGiay(), f));
                document.Add(new Phrase("\n" + HienThi.NgayThang(), f));
                document.Add(new Phrase("\nBảng được xuất bởi tài khoản: " + idDangNhap, f));
                document.Close();
                new Message("THÔNG BÁO", "Đã xuất danh sách thành công\nMở xem tại " + fileSource.FileName, false, Message.Options.Successful);
            }
            catch (Exception ex)
            {
                new Message("ERROR", ex.Message, false, Message.Options.Error);
            }
        }
    }
}
