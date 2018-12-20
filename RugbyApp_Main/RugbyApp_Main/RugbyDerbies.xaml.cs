using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RugbyApp_Main
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    //The addition to use TabbedPages
	public partial class RugbyDerbies : TabbedPage
    {
		public RugbyDerbies ()
		{
			InitializeComponent ();
		}
	}
}