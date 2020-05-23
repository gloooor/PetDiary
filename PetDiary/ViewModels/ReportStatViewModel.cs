using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class ReportStatViewModel : ViewModelBase, IDataErrorInfo
    {
        public Stat Stat { get; set; }
        public void InitStat(bool force = false)
        {
            if (Stat == null || force)
            {
                Stat = new Stat();
            }
        }
        #region Properties
        public double Weight {
            get => this.Stat.Weight;
            set {
                InitStat();
                if (value > 0.0 && value < 40.0)
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
        #endregion
        #region Validation
        public string this[string columnName] {
            get {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Weight":
                        if ((Stat.Weight > 20.0) || (Stat.Weight < 0.0))
                        {
                            error = "The login must be between 8 and 20 characters long";
                        }
                        break;

                }
                return error;
            }
        }
        public string Error {
            get { throw new NotImplementedException(); }
        }
        #endregion
    }
}
