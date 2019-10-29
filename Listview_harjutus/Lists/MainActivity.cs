using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace Lists
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : ListActivity
    {
        List<WeatherInfo> _items;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //var items = new string[] { "Monday", "Tuesday", "Wednesday", "Thusrday", "Friday", "Saturday", "Sunaday", "Monday", "Tuesday", "Wednesday", "Thusrday", "Friday", "Saturday", "Sunaday" };
            _items = new List<WeatherInfo>()
            {
                new WeatherInfo(){Name = "Monday", Temperature = "12°C", WindSpeed = "5 m/s"},
                new WeatherInfo(){Name = "Tuesday", Temperature = "15°C", WindSpeed = "2 m/s"},
                new WeatherInfo(){Name = "Wednesday", Temperature = "11°C", WindSpeed = "3 m/s"},
                new WeatherInfo(){Name = "Thursday", Temperature = "12°C", WindSpeed = "5 m/s"},
                new WeatherInfo(){Name = "Friday", Temperature = "17°C", WindSpeed = "1 m/s"},
                new WeatherInfo(){Name = "Saturday", Temperature = "20°C", WindSpeed = "10 m/s"},
                new WeatherInfo(){Name = "Sunday", Temperature = "15°C", WindSpeed = "15 m/s"}
            };

            ListAdapter = new BasicAdapter(this, _items);

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                var item = _items[args.Position];

                Toast.MakeText(Application, item.Name, ToastLength.Short).Show();
            };
        }
    }
}