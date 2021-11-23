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
using Lesson2;

namespace Lesson6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDAL.IDal dal = new DalObject.DalObject();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("See you next time",
                            "By Bye",
                             MessageBoxButton.OKCancel,
                             MessageBoxImage.Information);


        }

        private void SecondButton_Click(object sender, RoutedEventArgs e)
        {
            
            new StudentWindow(dal).Show();
        }
    }
}
