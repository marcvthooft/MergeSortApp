using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MergeSort.iOS
{
	public partial class HomeScreen : UIViewController
	{
		TryOutScreen tryOutScreen;
		CodeScreen codeScreen;
		ExplainScreen explainScreen;

		public HomeScreen () : base ("HomeScreen", null)
		{
			this.Title = "MergeSort";
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
			
			this.btnTryOut.TouchUpInside += (sender, e) => {
				if (this.tryOutScreen == null) {
					this.tryOutScreen = new TryOutScreen ();
				}
				this.NavigationController.PushViewController(this.tryOutScreen, true);
			};
			this.btnCode.TouchUpInside += (sender, e) => {
				if (this.codeScreen == null) {
					this.codeScreen = new CodeScreen ();
				}
				this.NavigationController.PushViewController (this.codeScreen, true);
			};
			this.btnUitleg.TouchUpInside += (sender, e) => {
				if (this.explainScreen == null) {
					this.explainScreen = new ExplainScreen ();
				}
				this.NavigationController.PushViewController (this.explainScreen, true);
			};
		}
	}
}

