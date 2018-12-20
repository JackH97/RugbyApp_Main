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
	public partial class FirstWorldCupFinal : ContentPage
	{
		public FirstWorldCupFinal ()
		{
			InitializeComponent ();
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.firstfinal1.jpg";
            firstfinal1.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.firstfinal2.jpg";
            firstfinal2.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}