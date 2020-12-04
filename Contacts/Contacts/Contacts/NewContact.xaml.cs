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
      
        private Contacts content;

        public NewContact()
        {
            InitializeComponent();
        }

        public NewContact(Contacts content)
        {
            this.content = content;
        }
    }
}