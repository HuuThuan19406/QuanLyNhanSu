using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace QuanLyNhanSu
{
    class KiemTra
    {
        private static string TrimAll(string st)
        {
            st = st.Trim();
            while (st.Contains("  "))
                st = st.Replace("  ", " ");
            return st;
        }
        /// <summary>
        /// Thông báo nếu chuỗi truyền vào textbox không phải là Tên hợp lệ
        /// </summary>
        /// <param name="hoTen"></param>
        
        public static void isHoTen(TextBox HoTen)
        {
            //HoTen.Text = HoTen.Text.Trim();
            for (int i = HoTen.Text.Length - 1; i >= 0; i--)
                if (Char.IsDigit(HoTen.Text[i]) || 
                   (HoTen.Text[i] >= '!' && HoTen.Text[i] <= '.') || 
                   (HoTen.Text[i] >= ':' && HoTen.Text[i] <= '@')) 
                {
                    //MessageBox.Show("Giá trị phải là từ ngữ có nghĩa", "LỖI DỮ LIỆU", MessageBoxButton.OK, MessageBoxImage.Error);
                    new Message("LỖI DỮ LIỆU", "Giá trị phải là từ ngữ có nghĩa", true, Message.Options.Warning);
                    HoTen.Text = HoTen.Text.Remove(i, 1);
                    HoTen.CaretIndex = i;                    
                    try { } catch { }
                }
            HoTen.KeyDown += (s, a) =>
            {
                if ((a.Key == System.Windows.Input.Key.Enter) || (a.Key == System.Windows.Input.Key.Tab))
                    HoTen.Text = TrimAll(HoTen.Text);
            };
        }
        /// <summary>
        /// Kiểm tra chuỗi truyền vào textbox có phải chỉ chứa mỗi số hay không
        /// </summary>
        /// <param name="so"></param>
        
        public static void isChiChuaSo(TextBox So)
        {

            //So.Text = So.Text.Trim();
            if (So.Text.Length > 0)
                for (int i = So.Text.Length - 1; i >= 0; i--)
                {
                    if (!Char.IsDigit(So.Text[i]))
                    {
                        //MessageBox.Show("Giá trị chỉ được là số", "LỖI DỮ LIỆU", MessageBoxButton.OK, MessageBoxImage.Error);
                        new Message("LỖI DỮ LIỆU", "Giá trị chỉ được là số", true, Message.Options.Warning);
                        So.Text = So.Text.Remove(i, 1);
                        So.CaretIndex = i;
                        try { } catch { }
                    }
                }
        }
        /// <summary>
        /// Kiểm tra có textbox có rỗng không
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <returns></returns>
        public static bool isNotEmptype(params TextBox[] textBoxes)
        {
            foreach(TextBox textBox in textBoxes)
            {
                if (textBox.Text == "")
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Kiểm tra có combobox có rỗng không
        /// </summary>
        /// <param name="comboBoxs"></param>
        /// <returns></returns>
        public static bool isNotEmptype(params ComboBox[] comboBoxs)
        {
            foreach (ComboBox comboBox in comboBoxs)
            {
                if (comboBox.SelectedIndex == -1) 
                    return false;
            }
            return true;
        }
    }
}
