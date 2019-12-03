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
using Newtonsoft.Json;

namespace StarWarsApp
{
    [Activity(Label = "movieDetailsActivity")]
    public class movieDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.movie_details);

            var movieNameTextViev = FindViewById<TextView>(Resource.Id.movieTextField);

            var movieDetails = JsonConvert.DeserializeObject<Core.Models.MoviesDetails>(Intent.GetStringExtra("movieDetails"));
            movieNameTextViev.Text = movieDetails.Title;

            
        }
    }
}