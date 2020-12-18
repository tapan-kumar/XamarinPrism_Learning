using Xamarin.Forms;
using SQLite;
using System.ComponentModel;

namespace Contacts
{
    public class Contacts 
    {
        

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CellNumber { get; set; }
        public string DisplayPicture { get; set; }

        public string Email { get; set; }

        
    }
}
