using HelpPeru.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelpPeru.Pages.Principal
{ 
	public partial class Principal : BaseTabbedPage
    {
		public Principal ()
		{
			InitializeComponent ();
            NavigationPage.SetBackButtonTitle(this, "");
        }
	}
}
