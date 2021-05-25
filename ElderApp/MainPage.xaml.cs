using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElderApp
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {
                Frame frame = (Frame)sender;
                TapGestureRecognizer tapGesture = (TapGestureRecognizer)frame.GestureRecognizers[0];
                App.Current.MainPage = new login();
                await DisplayAlert("Info", "Registra't a l'aplicació", "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }

        private async void tapped(object sender, EventArgs e)
        {
            try
            {
                Frame frame = (Frame)sender;
                TapGestureRecognizer tapGesture = (TapGestureRecognizer)frame.GestureRecognizers[0];
                App.Current.MainPage = new login2();
                await DisplayAlert("Info", "Log in a l'aplicació", "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }
    }
}
