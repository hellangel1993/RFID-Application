using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RFID_Applications.Services;
using RFID_Applications.Views;

namespace RFID_Applications
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
