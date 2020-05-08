using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class ReportActivityViewModel : INotifyPropertyChanged
    {
        public ActivityNote Note { get; set; }
        public void InitNote(bool force = false)
        {
            if (Note == null || force)
            {
                Note = new ActivityNote();
            }
        }
        public string Date {
            get => this.Note.Date;
            set {
                InitNote();
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
                {
                    Note.Date = value;
                    OnPropertyChanged(nameof(this.Date));
                }
            }
        }
        public string Location {
            get => this.Note.Date;
            set {
                InitNote();
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
                {
                    Note.Location = value;
                    OnPropertyChanged(nameof(this.Location));
                }
            }
        }

        public int Hours {
            get => this.Note.Hours;
            set {
                InitNote();
                Note.Hours = value;
                OnPropertyChanged(nameof(this.Hours));
            }
        }
        public int Minutes {
            get => this.Note.Minutes;
            set {
                InitNote();
                Note.Minutes = value;
                OnPropertyChanged(nameof(this.Minutes));
            }
        }
        public int Rating {
            get => this.Note.Rating;
            set {
                InitNote();
                Note.Rating = value;
                OnPropertyChanged(nameof(this.Rating));
            }
        }

        public string Comment {
            get => this.Note.Comment;
            set {
                InitNote();
                Note.Comment = value;
                OnPropertyChanged(nameof(this.Comment));
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
