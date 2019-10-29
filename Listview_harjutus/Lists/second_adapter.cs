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
    class second_adapter : BaseAdapter<Car>
    {
        List<Car> _items;
        Activity _context;


        public second_adapter(Activity context, List<Car> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override Car this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            View view = convertView;
            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.second_layout, null);
            }
            view.FindViewById<TextView>(Resource.Id.text_View4).Text = item.Manufacturer;
            view.FindViewById<TextView>(Resource.Id.text_View5).Text = item.Model;
            view.FindViewById<TextView>(Resource.Id.text_View6).Text = item.Year;
            view.FindViewById<TextView>(Resource.Id.text_View7).Text = item.KW;

            return view;

        }
    }
}