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
using LiveCharts;
using LiveCharts.Wpf;

namespace PetDiary
{
    /// <summary>
    /// Логика взаимодействия для Statistics.xaml
    /// </summary>
    public partial class Statistics : Window
    {

        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public Statistics()
        {

            ViewModel.ReportStatViewModel.InitStat(true);
            InitializeComponent();
            ViewModel.StatViewModel.GetStatistic(ViewModel.MainWindowViewModel.SelectedPet.Id);
            DataContext = ApplicationContext.Get();

            var listik = new ChartValues<int>();
            foreach (Stat el in ViewModel.StatViewModel.Statistic)
            {
                listik.Add(el.Weight);
            }
            ViewModel.StatViewModel.SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {

                    Values =  listik
                }

            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");
        }
    }
}
