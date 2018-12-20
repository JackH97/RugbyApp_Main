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
	public partial class EuroRugbyChampionsCup : ContentPage
	{
		public EuroRugbyChampionsCup ()
		{
			InitializeComponent ();
            //To create the variables for the images for EuroRugbyChampionsCup class
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.eurochampcup1.jpg";
            eurochampcup1.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.eurochampcup2.jpg";
            eurochampcup2.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}