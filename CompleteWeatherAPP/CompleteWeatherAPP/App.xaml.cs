using CompleteWeatherAPP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompleteWeatherAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CompleteWeatherPage();
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
