using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App15.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace App15.ViewModels
{
    public class Profile_button_example : INotifyPropertyChanged
    {
        private ProfileModel _pofileModel;
        private string _message;

        public ProfileModel ProfileModel
        {
            get { return _pofileModel;}
            set
            {
                _pofileModel = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public Command SaveCommand
        {
            get
            {
                return new Command(() =>
                {
                    Message = "Profile name: " + ProfileModel.Name + ", " + ProfileModel.Age + "was succesfully saved!";
                });
            }
        }

        public Profile_button_example()
        {
            ProfileModel = new ProfileModel
            {
                Name = "George",
                Age = 23
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
