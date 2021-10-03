using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CanlasXamarinEssentials
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AccelerometerPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Accelerometerpage());
        }

        private async void BarometerPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BarometerPage());
        }
        private async void MagnetometerPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MagnetometerPage());
        }
        private async void ConnectivityPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnectivityPage());
        }

        private async void DeviceInfoPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeviceInfoPage());
        }
        private async void DeviceBattery_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeviceBatteryPage());
        }

        private async void GeolocationPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeolocationPage());
        }

        private async void GeocodingPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeocodingPage());
        }
    }
}
