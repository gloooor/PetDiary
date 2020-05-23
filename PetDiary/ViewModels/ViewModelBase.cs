using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetDiary.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
           
                if (PropertyChanged != null)
                try
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
            catch(System.StackOverflowException ex)
            {
                MessageBox.Show("Something wrong, try again");
            }
        }
    }
}
