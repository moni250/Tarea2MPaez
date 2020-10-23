using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2MPaez
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Habilitar Navegacion
            MainPage = new NavigationPage (new MainPage());
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
