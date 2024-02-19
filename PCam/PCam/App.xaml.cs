using PCam.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pestana1());
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
