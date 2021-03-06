﻿using System;
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
            //To create the variables for the images for JapanWin class
            BackImage();
        }

        private void BackImage()
        {
            var assembly = typeof(MainPage);
            string FileName = "RugbyApp_Main.Assets.HomePic.jpg";
            backgroundPic.Source = ImageSource.FromResource(FileName, assembly);

        }

        //The Buttons setup to go to different pages
        async void btnTop5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Top5Players());
        }

        async void btnTeams_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RugbyTeams());
        }

        async void btnTournaments_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tournaments());
        }

        async void btnDerbies_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RugbyDerbies());
        }

        async void btnMoments_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Top5RugbyMoments());
        }

        async void btnUnionVsLeague_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UnionVsLeague());
        }
    }
}
