using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MergeSort.BL;

namespace MergeSort.Android
{
	[Activity (Label = "TryOutActivity")]			
	public class TryOutActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.TryOut);

			Button btnSort = FindViewById<Button> (Resource.Id.btnSort);

			btnSort.Click += delegate {
				var txtInvoer = FindViewById<EditText> (Resource.Id.txtInvoer);
				var txtUitvoer = FindViewById<EditText> (Resource.Id.txtUitvoer);
				int x;
				String invoer = txtInvoer.Text;
				String uitvoer = "";

				int [] array = invoer.Split().Select(a => int.Parse(a)).ToArray();

				BL.Algorithm.mergeSort_srt(array, 0, array.Length-1);
				for (x=0; x<array.Length; x++) {
					uitvoer = uitvoer + " " + array[x].ToString();
				}
				txtUitvoer.Text = uitvoer;
			};
		}
	}
}

