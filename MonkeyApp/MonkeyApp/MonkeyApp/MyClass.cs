using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MonkeyApp
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

        public async Task GetMonkeyAsync()
        {
            try
            {
                var client = new HttpClient();
                var json = await client.GetStringAsync("http://montemagno.com/monkeys.json");

                var items = JsonConvert.DeserializeObject<List<Monkey>>(json);

                foreach (var item in items)
                {
                    Monkeys.Add(item);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }


}

