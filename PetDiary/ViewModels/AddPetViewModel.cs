using PetDiary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.ViewModels
{
    public class AddPetViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Properties
        public Pet Pet { get; set; }
        public void InitPet(bool force = false)
        {
            if (Pet == null || force)
            {
                Pet = new Pet();
            }
        }
        public string Name {
            get => Pet.Name;
            set {
                InitPet();
                if (value != "")
                {
                    Pet.Name = value;
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }
        public string Breed {
            get => this.Pet.Breed;
            set {
                InitPet();
                if (value != "")
                {
                    Pet.Breed = value;
                    OnPropertyChanged(nameof(this.Breed));
                }
            }
        }

        public string Type {
            get => this.Pet.Type;
            set {
                InitPet();
                Pet.Type = value;
                OnPropertyChanged(nameof(this.Type));

            }
        }
        public int Age {
            get => this.Pet.Age;
            set {
                InitPet();
                if(value>0 && value<20)
                Pet.Age = value;
                OnPropertyChanged(nameof(this.Age));

            }
        }

        public string Sex {
            get => this.Pet.Sex;
            set {
                InitPet();
                Pet.Sex = value;
                OnPropertyChanged(nameof(this.Sex));
            }
        }

        public bool Desexed {
            get => this.Pet.Desexed;
            set {
                InitPet();
                Pet.Desexed = value;
                OnPropertyChanged(nameof(this.Desexed));

            }
        }

        public bool Insured {
            get => this.Pet.Insured;
            set {
                InitPet();
                Pet.Insured = value;
                OnPropertyChanged(nameof(this.Insured));
            }
        }

        public string DateOfBirth {
            get => this.Pet.DateOfBirth;
            set {
                InitPet();
                if (value != "")
                {
                    Pet.DateOfBirth = value;
                    OnPropertyChanged(nameof(this.DateOfBirth));
                }
            }
        }
        #endregion
        #region Validation
        public string this[string columnName] {
            get {
                string error = String.Empty;
                switch (columnName)
                {
                    case "DateOfBirth":
                        if (Pet.DateOfBirth == "")
                        {
                            error = "Pick a date";
                        }
                        break;
                    case "Name":
                        if ((Pet.Name.Length < 3)  || (Pet.Name.Length > 16))
                        {
                            error = "Enter name";
                        }
                        break;

                    case "Breed":
                        if ((Pet.Breed.Length < 3) || (Pet.Breed.Length > 16))
                        {
                            error = "Enter breed";
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
