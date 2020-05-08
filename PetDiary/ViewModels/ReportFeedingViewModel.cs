﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class ReportFeedingViewModel : INotifyPropertyChanged
    {
        public FeedingNote FeedingNote { get; set; }
        public void InitNote(bool force = false)
        {
            if (FeedingNote == null || force)
            {
                FeedingNote = new FeedingNote();
            }
        }

        public string Date {
            get => this.FeedingNote.Date;
            set {
                InitNote();
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
                {
                    FeedingNote.Date = value;
                    OnPropertyChanged(nameof(this.Date));
                }
            }
        }

        public bool WetFood {
            get => this.FeedingNote.WetFood;
            set {
                InitNote();
                FeedingNote.WetFood = value;
                OnPropertyChanged(nameof(this.WetFood));
            }
        }
        public bool DryFood {
            get => this.FeedingNote.DryFood;
            set {
                InitNote();
                FeedingNote.DryFood = value;
                OnPropertyChanged(nameof(this.DryFood));
            }
        }

        public bool Meat {
            get => this.FeedingNote.Meat;
            set {
                InitNote();
                FeedingNote.Meat = value;
                OnPropertyChanged(nameof(this.Meat));
            }
        }

        public bool Medicines {
            get => this.FeedingNote.Medicines;
            set {
                InitNote();
                FeedingNote.Medicines = value;
                OnPropertyChanged(nameof(this.Medicines));
            }
        }

        public bool Other {
            get => this.FeedingNote.Other;
            set {
                InitNote();
                FeedingNote.Other = value;
                OnPropertyChanged(nameof(this.Other));
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