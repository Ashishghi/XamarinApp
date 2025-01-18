using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using XamarinApp.Model;

namespace XamarinApp.View
{	
	public partial class PersonPage : ContentPage
	{
        private Person _person;

        public PersonPage (Person person)
		{
            try
            {
                InitializeComponent();
                _person = person;
                BindingContext = _person;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            _person.Name = NameEntry.Text;
            _person.Age = int.Parse(AgeEntry.Text);
            await App.Database.SavePersonAsync(_person);
            await Navigation.PopAsync();
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            if (_person.Id != 0)
            {
                await App.Database.DeletePersonAsync(_person);
            }
            await Navigation.PopAsync();
        }
    }
}

