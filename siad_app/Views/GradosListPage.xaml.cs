using System;
using System.Collections.Generic;
using Xamarin.Forms;
using siad_app.Models;


namespace siad_app.Views
{
    public partial class GradosListPage : ContentPage
    {
        public GradosListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            lstGrados.ItemsSource = await App.GradosDb.GetGradosAsync();


        }

        async void OnGradosAdd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GradoPage
            {
                BindingContext = new Grados()
            });

        }

        async void OnGradoSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new GradoPage
                {
                    BindingContext = e.SelectedItem as Grados
                });
            }
        }
    }
}
