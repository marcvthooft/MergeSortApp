// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MergeSort.iOS
{
	[Register ("TryOutScreen")]
	partial class TryOutScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnSorteer { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtInvoer { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtUitvoer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnSorteer != null) {
				btnSorteer.Dispose ();
				btnSorteer = null;
			}

			if (txtInvoer != null) {
				txtInvoer.Dispose ();
				txtInvoer = null;
			}

			if (txtUitvoer != null) {
				txtUitvoer.Dispose ();
				txtUitvoer = null;
			}
		}
	}
}
