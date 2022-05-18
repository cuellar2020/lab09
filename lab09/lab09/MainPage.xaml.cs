using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            item01.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new Views.TapDemo());
            };

            item02.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new Views.PinchDemo());
            };

            item03.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new Views.PanDemo());
            };

            item04.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new Views.SwipeDemo());
            };
        }
    }
}