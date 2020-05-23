using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using PetDiary.Command;
using PetDiary.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetDiary.ViewModels
{
    public class StatViewModel : ViewModelBase
    {
        public ObservableCollection<Stat> Statistic {
            get => _statistic;
            set {
                _statistic = value;
                OnPropertyChanged(nameof(Statistic));
            }
        }

        private ObservableCollection<Stat> _statistic;
        public SeriesCollection SeriesCollection { get; set; }

        public StatViewModel()
        {
            Statistic = new ObservableCollection<Stat>();
           
        }
        #region Commands

        private RelayCommand _addStatCommand;
        public RelayCommand AddStatCommand {
            get {
                return _addStatCommand ??
                  (_addStatCommand = new RelayCommand(obj =>
                  {
                      var item = ViewModel.ReportStatViewModel.Stat;
                      if (item.Weight > 0.0)
                      {
                          StatDB.AddStat(item.Date, item.Weight, ViewModel.MainWindowViewModel.SelectedPet.Id);
                          if (ViewModel.MainWindowViewModel.SelectedPet != null)
                          {
                              GetStatistic(ViewModel.MainWindowViewModel.SelectedPet.Id);
                          }
                          var win = new MainWindow();
                          win.Show();
                          foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                          {
                              if (System.Windows.Application.Current.Windows.Count > 1)
                                  window.Close();
                          }
                      }
                  }));
            }
        }

        #endregion
        #region Methods
        public void GetStatistic(int petId)
        {
            Statistic.Clear();
            var items = StatDB.GetStatistic(petId);
            items.ForEach(Statistic.Add);
        }
        #endregion
    }
}