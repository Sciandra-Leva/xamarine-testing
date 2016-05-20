// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MonkeyApp.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonGetMonkeys { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel LabelMonkey { get; set; }

		[Action ("ButtonGetMonkeys_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ButtonGetMonkeys_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (ButtonGetMonkeys != null) {
				ButtonGetMonkeys.Dispose ();
				ButtonGetMonkeys = null;
			}
			if (LabelMonkey != null) {
				LabelMonkey.Dispose ();
				LabelMonkey = null;
			}
		}
	}
}
