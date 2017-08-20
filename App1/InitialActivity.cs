using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Content.PM;
using System.Collections.Generic;

namespace App1
{
    
	[Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
	public class InitialActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
		}

		protected override void OnStart()
		{
			base.OnStart();

			StartActivity(typeof(MainActivity));
		}

		/// <summary>
		/// Perform any final cleanup before an activity is destroyed.
		/// </summary>
		protected override void OnDestroy()
		{
			// Call base method
			base.OnDestroy();
		}
	}
}
