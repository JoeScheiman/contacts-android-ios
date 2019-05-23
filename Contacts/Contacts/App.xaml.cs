using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    public partial class App : Application
    {
        public static string FilePath;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsPage()); //This will manage the navigation, first page is ContactsPage
        }

        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsPage());

            FilePath = filePath;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
