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
using System.Windows.Shapes;

namespace Lesson6
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        IDAL.IDal dal;
        public StudentWindow(IDAL.IDal dal)
        {
            this.dal = dal;
            InitializeComponent();
           
            StudentDegreeSelector.ItemsSource = Enum.GetValues(typeof(IDAL.DO.Degree));
        }

        private void StudentDegreeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IDAL.DO.Degree degree = (IDAL.DO.Degree)StudentDegreeSelector.SelectedItem;
            dal.AddStudent(degree);
            dal.GetAllParcelsIDS(p => p.Degree == degree);
        }
    }
}
