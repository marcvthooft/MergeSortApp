using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MergeSort.Android
{
	[Activity (Label = "MergeSort.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our buttons from the layout resource,
			// and attach events to it
			Button btnTryOut = FindViewById<Button> (Resource.Id.btnTryOut);
			Button btnCode = FindViewById<Button> (Resource.Id.btnCode);
			Button btnExplain = FindViewById<Button> (Resource.Id.btnUitleg);

			btnTryOut.Click += delegate {
				StartActivity(typeof(TryOutActivity));
			};
			btnCode.Click += delegate {
				StartActivity(typeof(CodeActivity));
			};
			btnExplain.Click += delegate {
				StartActivity(typeof(ExplainActivity));
			};
		}
	}
}


