using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Services;

namespace XamarinApp
{
    public partial class App : Application
    {
        public static DatabaseService Database { get; private set; }
        public App ()
        {
            InitializeComponent();
            Database = new DatabaseService();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

