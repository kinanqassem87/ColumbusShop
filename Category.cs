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

namespace ColumbusShop
{
    [Activity(Label = "Category")]
    class Category : Activity
    {
        List<TableItem> tableItems;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Category);
            GridView grid1 = FindViewById<GridView>(Resource.Id.grid1);

            tableItems = new List<TableItem>();
            tableItems.Add(new TableItem("1", "Boots"));
            tableItems.Add(new TableItem("2", "Jackets"));
            tableItems.Add(new TableItem("3", "Tactical Vests"));
            tableItems.Add(new TableItem("4", "Bags"));
            tableItems.Add(new TableItem("5", "Tactical Waist Bags"));
            tableItems.Add(new TableItem("6", "Holsters"));
            tableItems.Add(new TableItem("7", "Gun Slings"));
            tableItems.Add(new TableItem("8", "Pants"));
            tableItems.Add(new TableItem("9", "Sleeping Bags"));
            tableItems.Add(new TableItem("10", "Tactical Sweater"));
            tableItems.Add(new TableItem("11", "Uniform"));
            tableItems.Add(new TableItem("12", "Accessories"));

            grid1.Adapter = new HomeScreenAdapter(this, tableItems);
            grid1.ItemClick += OnListItemClick;
        }
        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var grid1 = sender as GridView;
            var t = tableItems[e.Position];
            //excute when click item
            //send heading to another activity for check it

            Intent intent = new Intent(this, typeof(Items));
            intent.PutExtra("id", t.Heading);
            StartActivity(intent);

          //  Android.Widget.Toast.MakeText(this, t.Heading, Android.Widget.ToastLength.Short).Show();
        }
    }

    public class TableItem
    {
        public string Heading;
        public string SubHeading;
        public TableItem(string Heading, string SubHeading)
        {
            this.Heading = Heading;
            this.SubHeading = SubHeading;
        }
    }
    public class HomeScreenAdapter : BaseAdapter<TableItem>
    {
        List<TableItem> items;
        Activity context;
        public HomeScreenAdapter(Activity context, List<TableItem> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override TableItem this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.layoutCat, null);

            
                view.FindViewById<TextView>(Resource.Id.textView1).Text = item.SubHeading;
                //  view.FindViewById<TextView>(Resource.Id.Text2).Text = item.Heading;
                
            
            //or, we can use this to add event to image click only
            /* var img = view.FindViewById<ImageView>(Resource.Id.Image);
             img.SetImageResource(item.ImageResourceId);
             img.Click += delegate
             {
                 Toast.MakeText(context, item.SubHeading, Android.Widget.ToastLength.Long).Show();
             };*/
            return view;
        }


    }
}