using PetDiary.ViewModels;
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
    /// Логика взаимодействия для ReporlActivity.xaml
    /// </summary>
    public partial class ReporlActivity : Window
    {
        public ReporlActivity()
        {

            ViewModel.ReportActivityViewModel.InitNote(true);
            InitializeComponent();
            DataContext = ApplicationContext.Get();
        }

    }
}
