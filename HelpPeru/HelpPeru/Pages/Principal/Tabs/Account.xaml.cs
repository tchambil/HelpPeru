using HelpPeru.Pages.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelpPeru.Pages.Principal.Tabs
{ 
	public partial class Account : ContentPage
	{
		public Account ()
		{
			InitializeComponent ();
		}
        async void OnRegister(object sender, EventArgs e)
        {
            App.Current.MainPage = new Register();

        }
        async void OnLogin(object sender, EventArgs e)
        {
            App.Current.MainPage = new Register();
        }
    }
}
