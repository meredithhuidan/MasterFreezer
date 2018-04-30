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

namespace MasterFreezer
{
    /// <summary>
    /// QujianWindow.xaml 的交互逻辑
    /// </summary>
    public partial class QujianWindow : Window
    {
        public QujianWindow()
        {
            InitializeComponent();
        }

        private void btnfanhuiyonghu_Click(object sender, RoutedEventArgs e)
        {
            if (true)//里面掉验证函数
            {
                // 打开子窗体
                MainWindow aChild = new MainWindow();
                aChild.Show();
                // 隐藏自己(父窗体)
                this.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void btnqujian_Click(object sender, RoutedEventArgs e)
        {
            if (true)//里面掉验证函数
            {
                // 打开子窗体
                OpenWindow aChild = new OpenWindow();
                aChild.Show();
                // 隐藏自己(父窗体)
                this.Visibility = System.Windows.Visibility.Hidden;
            }
        }
        /*private void txtphone_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtphone.Text == "输入手机号码")
            {
                txtphone.Text = "";
            }
        }*/
    }
}
