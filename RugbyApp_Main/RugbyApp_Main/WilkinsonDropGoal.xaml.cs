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
	public partial class WilkinsonDropGoal : ContentPage
	{
		public WilkinsonDropGoal ()
		{
			InitializeComponent ();
            //To create the variables for the images for WilkinsonDropGoal class
            image1();
            image2();
        }

        private void image1()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.dropgoal1.jpg";
            dropgoal1.Source = ImageSource.FromResource(FileName, assembly);

        }
        private void image2()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.dropgoal2.jpg";
            dropgoal2.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}