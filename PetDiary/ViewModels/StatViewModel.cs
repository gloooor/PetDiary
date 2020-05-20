using LiveCharts;
using LiveCharts.Defaults;
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
    public class StatViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Stat> Statistic {
            get => _statistic;
            set {
                _statistic = value;
                OnPropertyChanged(nameof(Statistic));
            }
        }

        private ObservableCollection<Stat> _statistic;
        public ChartValues<DateTimePoint> RawDataSeries {
            get {
                ChartValues<DateTimePoint> Values = new ChartValues<DateTimePoint>();
                foreach (Stat el in Statistic)
                {
                    if (el.Weight > 0)
                    {
                        MessageBox.Show(el.Weight.ToString(), el.Date.ToString());
                        Values.Add(new DateTimePoint(el.Date, el.Weight));
                    }
                }
                return Values;
            }
        }


        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public StatViewModel()
        {
            Statistic = new ObservableCollection<Stat>();
        }

        private RelayCommand _addStatCommand;
        public RelayCommand AddStatCommand {
            get {
                return _addStatCommand ??
                  (_addStatCommand = new RelayCommand(obj =>
                  {
                      var item = ViewModel.ReportStatViewModel.Stat;
                      StatDB.AddStat(item.Date, item.Weight, ViewModel.MainWindowViewModel.SelectedPet.Id);
                      if (ViewModel.MainWindowViewModel.SelectedPet != null)
                      {
                          GetStatistic(ViewModel.MainWindowViewModel.SelectedPet.Id);
                      }
                  }));
            }
        }


        public void GetStatistic(int petId)
        {
            Statistic.Clear();
            var items = StatDB.GetStatistic(petId);
            items.ForEach(Statistic.Add);
        }
    }
}