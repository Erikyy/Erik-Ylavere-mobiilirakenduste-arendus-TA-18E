using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using StarWarsApp.Core;
using System;
using Android.Content;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;





namespace StarWarsApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            AppCenter.Start("e06818e6-9737-4bdd-861d-df9ab059fbc4",
                   typeof(Analytics), typeof(Crashes));
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var PeopleBtn = FindViewById<Button>(Resource.Id.PeopleButton);
            var PlanetsBtn = FindViewById<Button>(Resource.Id.PlanetsButton);
            var StarshipsBtn = FindViewById<Button>(Resource.Id.StarshipsButton);

            PeopleBtn.Click += PeopleBtn_Click;
            PlanetsBtn.Click += PlanetsBtn_Click;
            StarshipsBtn.Click += StarshipsBtn_Click;

        }

        private void PeopleBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(People_Activity));

            this.StartActivity(intent);
        }

        private void PlanetsBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Planets_Activity));

            this.StartActivity(intent);
        }
        private void StarshipsBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Starships_Activity));

            this.StartActivity(intent);
        }
    }
}