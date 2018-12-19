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
	public partial class Pro14 : ContentPage
	{
		public Pro14 ()
		{
			InitializeComponent ();
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.Pro141.jpg";
            Pro141.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.Pro142.jpg";
            Pro142.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}