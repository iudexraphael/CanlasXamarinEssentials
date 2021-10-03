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
    public partial class DeviceBatteryPage : ContentPage
    {
        public DeviceBatteryPage()
        {
            InitializeComponent();
            SetBackground(Battery.ChargeLevel,
               Battery.State == BatteryState.Charging);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }
        void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            SetBackground(e.ChargeLevel, e.State == BatteryState.Charging);
        }

        void SetBackground(double level, bool charging)
        {
            Color? color = null;
            var status = charging ? "Charging" : "Not Charging";

            if (level > .5f)
            {
                color = Color.Green.MultiplyAlpha(level);
            }
            else if (level > .1f)
            {
                color = Color.DarkOrange.MultiplyAlpha(1d - level);
            }
            else
            {
                color = Color.IndianRed.MultiplyAlpha(1d - level);
            }
            BackgroundColor = color.Value;
            LabelBatteryLevel.Text = status;
        }
    }
}