﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace fghfght6t6hy
{
	[Activity (Label = "fghfght6t6hy", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;
		int a = 3;
		int b = 5;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);





			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}


