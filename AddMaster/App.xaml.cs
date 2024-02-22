using System;
using Xamarin.Forms;
using AddMaster.View;
using Xamarin.Forms.Xaml;

namespace AddMaster
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AddPage();
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
