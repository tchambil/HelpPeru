using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace HelpPeru.Pages.Principal.Tabs
{
	 
	public partial class PageMaps : ContentPage
	{
		public PageMaps ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MyMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-12.0463731, -77.042754), Distance.FromKilometers(1000)));
            var pin = new Pin
            {
                Position = new Position(-12.0463731, - 77.042754),
                Label="Position 1",
                Address = "Address 1"
            };
            MyMaps.Pins.Add(pin);
        }
    }
}
