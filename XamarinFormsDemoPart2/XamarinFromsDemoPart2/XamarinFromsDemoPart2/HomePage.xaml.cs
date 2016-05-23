using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFromsDemoPart2
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name = "Lorenzo",
                    Age = 25
                },
                new Person
                {
                    Name = "Paolo",
                    Age = 22
                },
                new Person
                {
                    Name = "Carlo",
                    Age = 28
                },
                new Person
                {
                    Name = "Marco",
                    Age = 12
                },
            };

        }
    }
}
