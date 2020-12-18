using Android.App;
using Android.Content;

using Android.Runtime;
using Android.Views;
using Android.Widget;
using Contacts.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDB))]
namespace Contacts.Droid
{
    public class SQLiteDB : ISQLiteDb
    {
     
        

        SQLiteConnection ISQLiteDb.GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQlite.db3");
            return new SQLiteConnection(path);
        }
    }
}