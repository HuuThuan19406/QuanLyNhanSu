using QuanLyNhanSu.MODULE.XyLuDatabase;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace QuanLyNhanSu
{
    /// <summary>
    /// Interaction logic for ListPhongBan.xaml
    /// </summary>
    public partial class ListBoPhan : UserControl
    {        
        public ListBoPhan()
        {
            InitializeComponent();
            this.DataContext = this;            
            listView.MouseDoubleClick += (s, a) => listView.SelectedIndex = -1;
        }

        private void comBoBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comBoBox.SelectedIndex==-1)
            {
                listView.ItemsSource = null;
                listView.Items.Clear();
                return;
            }            
            listView.ItemsSource = null;
            listView.Items.Clear();
            listView.ItemsSource = MainDatabase.dsNhanSu.Values.Cast<NhanSu>().Where(p => p.BoPhan == comBoBox.SelectedItem.ToString());
        }
    }
}
