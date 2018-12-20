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
	public partial class RugbyWorldCup1995 : ContentPage
	{
		public RugbyWorldCup1995 ()
		{
			InitializeComponent ();
            //To create the variables for the images for RugbyWorldCup1995 class
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.Rugby951.jpg";
            Rugby951.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.Rugby952.jpg";
            Rugby952.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}