﻿using PetDiary.ViewModels;
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

namespace PetDiary
{
    /// <summary>
    /// Логика взаимодействия для ReportFeeding.xaml
    /// </summary>
    public partial class ReportFeeding : Window
    {
        public ReportFeeding()
        {

            ViewModel.ReportFeedingViewModel.InitNote(true);
            InitializeComponent();
            DataContext = ApplicationContext.Get();
        }

        private void butcancelpet_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}