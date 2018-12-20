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
    //TabbedPage for Top5RugbyMoments
	public partial class Top5RugbyMoments : TabbedPage
    {
		public Top5RugbyMoments ()
		{
			InitializeComponent ();
		}
	}
}