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
    public partial class Message : Window
    {
        public enum Options
        {
            Warning,
            Error,
            Information,
            Successful
        }
        public Message(string content)
        {
            InitializeComponent();
            btnClose.Click += (s, a) => Close();
            RemoveButtonOkey();
            RemovePackIcon();
            txbContent.Width = 450;
            txbContent.Text = content;
            ShowDialog();
        }
        public Message(string caption, string content, bool haveButton)
        {
            InitializeComponent();
            btnClose.Click += (s, a) => Close();
            RemovePackIcon();
            if (!haveButton)            
                RemoveButtonOkey();
            else            
                btnOkey.Click += (s, a) => Close();            
            txbContent.Text = content;
            lblCaption.Content = caption;
            ShowDialog();
        }
        public Message(string caption, string content, bool haveButton, Options option)
        {
            InitializeComponent();
            btnClose.Click += (s, a) => Close();
            if (!haveButton)
                RemoveButtonOkey();
            else
                btnOkey.Click += (s, a) => Close();
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

        private void RemoveButtonOkey()
        {
            StackChild.Children.Remove(btnOkey);
            txbContent.Height = 80;
        }
        private void RemovePackIcon()
        {
            StackMain.Children.Remove(packIcon);
            txbContent.Width = 400;
        }       
    }
}
