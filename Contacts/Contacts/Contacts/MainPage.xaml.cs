using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var List = new List<Contacts>()
            {
                new Contacts
            {
                FirstName="Sawan",
            LastName="Bundelkhandi",
            CellNumber=9827109369,

            },
            new Contacts
            {
            FirstName="Tapan",
            LastName="Bundelkhandi",
            CellNumber=8103943917}};
            list.ItemsSource = List;
        }
        
    }
}
