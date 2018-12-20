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
    //To be able to use TabbedPages
	public partial class RugbyTeams : TabbedPage
    {
		public RugbyTeams ()
		{
			InitializeComponent ();
		}
	}
}