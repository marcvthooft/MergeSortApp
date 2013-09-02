using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Linq;
using MergeSort.BL;

namespace MergeSort.iOS
{
	public partial class TryOutScreen : UIViewController
	{
		public TryOutScreen () : base ("TryOutScreen", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			this.btnSorteer.TouchUpInside += (sender, e) => {
				int x;
				String invoer = this.txtInvoer.Text;
				String uitvoer = "";
				int [] array = invoer.Split().Select(a => int.Parse(a)).ToArray();

				BL.Algorithm.mergeSort_srt(array, 0, array.Length-1);
				for (x=0; x<array.Length; x++) {
					uitvoer = uitvoer + " " + array[x].ToString();
				}
				this.txtUitvoer.Text = uitvoer;
			};
		}
	}
}

