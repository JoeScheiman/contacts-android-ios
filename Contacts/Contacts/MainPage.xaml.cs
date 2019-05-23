using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Classes;
using Xamarin.Forms;
using SQLite;

namespace Contacts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = nameEntry.Text,
                Lastname = LastnameEntry.Text,
                Email = emailEntry.Text,
                PhoneNumber = phoneNumberEntry.Text,
                Address = addressEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath)) //Idisposable
            {
                //This syntax will auto-close the connection to SQL database
                conn.CreateTable<Contact>();
                int rowsAdded = conn.Insert(contact);
            }
        }
    }
}
