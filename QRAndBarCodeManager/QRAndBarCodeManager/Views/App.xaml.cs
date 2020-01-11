using QRAndBarCodeManager.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRAndBarCodeManager
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<INavigationService, NavigationService>();
            DependencyService.Register<IAlertService, AlertService>();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
