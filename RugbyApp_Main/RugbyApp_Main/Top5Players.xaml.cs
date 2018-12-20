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
    //The Tabbed part for Top5Players
	public partial class Top5Players : TabbedPage
	{
		public Top5Players ()
		{
			InitializeComponent ();
		}
	}
}