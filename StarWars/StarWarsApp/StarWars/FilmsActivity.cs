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
using StarWarsApp.Core;
using static Android.Widget.AdapterView;

namespace StarWarsApp.StarWars
{
    [Activity(Label = "FilmsActivity")]
    public class FilmsActivity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Film_Layout);
            // Create your application here

              var StarWarsbtn1 = FindViewById<Button>(Resource.Id.btnStarWars);

        }
    }
}