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


namespace Lesson3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student st = new Student(1);
        public MainWindow()
        {
            
            st.Name = "Avraham";
            st.RegDate = DateTime.Now;
            String courseName = "C#";
            Course course = new Course() { Id = 153007, Name = courseName };
            course.Name = "dotnet";

            IDAL.DO.DataSource.courses[0]= course;

            Random random = new Random();
            IDAL.DO.Degree degree = (IDAL.DO.Degree)random.Next(3);

            InitializeComponent();
        }

        private void pb_Console_Click(object sender, RoutedEventArgs e)
        {
            tb_Console.Text = $"Hello {st.Name}";
        }

        private void pb_getConsoleText_Click(object sender, RoutedEventArgs e)
        {
            //st.Name = tb_Console.Text;
            int grade;

            int.TryParse(tb_Console.Text, out grade);
            st.Grade = grade;
        }
    }
}
