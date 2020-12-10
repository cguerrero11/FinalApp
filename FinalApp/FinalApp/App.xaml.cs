using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalApp.Services;
using FinalApp.Views;
using FinalApp.Data;

namespace FinalApp
{
    public partial class App : Application
    {
        public static PlantItemManager PlantItemManager { get; private set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            PlantItemManager = new PlantItemManager(new RestService());
            MainPage = new AppShell();
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
