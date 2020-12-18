using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Contacts.ViewModels
{
    public class MainpageViewModel
    {
        
        private SQLiteConnection _connection;

        private ObservableCollection<Contacts> myList;
        public ObservableCollection<Contacts> MyList
        {
            get { return myList; }
            set { myList = value; }
        }
        public MainpageViewModel()
        {
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
             _connection.CreateTable<Contacts>();
            var contactlist =  _connection.Table<Contacts>().ToList();
            //yList = new ObservableCollection<Contacts>(contactlist);


            myList = new ObservableCollection<Contacts>(contactlist)
            {
                new Contacts
            {
                FirstName="Sawan",
            LastName="Bundelkhandi",
            CellNumber=9827109369,
            Email="sawanbackintown@gmail.com",
            DisplayPicture= "editedkundli.jpg"


            },

            new Contacts
            {
            FirstName="Tapan",
            LastName="Bundelkhandi",
            CellNumber=8103943917,
            Email="tapan11144@gmail.com",
            DisplayPicture="Capture.JPG"



            },
            new Contacts
            {
            FirstName="Prashant",
            LastName="Kankane",
            CellNumber=8962535288,
            Email="prashantkankane9@gmail.com",
            DisplayPicture="Image1.jpg"



            },
            new Contacts
            {
            FirstName="Piyush",
            LastName="Kankane",
            CellNumber=8962396848,
            Email="piyushkankane9@gmail.com",
            DisplayPicture="Image2.jpg"
            }
            };

            
        }

        //internal async System.Threading.Tasks.Task InitAsync()
        //{
       

        //}



    }
}
