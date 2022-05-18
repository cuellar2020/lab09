using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using lab09.Views;
using lab09;
namespace lab09
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
