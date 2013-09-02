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
	[Register ("HomeScreen")]
	partial class HomeScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnCode { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnTryOut { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnUitleg { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnTryOut != null) {
				btnTryOut.Dispose ();
				btnTryOut = null;
			}

			if (btnCode != null) {
				btnCode.Dispose ();
				btnCode = null;
			}

			if (btnUitleg != null) {
				btnUitleg.Dispose ();
				btnUitleg = null;
			}
		}
	}
}
