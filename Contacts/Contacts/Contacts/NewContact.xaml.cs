using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewContact : ContentPage
    {
      
        public Contacts content= new Contacts();
        

        public NewContact()
        {
            InitializeComponent();
            //this.content = content;
            BindingContext = new ViewModels.NewContactViewModel();
            
            
        }

        

       

       
    }
}