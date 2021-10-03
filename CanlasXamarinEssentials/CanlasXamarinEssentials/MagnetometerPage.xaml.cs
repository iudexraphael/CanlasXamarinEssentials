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
    public partial class MagnetometerPage : ContentPage
    {
        public MagnetometerPage()
        {
            InitializeComponent();

            try
            {
                Magnetometer.ReadingChanged += ReadingChanged;
                Magnetometer.Start(SensorSpeed.UI);
            }
            catch (FeatureNotSupportedException fnsex)
            {
                lblMeasure.Text = fnsex.Message;
            }
            catch (Exception ex)
            {
                lblMeasure.Text = ex.Message;
            }

        }
        void ReadingChanged(object sender, MagnetometerChangedEventArgs e)
        {
            var data = e.Reading;
            lblMeasure.Text = $"Reading: X: {data.MagneticField.X}, Y: {data.MagneticField.Y}, Z:{data.MagneticField}";
        }
    }
}