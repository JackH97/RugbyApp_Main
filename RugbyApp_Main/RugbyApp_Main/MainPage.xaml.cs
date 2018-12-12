using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RugbyApp_Main
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackImage();
        }

        private void BackImage()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.HomePic.jpg";
            backgroundPic.Source = ImageSource.FromResource(FileName, assembly);

        }
    }
}
