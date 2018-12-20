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
	public partial class SouthAfrica : ContentPage
	{
		public SouthAfrica ()
		{
			InitializeComponent ();
            //To create the variables for the images for JapanWin class
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.southafrica1.png";
            southafrica1.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.southafrica2.jpg";
            southafrica2.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}