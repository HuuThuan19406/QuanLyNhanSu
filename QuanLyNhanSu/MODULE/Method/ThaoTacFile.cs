using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuanLyNhanSu
{
    class ThaoTacFile
    {
        /// <summary>
        /// Ghi vào tệp, nếu tệp chưa tồn tại sẽ tạo tệp, đã tồn tại sẽ bỏ nội dung cũ thay bằng content
        /// </summary>
        /// <param name="nameFile"></param>
        /// <param name="content"></param>
        public static void Ghi(string nameFile, string content)
        {
            StreamWriter fi = new StreamWriter(@nameFile);
            fi.WriteLine(content);
            fi.Close();
        }
        public static string Doc(string namePath)
        {
            StreamReader fo = new StreamReader(@namePath);
            return fo.ReadToEnd();
        }       
    }
}
