using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Model;
using XamarinApp.View;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            PeopleListView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        private async void OnAddPersonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PersonPage(new Person()));
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var person = (Person)e.Item;
            await Navigation.PushAsync(new PersonPage(person));
        }
    }
}

