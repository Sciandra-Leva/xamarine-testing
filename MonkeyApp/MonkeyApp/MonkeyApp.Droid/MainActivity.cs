using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Linq;

namespace MonkeyApp.Droid
{
	[Activity (Label = "MonkeyApp.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

        MonkeysViewModel viewModel;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            viewModel = new MonkeysViewModel();

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
            var list = FindViewById<ListView>(Resource.Id.listView1);

			button.Click += async delegate 
            {
                button.Enabled = false;

                await viewModel.GetMonkeyAsync();

                list.Adapter = new ArrayAdapter<string>(this,
                    Android.Resource.Layout.SimpleListItem1,
                    Android.Resource.Id.Text1,
                    viewModel.Monkeys.Select(m => $"{m.Name} - from {m.Location}").ToArray());

                button.Enabled = true;
			};
		}
	}
}


