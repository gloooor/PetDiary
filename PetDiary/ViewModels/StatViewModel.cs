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

namespace PetDiary.ViewModels
{
    public class StatViewModel: INotifyPropertyChanged
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
                      StatDB.AddStat(item.Number, item. Weight, ViewModel.PetViewModel.SelectedPet.Id);
                      if (ViewModel.PetViewModel.SelectedPet != null)
                      {
                          GetStatistic(ViewModel.PetViewModel.SelectedPet.Id);
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
