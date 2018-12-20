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
	public partial class EnglandVsWales : ContentPage
	{
		public EnglandVsWales ()
		{
			InitializeComponent ();
            //To create the variables for the images for EnglandVsWales class
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.englandvswales1.jpg";
            englandvswales1.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.englandvswales2.jpg";
            englandvswales2.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}