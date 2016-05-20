using System;

using UIKit;

namespace MonkeyApp.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        
        MonkeysViewModel viewModel = new MonkeysViewModel();
        async partial void ButtonGetMonkeys_TouchUpInside(UIButton sender)
        {
            await viewModel.GetMonkeyAsync();

            LabelMonkey.Text = viewModel?.Monkeys?[0].Name ?? "no monkey";

        }
    }
}

