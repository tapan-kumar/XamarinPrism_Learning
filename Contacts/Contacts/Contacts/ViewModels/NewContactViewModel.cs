using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.ViewModels
{
     public class NewContactViewModel  : BaseViewModel
    {
        private string _firstName;
        private int _id;

        private string _email;

        private long _cellNumber;

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
        public long CellNumber
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
