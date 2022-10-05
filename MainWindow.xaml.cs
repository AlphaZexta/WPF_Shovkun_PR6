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

namespace WPF_Shovkun_PR6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Properties.Settings.Default.Save();  
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();

            int n = 0;

            switch (n)
            {
                case 0:
                    if (n == 0) MessageBox.Show("Текстовые поля не заполнены");
                    break;
                default:
                    Window1.Show;
                    break;
            }
        }
    }
}
