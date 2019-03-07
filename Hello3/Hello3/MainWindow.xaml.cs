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

namespace Hello3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String[] args = Environment.GetCommandLineArgs();
            String msg = "";
            if (args.Length == 0)
            {
                msg = "There is no argument.";
            }
            else
            {
                msg = $"There are {args.Length} argument(s).\nThey are:\n";
                for (int i = 0; i < args.Length; ++i)
                {
                    msg += args[i] + "\n";
                }
            }
            MessageBox.Show(msg);
        }
    }
}
