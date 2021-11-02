﻿using System;
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
    }
}
