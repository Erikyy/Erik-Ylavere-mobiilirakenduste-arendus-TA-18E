using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Lists
{
    [Activity(Label = "Listview_harjutus", Theme = "@style/AppTheme", MainLauncher = true)]
    class second_activity : ListActivity
    {
        List<Car> _items;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _items = new List<Car>()
            {
                new Car(){Manufacturer = "Toyota", Model = "AE86", Year = "1983", KW ="96"},
                new Car(){Manufacturer = "Honda", Model = "Civic EK9", Year = "1998", KW ="136"},
                new Car(){Manufacturer = "Mazda", Model = "RX7", Year = "1995", KW ="177"},
                new Car(){Manufacturer = "Lexus", Model = "LFA", Year = "2012", KW ="412"},
                new Car(){Manufacturer = "Mclaren", Model = "P1", Year = "2015", KW ="673"},
                new Car(){Manufacturer = "Koenigsegg", Model = "Regera", Year = "2017", KW ="1103"},
                new Car(){Manufacturer = "Bugatti", Model = "Chiron", Year = "2018", KW ="1103"},
                new Car(){Manufacturer = "Mercedes", Model = "AMG SLS", Year = "2014", KW ="420"},
                new Car(){Manufacturer = "BMW", Model = "i8", Year = "2019", KW ="260"},
                new Car(){Manufacturer = "Porsche", Model = "911", Year = "1973", KW ="170"},
                new Car(){Manufacturer = "Ferrari", Model = "458 Italia", Year = "2013", KW ="431"},

            };

            ListAdapter = new second_adapter(this, _items);

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                var item = _items[args.Position];

                Toast.MakeText(Application, item.Model, ToastLength.Short).Show();
            };
        }

    }
}