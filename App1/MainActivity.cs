using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
namespace App1
{
    [Activity(Label = "App1", MainLauncher = false, Icon = "@drawable/icon", Theme ="@style/MyTheme")]
	public class MainActivity : AppCompatActivity
    {
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Image Slider";
            var viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            ImageAdapter adapter = new ImageAdapter(this);
            viewPager.Adapter = adapter;
        }

		protected override void OnResume()
		{
			Spinner oSpinner = FindViewById<Spinner>(Resource.Id.spinner1);
			if (oSpinner.Adapter == null)
			{
				oSpinner.Adapter = new SimpleAdapter(this, new string[] { "One", "Two", "Three" });
			}

			// *** Tutorial Activity DLL ***
			// call to show the tutorial using the images in Resources\drawable folder 
			// (or Resources\drawable-it folder if language of mobile is italian)
			// 
			// Example of the call
			// TutorialActivity.StartActivity(...);
			//
			// the ... is an array of resource to show in tutorial activity accordingly to language. If english
			// the Resources\drawable\Tutorial01.png, Resources\drawable\Tutorial02.png, ..., Resources\drawable\Tutorial04.png
			// will be shown, if italian the Resources\drawable-it\Tutorial01.png, Resources\drawable-it\Tutorial02.png, ...
			//
			// KEEP IN MIND THE TutorialActivity class has to be in a separate DLL (feel free to create the project)

			base.OnResume();
		}
	}
}

