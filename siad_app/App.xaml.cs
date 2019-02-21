using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using siad_app.Views;
using siad_app.Services;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace siad_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IApiService, ApiService>();


            MainPage = new NavigationPage(new TutoresList());
            //MainPage = new MainPage();
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
