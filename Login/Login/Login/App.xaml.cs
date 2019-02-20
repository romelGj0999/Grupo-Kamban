using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login.Model;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Login
{
    public partial class App : Application
    {
        public App(String filename)
        {
            InitializeComponent();
            UserRepository.Inicializador(filename);

            MainPage = new Login.Principal();
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
