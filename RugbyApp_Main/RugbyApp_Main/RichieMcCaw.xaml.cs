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
	public partial class RichieMcCaw : ContentPage
	{
		public RichieMcCaw ()
		{
			InitializeComponent ();
            //To create the variables for the images for JapanWin class
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.richiemccaw1.jpg";
            richiemccaw1.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.richiemccaw2.jpg";
            richiemccaw2.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}