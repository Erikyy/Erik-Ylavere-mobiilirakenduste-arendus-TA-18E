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

namespace App1
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);

            Button divide = FindViewById<Button>(Resource.Id.divide);
            divide.Click += DivideClick;

            Button plus = FindViewById<Button>(Resource.Id.plus);
            plus.Click += PlusClick;

            Button minus = FindViewById<Button>(Resource.Id.minus);
            minus.Click += PlusClick;

            Button multiply = FindViewById<Button>(Resource.Id.multiply);
            multiply.Click += MultiplyClick;

            Button calculate = FindViewById<Button>(Resource.Id.calculate);
            calculate.Click += CalculateClick;
            
        }

       private void DivideClick(object sender, EventArgs eventArgs)
        {

        }
        private void PlusClick(object sender, EventArgs eventArgs)
        {

        }
        private void MinusClick(object sender, EventArgs eventArgs)
        {

        }
        private void MultiplyClick(object sender, EventArgs eventArgs)
        {

        }
        private void CalculateClick(object sender, EventArgs eventArgs)
        {

        }
    }
}