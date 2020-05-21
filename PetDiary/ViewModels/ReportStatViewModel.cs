using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class ReportStatViewModel : INotifyPropertyChanged
    {
        public Stat Stat { get; set; }
        public void InitStat(bool force = false)
        {
            if (Stat == null || force)
            {
                Stat = new Stat();
            }
        }
        public int Weight {
            get => this.Stat.Weight;
            set {
                InitStat();
                if (value > 0 && value < 40)
                {
                    Stat.Weight = value;
                    OnPropertyChanged(nameof(this.Weight));
                }
            }
        }
        public DateTime Date {
            get => this.Stat.Date;
            set {
                InitStat();
                Stat.Date = DateTime.Today;
                OnPropertyChanged(nameof(this.Date));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
