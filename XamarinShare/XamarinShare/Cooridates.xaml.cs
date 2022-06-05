using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinShare
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cooridates : ContentPage
    {
        public Cooridates()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            var lat1 = double.Parse(Latitude1.Text);
            var lng1 = double.Parse(Longitude1.Text);
            var lat2 = double.Parse(Latitude2.Text);
            var lng2 = double.Parse(Longitude2.Text);

            var result = Xamarin.Essentials.UnitConverters.CoordinatesToMiles(lat1, lng1, lat2, lng2);
            Results.Text = result.ToString() + " Miles";
        }
    }
}