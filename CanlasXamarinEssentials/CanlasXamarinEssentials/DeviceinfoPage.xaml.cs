using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CanlasXamarinEssentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceInfoPage : ContentPage
    {
        public DeviceInfoPage()
        {
            InitializeComponent();

            var device = DeviceInfo.Model;


            var manufacturer = DeviceInfo.Manufacturer;


            var deviceName = DeviceInfo.Name;


            var version = DeviceInfo.VersionString;


            var platform = DeviceInfo.Platform;

            if (platform == DevicePlatform.Android)
            {

            }

            var idiom = DeviceInfo.Idiom;


            var deviceType = DeviceInfo.DeviceType;

            LabelDeviceInfo.Text = $"{deviceName} {manufacturer}  {version} {platform}";
        }
    }
}