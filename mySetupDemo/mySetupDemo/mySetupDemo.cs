﻿using System;

using Xamarin.Forms;

namespace mySetupDemo
{
	public class App : Application
	{
		public App ()
		{
			Button btn = new Button ();
			btn.Text = "Testing";

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						btn
					}
				}
			};

			btn.Clicked += (object sender, EventArgs e) => {
				btn.Text = "Clicked!";
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

