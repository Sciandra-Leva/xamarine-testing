using System;

using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;

namespace MyMonkeyApp
{
	public class App : Application
	{
		public class Monkey
		{
			public string Name { get; set; }
			public string Location { get; set; }
			public string Details { get; set; }
			public string Image { get; set; }
			public int Population { get; set; }
		}

		public class MonkeysViewModel
		{
			public ObservableCollection<Monkey> Monkeys { get; } = new ObservableCollection<Monkey>();

			public async Task GetMonkeysAsync()
			{
				try 
				{
					var client = HttpClient();
					var json = await client.GetStringAsync("http://montemagno.com/monkeys.json");

					var items = JsonConvert.DeserializeObject<List<Monkey>>(json);
					foreach (var item in items) {
						Monkeys.Add(item);
					}
				} 
				catch (Exception ex)
				{
					Debug.WriteLine(ex);
				}
			}
		}

		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
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

