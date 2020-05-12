﻿using PetDiary.Models;
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
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public User User { 
            get => _user; 
            set {
                _user = value;
                OnPropertyChanged(nameof(User));
            } 
        }

        private User _user;
        public ObservableCollection<User> UserList {
            get => _userList;
            set {
                _userList = value;
                OnPropertyChanged(nameof(UserList));
            }
        }

        private ObservableCollection<User> _userList;

        User _selectedUser;

        public User SelectedUser {
            get {
                return _selectedUser;
            }

            set {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }


        public UserViewModel()
        {
            UserList = new ObservableCollection<User>();
        }


        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
