using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trigger
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Trigger.Data());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Trigger.Event());
            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Trigger.Property());

            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Trigger.Style());

            };

            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Trigger.MultiTrigger());

            };

        }
    }
}
