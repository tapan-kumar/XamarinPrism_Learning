using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Contacts.ViewModels
{
     public class NewContactViewModel  : BaseViewModel
    {

        public ICommand SaveCommand;

        public NewContactViewModel()
        {
            SaveCommand = new Command(SaveCommandHandler);
        }

        private void SaveCommandHandler(object obj)
        {
            

        }

        
        private string _firstName;
        private int _id;

        private string _email;

        private string _cellNumber;

        private string _lastName;


        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                this._firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        public string CellNumber
        {
            get
            {
                return _cellNumber;
            }
            set
            {
                this._cellNumber = value;
                OnPropertyChanged(nameof(CellNumber));
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                this._email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
    }
}
