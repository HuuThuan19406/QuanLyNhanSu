using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace QuanLyNhanSu
{
    class ChuyenDoi
    {
        public BitmapImage Source { get; private set; }

        /// <summary>
        /// Trả về chuỗi Base64 mã hóa từ ảnh
        /// </summary>
        /// <param name="imgPath">Đường dẫn thư mục chứa ảnh</param>
        /// <returns></returns>
        public static string Base64(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }
        public static void HinhAnh(Image image, string base64String)
        {
            byte[] imgBytes = Convert.FromBase64String(base64String);
            BitmapImage bitmapImage = new BitmapImage();
            MemoryStream ms = new MemoryStream(imgBytes);
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = ms;
            bitmapImage.EndInit();
            image.Source = bitmapImage;
        }
        public static BitmapImage BitMapImage(string base64String)
        {
            byte[] imgBytes = Convert.FromBase64String(base64String);
            BitmapImage bitmapImage = new BitmapImage();
            MemoryStream ms = new MemoryStream(imgBytes);
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = ms;
            bitmapImage.EndInit();
            return bitmapImage;
        }
    }
}
