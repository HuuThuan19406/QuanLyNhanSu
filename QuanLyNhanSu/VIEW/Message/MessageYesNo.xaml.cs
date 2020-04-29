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
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class MessageYesNo : Window
    {
        public enum Options
        {
            Warning,
            Error,
            Information,
            Successful
        }
        public static bool Yes { get; set; } = false;
        public MessageYesNo(string content)
        {
            InitializeComponent();
            btnClose.Click += (s, a) => { Yes = false; Close(); };
            txbContent.Text = content;
            lblCaption.Content = "";
            ShowDialog();
        }
        public MessageYesNo(string caption, string content)
        {
            InitializeComponent();
            RemovePackIcon();
            btnClose.Click += (s, a) => { Yes = false; Close(); };

            btnOkey.Click += (s, a) => { Yes = true; Close(); };
            btnCancel.Click += (s, a) => { Yes = false; Close(); };

            txbContent.Text = content;
            lblCaption.Content = caption;
            ShowDialog();
        }
        public MessageYesNo(string caption, string content, Options option)
        {
            InitializeComponent();
            btnClose.Click += (s, a) => Close();
            btnOkey.Click += (s, a) => { Yes = true; Close(); };
            btnCancel.Click += (s, a) => { Yes = false; Close(); };
            switch (option)
            {
                case Options.Warning:
                    packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.AlertCircle;
                    break;
                case Options.Error:
                    packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CloseCircle;
                    break;
                case Options.Successful:
                    packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckCircle;
                    break;
                case Options.Information:
                    packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ClipboardText;
                    break;
            }
            txbContent.Text = content;
            lblCaption.Content = caption;
            ShowDialog();
        }
        
        private void RemovePackIcon()
        {
            StackMain.Children.Remove(packIcon);
            txbContent.Width = 400;
        }
    }
}
