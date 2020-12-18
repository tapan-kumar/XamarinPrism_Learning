using Contacts.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Contacts
{
    public partial class MainPage : ContentPage
    {
       // private readonly MainpageViewModel _model;
        public MainPage()

        {
            InitializeComponent();
            BindingContext = new MainpageViewModel();
            


        }

       




        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new NewContact());
        }

    

        private async void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var content = e.Item as Contacts;
            await Navigation.PushAsync(new NewContact());
        }
       
    }
}
