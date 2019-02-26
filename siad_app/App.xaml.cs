using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using siad_app.Views;
using siad_app.Services;
using siad_app.Data;
using System.IO;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace siad_app
{
    public partial class App : Application
    {
        static GradosDatabase dbGrados;

        public App()
        {
            //InitializeComponent();

            DependencyService.Register<IApiService, ApiService>();

            var nav = new NavigationPage(new GradosListPage());


            MainPage = nav;

            //MainPage = new NavigationPage(new TutoresList());
            //MainPage = new MainPage();
        }

        public static GradosDatabase GradosDb
        {
            get
            {
                if(dbGrados == null)
                {
                    dbGrados = new GradosDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GradosSQLite.db3"));
                }

                return dbGrados;
            }
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
