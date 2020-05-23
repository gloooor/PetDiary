using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class ReportActivityViewModel : ViewModelBase
    {
        public ActivityNote Note { get; set; }
        public void InitNote(bool force = false)
        {
            if (Note == null || force)
            {
                Note = new ActivityNote();
            }
        }
        #region Properties
        public string Date {
            get => this.Note.Date;
            set {
                InitNote();
                Note.Date = value;
                OnPropertyChanged(nameof(this.Date));
            }
        }
        public string Color {
            get => this.Note.Color;
            set {
                InitNote();
                Note.Color = value;
                OnPropertyChanged(nameof(this.Color));
            }
        }
        public string Location {
            get => this.Note.Location;
            set {
                InitNote();
                Note.Location = value;
                OnPropertyChanged(nameof(this.Location));
            }
        }

        public int Hours {
            get => this.Note.Hours;
            set {
                InitNote();
                if (value < 23)
                {
                    Note.Hours = value;
                    OnPropertyChanged(nameof(this.Hours));
                }
            }
        }
        public int Minutes {
            get => this.Note.Minutes;
            set {
                InitNote();
                if (value < 59)
                {
                    Note.Minutes = value;
                    OnPropertyChanged(nameof(this.Minutes));
                }
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
        #endregion

    }
}
