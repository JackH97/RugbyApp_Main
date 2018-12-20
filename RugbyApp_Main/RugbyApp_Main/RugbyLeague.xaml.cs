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
	public partial class RugbyLeague : ContentPage
	{
		public RugbyLeague ()
		{
			InitializeComponent ();
            //To create the variables for the images for RugbyLeague class
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.rugbyleague1.jpg";
            rugbyleague1.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.rugbyleague2.jpg";
            rugbyleague2.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}