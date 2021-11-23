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

namespace Lesson4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pbConsole.Click += new System.Windows.RoutedEventHandler(changeContent);
           // pbConsole.Click += (pbConsole, new RoutedEventArgs()) => pbConsole.Background = new Brush();
        }

        private void PbConsole_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void changeContent(object sender, RoutedEventArgs e)
        {
            pbConsole.Content = "Wow";
        }

        private void pbConsole_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbConsole.Text.Contains("Hello"))
                {;
                    throw new WrongInputExpetion("Should not contain HELLO");
                }
                tbConsole.Text = "Hello " + tbConsole.Text;
            }
            catch (Exception ex)
            {
                tbConsole.Text = ex.Message;
                throw new ApplicationException("oops", ex);
            }
           
        }

        private void pbConsole_MouseEnter(object sender, MouseEventArgs e)
        {
            // pbConsole.Height *= 2;
            // pbConsole.Width *= 2;
            MessageBox.Show("מי הרשה ללחוץ על הכפתור הזה?",
                      "אזהרה חשובה",
                      MessageBoxButton.OK,
                      MessageBoxImage.Hand,
                      MessageBoxResult.Cancel,
                      MessageBoxOptions.RtlReading);
            this.Hide();
            new StudentWindow().ShowDialog();
            this.Show();
        }
    }
}
