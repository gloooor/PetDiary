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
    public class AddPetViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
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
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
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
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
                {
                    Pet.Type = value;
                    OnPropertyChanged(nameof(this.Type));
                }
            }
        }
        public int Age {
            get => this.Pet.Age;
            set {
                InitPet();
                if (value == 0)
                    throw new ArgumentException("Выберите имя");
                else
                {
                    Pet.Age = value;
                    OnPropertyChanged(nameof(this.Age));
                }
            }
        }

        public string Sex {
            get => this.Pet.Sex;
            set {
                InitPet();
                if (value == null)
                    throw new ArgumentException("Выберите имя");
                else
                {
                    Pet.Sex = value;
                    OnPropertyChanged(nameof(this.Sex));
                }
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
                if (value == null)
                    throw new ArgumentException("Выберите дату");
                else
                {
                    Pet.DateOfBirth = value;
                    OnPropertyChanged(nameof(this.DateOfBirth));
                }
            }
        }


        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
