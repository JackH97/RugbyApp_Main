﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RugbyApp_Main
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    //TabbedPage for UnionVsLeague
	public partial class UnionVsLeague : TabbedPage
    {
		public UnionVsLeague ()
		{
			InitializeComponent ();
		}
	}
}