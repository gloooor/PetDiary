using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetDiary.Models
{
    public class User
    {   
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }

    }
    //    class User: INotifyPropertyChanged
    //    {
    //        private readonly ObservableCollection<Pet> _myPets = new ObservableCollection<Pet>();
    //        public readonly ReadOnlyObservableCollection<Pet> MyPublicPets;
    //        #region Public Properties
    //        public int Get_id(string firstname, string lastname)
    //        {
    //            return (int)DB.GetDB($"select top(1) Id from dbUser WHERE FirstName= '{firstname}' AND LastName='{lastname}'; ").Rows[0]["Id"];
    //        }
    //        public int Get_age(string firstname, string lastname)
    //        {
    //            return (int)DB.GetDB($" select top(1) Age from dbUser WHERE FirstName= '{firstname}' AND LastName='{lastname}'; ").Rows[0]["Age"];
    //        }

    //        public string FirstName { get; set; }
    //            public string LastName { get; set; }
    //            public int Age { get; set; }
    //            public int Id { get; set; }

    //            #endregion

    //            #region Constructor
    //            public User()
    //            {
    //                this.FirstName = "";
    //                this.LastName = "";
    //                this.Id = 0;
    //                this.Age = 0;
    //            }

    //            public User(string firstname, string lastname, int age, int id)
    //            {
    //                this.FirstName = firstname;
    //                this.LastName = lastname;
    //                this.Age = age;
    //                this.Id = id;
    //                MyPublicPets = new ReadOnlyObservableCollection<Pet>(_myPets);
    //        }
    //        public void AddPet(Pet value)
    //        {
    //            _myPets.Add(value);
    //            //RaisePropertyChanged("Sum");
    //        }
    //        //проверка на валидность, удаление из коллекции и уведомление об изменении суммы
    //        public void RemovePet(int index)
    //        {
    //            //проверка на валидность удаления из коллекции - обязанность модели
    //            if (index >= 0 && index < _myPets.Count) _myPets.RemoveAt(index);
    //           // RaisePropertyChanged("Sum");
    //        }
    //        public event PropertyChangedEventHandler PropertyChanged; //Событие, которое будет вызвано при изменении модели 
    //        public void OnPropertyChanged([CallerMemberName]string prop = "") //Метод, который скажет ViewModel, что нужно передать виду новые данные
    //        {
    //            if (PropertyChanged != null)
    //                PropertyChanged(this, new PropertyChangedEventArgs(prop));
    //        }
    //        #endregion
    //    }
}
