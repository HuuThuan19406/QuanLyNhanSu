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

namespace QuanLyNhanSu
{
    public partial class ResourceDictionary 
    {
        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;
            label.Foreground = Brushes.MediumBlue;
            label.FontSize += 2;
        }
        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;
            label.Foreground = Brushes.Black;
            label.FontSize -= 2;
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            button.FontSize += 2;
            button.Height += 7; button.Width += 7;
        }
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            button.FontSize -= 2;
            button.Height -= 7; button.Width -= 7;
        }

    }
}
