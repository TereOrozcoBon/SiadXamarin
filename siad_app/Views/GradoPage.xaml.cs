 using System;
using System.Collections.Generic;
using Xamarin.Forms;
using siad_app.Models;
using siad_app.Services;

namespace siad_app.Views
{
    public partial class GradoPage : ContentPage
    {
        public GradoPage()
        {
            InitializeComponent();
        }

        private async void OnSave_Clicked(object sender, EventArgs e)
        {
            var grado = (Grados)BindingContext;
            await App.GradosDb.SaveGradoASync(grado);
            await Navigation.PopAsync();
        }

        private async void OnDelete_Clicked(object sender, EventArgs e)
        {
            var grado = (Grados)BindingContext;
            await App.GradosDb.DeleteGradosAsync(grado);
            await Navigation.PopAsync();
        }

        private async void OnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void OnSpeak_Clicked(object sender, EventArgs e)
        {
            var grado = (Grados)BindingContext;

            DependencyService.Get<ITextToSpeech>().Speak(grado.Tipo + " en " + grado.Nombre);
        }


    }
}
