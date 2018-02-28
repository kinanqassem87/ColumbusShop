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
    [Activity(Label = "Items")]
    class Items : Activity
    {
        List<TableItem1> tableItems1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Items);

            GridView grid1 = FindViewById<GridView>(Resource.Id.grid2);

            string data = Intent.GetStringExtra("id");

            //if Condition

            tableItems1 = new List<TableItem1>();

            if (data.Equals("1"))
            {
                tableItems1.Add(new TableItem1("2962", "2962", Resource.Drawable.i2962_4));
                tableItems1.Add(new TableItem1("2963", "2963", Resource.Drawable.i2963_2));
                tableItems1.Add(new TableItem1("2969", "2969", Resource.Drawable.i2969_2));
                tableItems1.Add(new TableItem1("2973", "2973", Resource.Drawable.i2973_1));
                tableItems1.Add(new TableItem1("4229", "4229", Resource.Drawable.i4229_1));
                tableItems1.Add(new TableItem1("4708", "4708", Resource.Drawable.i4708_1));
                tableItems1.Add(new TableItem1("4732", "4732", Resource.Drawable.i4732_1));
                tableItems1.Add(new TableItem1("5001", "5001", Resource.Drawable.i5001_1));
                tableItems1.Add(new TableItem1("5002", "5002", Resource.Drawable.i5002_1));
                tableItems1.Add(new TableItem1("5043", "5043", Resource.Drawable.i5043_2));
                tableItems1.Add(new TableItem1("5044", "5044", Resource.Drawable.i5044_2));
                tableItems1.Add(new TableItem1("6213", "6213", Resource.Drawable.i6213_1));
                tableItems1.Add(new TableItem1("90642", "90642", Resource.Drawable.i90642_1));
            }

            if (data.Equals("2"))
            {
                tableItems1.Add(new TableItem1("5038", "5038", Resource.Drawable.ja5038));
                tableItems1.Add(new TableItem1("6811", "6811", Resource.Drawable.ja6811));
                tableItems1.Add(new TableItem1("6152", "6152", Resource.Drawable.ja6152));
                tableItems1.Add(new TableItem1("6026", "6026", Resource.Drawable.ja6026));
                tableItems1.Add(new TableItem1("4964", "4964", Resource.Drawable.ja4964));
                tableItems1.Add(new TableItem1("4680", "4680", Resource.Drawable.ja4680));
                tableItems1.Add(new TableItem1("4697", "4697", Resource.Drawable.ja4697));
                tableItems1.Add(new TableItem1("6155", "6155", Resource.Drawable.ja6155));
                tableItems1.Add(new TableItem1("6228", "6228", Resource.Drawable.ja6228));
                
            }

            if (data.Equals("3"))
            {
                tableItems1.Add(new TableItem1("2477", "2477", Resource.Drawable.tv2477));
                tableItems1.Add(new TableItem1("4689", "4689", Resource.Drawable.tv4689));
                tableItems1.Add(new TableItem1("5722", "5722", Resource.Drawable.tv5722));
                tableItems1.Add(new TableItem1("6805_01", "6805_01", Resource.Drawable.tv6805_01));
                tableItems1.Add(new TableItem1("6805_02", "6805_02", Resource.Drawable.tv6805_02));
                tableItems1.Add(new TableItem1("900617", "900617", Resource.Drawable.tv900617));
                tableItems1.Add(new TableItem1("90264_1", "90264_1", Resource.Drawable.tv90264_1));
                tableItems1.Add(new TableItem1("92208_03", "92208_03", Resource.Drawable.tv92208_03));
                tableItems1.Add(new TableItem1("999024", "999024", Resource.Drawable.tv999024));
                tableItems1.Add(new TableItem1("999444", "999444", Resource.Drawable.tv999444));
                tableItems1.Add(new TableItem1("999558", "999558", Resource.Drawable.tv999558));
            }

            if (data.Equals("4"))
            {
                tableItems1.Add(new TableItem1("2629", "2629", Resource.Drawable.bag2629));
                tableItems1.Add(new TableItem1("2636", "2636", Resource.Drawable.bag2636));
                tableItems1.Add(new TableItem1("2636_2", "2636_2", Resource.Drawable.bag2636_2));
                tableItems1.Add(new TableItem1("2636_3", "2636_3", Resource.Drawable.bag2636_3));
                tableItems1.Add(new TableItem1("2636_4", "2636_4", Resource.Drawable.bag2636_4));
                tableItems1.Add(new TableItem1("2636_5", "2636_5", Resource.Drawable.bag2636_5));
                tableItems1.Add(new TableItem1("2636_6", "2636_6", Resource.Drawable.bag2636_6));
                tableItems1.Add(new TableItem1("300141_1", "300141_1", Resource.Drawable.bag300141_1));
                tableItems1.Add(new TableItem1("300141_2", "300141_2", Resource.Drawable.bag300141_2));
                tableItems1.Add(new TableItem1("4270_1", "4270_1", Resource.Drawable.bag4270_1));
                tableItems1.Add(new TableItem1("4270_2", "4270_2", Resource.Drawable.bag4270_2));
                tableItems1.Add(new TableItem1("4450", "4450", Resource.Drawable.bag4450));
                tableItems1.Add(new TableItem1("5611", "5611", Resource.Drawable.bag5611));
                tableItems1.Add(new TableItem1("5611_1", "5611_1", Resource.Drawable.bag5611_1));
                tableItems1.Add(new TableItem1("91176", "91176", Resource.Drawable.bag91176));
                tableItems1.Add(new TableItem1("91183", "91183", Resource.Drawable.bag91183));
                tableItems1.Add(new TableItem1("91190", "91190", Resource.Drawable.bag91190));
                tableItems1.Add(new TableItem1("91194", "91194", Resource.Drawable.bag91194));
                tableItems1.Add(new TableItem1("91196", "91196", Resource.Drawable.bag91196));
                tableItems1.Add(new TableItem1("999509", "999509", Resource.Drawable.bag999509));
                tableItems1.Add(new TableItem1("91185", "91185", Resource.Drawable.bg91185));
            }

            if (data.Equals("5"))
            {
                tableItems1.Add(new TableItem1("S_bag_1", "Tactical Waist Bag_1", Resource.Drawable.S_bag_1));
                tableItems1.Add(new TableItem1("S_bag_2", "Tactical Waist Bag_2", Resource.Drawable.S_bag_2));
                tableItems1.Add(new TableItem1("S_bag_3", "Tactical Waist Bag_3", Resource.Drawable.S_bag_3));
                tableItems1.Add(new TableItem1("S_bag_4", "Tactical Waist Bag_4", Resource.Drawable.S_bag_4));
                tableItems1.Add(new TableItem1("S_bag_5", "Tactical Waist Bag_5", Resource.Drawable.S_bag_5));
                tableItems1.Add(new TableItem1("S_bag_6", "Tactical Waist Bag_6", Resource.Drawable.S_bag_6));
                tableItems1.Add(new TableItem1("S_bag_7", "Tactical Waist Bag_7", Resource.Drawable.S_bag_7));
                tableItems1.Add(new TableItem1("S_bag_8", "Tactical Waist Bag_8", Resource.Drawable.S_bag_8));
                tableItems1.Add(new TableItem1("S_bag_9", "Tactical Waist Bag_9", Resource.Drawable.S_bag_9));
                tableItems1.Add(new TableItem1("S_bag_10", "Tactical Waist Bag_10", Resource.Drawable.S_bag_10));
                tableItems1.Add(new TableItem1("S_bag_11", "Tactical Waist Bag_11", Resource.Drawable.S_bag_11));
                tableItems1.Add(new TableItem1("S_bag_12", "Tactical Waist Bag_12", Resource.Drawable.S_bag_12));
                tableItems1.Add(new TableItem1("S_bag_13", "Tactical Waist Bag_13", Resource.Drawable.S_bag_13));
                tableItems1.Add(new TableItem1("S_bag_14", "Tactical Waist Bag_14", Resource.Drawable.S_bag_14));
                tableItems1.Add(new TableItem1("S_bag_15", "Tactical Waist Bag_15", Resource.Drawable.S_bag_15));
                tableItems1.Add(new TableItem1("S_bag_16", "Tactical Waist Bag_16", Resource.Drawable.S_bag_16));
                tableItems1.Add(new TableItem1("S_bag_17", "Tactical Waist Bag_17", Resource.Drawable.S_bag_17));
                tableItems1.Add(new TableItem1("S_bag_18", "Tactical Waist Bag_18", Resource.Drawable.S_bag_18));
                tableItems1.Add(new TableItem1("S_bag_19", "Tactical Waist Bag_19", Resource.Drawable.S_bag_19));
                tableItems1.Add(new TableItem1("S_bag_20", "Tactical Waist Bag_20", Resource.Drawable.S_bag_20));
                tableItems1.Add(new TableItem1("S_bag_21", "Tactical Waist Bag_21", Resource.Drawable.S_bag_21));
                tableItems1.Add(new TableItem1("S_bag_22", "Tactical Waist Bag_22", Resource.Drawable.S_bag_22));
                tableItems1.Add(new TableItem1("S_bag_23", "Tactical Waist Bag_23", Resource.Drawable.S_bag_23));
                tableItems1.Add(new TableItem1("S_bag_24", "Tactical Waist Bag_24", Resource.Drawable.S_bag_24));
                tableItems1.Add(new TableItem1("S_bag_25", "Tactical Waist Bag_25", Resource.Drawable.S_bag_25));
                tableItems1.Add(new TableItem1("S_bag_26", "Tactical Waist Bag_26", Resource.Drawable.S_bag_26));
                tableItems1.Add(new TableItem1("S_bag_27", "Tactical Waist Bag_27", Resource.Drawable.S_bag_27));
                tableItems1.Add(new TableItem1("S_bag_28", "Tactical Waist Bag_28", Resource.Drawable.S_bag_28));
                tableItems1.Add(new TableItem1("S_bag_29", "Tactical Waist Bag_29", Resource.Drawable.S_bag_29));
                tableItems1.Add(new TableItem1("S_bag_30", "Tactical Waist Bag_30", Resource.Drawable.S_bag_30));
                tableItems1.Add(new TableItem1("S_bag_31", "Tactical Waist Bag_31", Resource.Drawable.S_bag_31));
                tableItems1.Add(new TableItem1("S_bag_32", "Tactical Waist Bag_32", Resource.Drawable.S_bag_32));
                tableItems1.Add(new TableItem1("S_bag_33", "Tactical Waist Bag_33", Resource.Drawable.S_bag_33));
                tableItems1.Add(new TableItem1("S_bag_34", "Tactical Waist Bag_34", Resource.Drawable.S_bag_34));

            }

            if (data.Equals("6"))
            {
                tableItems1.Add(new TableItem1("200106_777001", "200106_777001", Resource.Drawable.h200106_777001));
                tableItems1.Add(new TableItem1("4897", "4897", Resource.Drawable.h4897));
                tableItems1.Add(new TableItem1("5522", "5522", Resource.Drawable.h5522));
                tableItems1.Add(new TableItem1("5797", "5797", Resource.Drawable.h5797));
                tableItems1.Add(new TableItem1("600387", "600387", Resource.Drawable.h600387));
                tableItems1.Add(new TableItem1("777001", "777001", Resource.Drawable.h777001));
                tableItems1.Add(new TableItem1("91160_999287", "91160_999287", Resource.Drawable.h91160_999287));
                tableItems1.Add(new TableItem1("999257", "999257", Resource.Drawable.h999257));
            }
            if (data.Equals("7"))
            {
                tableItems1.Add(new TableItem1("4821", "4821", Resource.Drawable.g4821));
                tableItems1.Add(new TableItem1("4879", "4879", Resource.Drawable.g4879));
                tableItems1.Add(new TableItem1("5046", "5046", Resource.Drawable.g5046));
                tableItems1.Add(new TableItem1("600131", "600131", Resource.Drawable.g600131));
                tableItems1.Add(new TableItem1("600168", "600168", Resource.Drawable.g600168));
            }
            if (data.Equals("8"))
            {
                tableItems1.Add(new TableItem1("4192_1", "4192_1", Resource.Drawable.p4192_1));
                tableItems1.Add(new TableItem1("4192_2", "4192_2", Resource.Drawable.p4192_2));
                tableItems1.Add(new TableItem1("4192_3", "4192_3", Resource.Drawable.p4192_3));
                tableItems1.Add(new TableItem1("4192_4", "4192_4", Resource.Drawable.p4192_4));
            }

            if (data.Equals("9"))
            {
                tableItems1.Add(new TableItem1("4165", "4165", Resource.Drawable.sb4165));
                tableItems1.Add(new TableItem1("6229", "6229", Resource.Drawable.sb6229));
                tableItems1.Add(new TableItem1("900606", "900606", Resource.Drawable.sb900606));
                tableItems1.Add(new TableItem1("92120", "92120", Resource.Drawable.sb92120));
                tableItems1.Add(new TableItem1("92121", "92121", Resource.Drawable.sb92121));
                tableItems1.Add(new TableItem1("92122", "92122", Resource.Drawable.sb92122));
                tableItems1.Add(new TableItem1("92123", "92123", Resource.Drawable.sb92123));
                tableItems1.Add(new TableItem1("92124", "92124", Resource.Drawable.sb92124));
            }

            if (data.Equals("10"))
            {
                tableItems1.Add(new TableItem1("4869", "4869", Resource.Drawable.tsh4869));
                tableItems1.Add(new TableItem1("5710", "5710", Resource.Drawable.tsh5710));
                tableItems1.Add(new TableItem1("5728", "5728", Resource.Drawable.tsh5728));
                tableItems1.Add(new TableItem1("5738", "5738", Resource.Drawable.tsh5738));
                tableItems1.Add(new TableItem1("6002", "6002", Resource.Drawable.tsh6002));
                tableItems1.Add(new TableItem1("6330", "6330", Resource.Drawable.tsh6330));
            }

            if (data.Equals("11"))
            {
                tableItems1.Add(new TableItem1("Uniform_1", "Uniform_1", Resource.Drawable.Uniform_1));
                tableItems1.Add(new TableItem1("Uniform_2", "Uniform_2", Resource.Drawable.Uniform_2));
                tableItems1.Add(new TableItem1("Uniform_3", "Uniform_3", Resource.Drawable.Uniform_3));
                tableItems1.Add(new TableItem1("Uniform_4", "Uniform_4", Resource.Drawable.Uniform_4));
                tableItems1.Add(new TableItem1("Uniform_5", "Uniform_5", Resource.Drawable.Uniform_5));
                tableItems1.Add(new TableItem1("Uniform_6", "Uniform_6", Resource.Drawable.Uniform_6));
                tableItems1.Add(new TableItem1("Uniform_7", "Uniform_7", Resource.Drawable.Uniform_7));
                tableItems1.Add(new TableItem1("Uniform_8", "Uniform_8", Resource.Drawable.Uniform_8));
                tableItems1.Add(new TableItem1("Uniform_9", "Uniform_9", Resource.Drawable.Uniform_9));
                tableItems1.Add(new TableItem1("Uniform_10", "Uniform_10", Resource.Drawable.Uniform_10));
                tableItems1.Add(new TableItem1("Uniform_11", "Uniform_11", Resource.Drawable.Uniform_11));
                tableItems1.Add(new TableItem1("Uniform_12", "Uniform_12", Resource.Drawable.Uniform_12));
            }

            if (data.Equals("12"))
            {
                tableItems1.Add(new TableItem1("22205", "22205", Resource.Drawable.ac22205));
                tableItems1.Add(new TableItem1("4289", "4289", Resource.Drawable.ac4289));
                tableItems1.Add(new TableItem1("4856_1", "4856_1", Resource.Drawable.ac4856_1));
                tableItems1.Add(new TableItem1("4856_2", "4856_2", Resource.Drawable.ac4856_2));
                tableItems1.Add(new TableItem1("4856_3", "4856_3", Resource.Drawable.ac4856_3));
                tableItems1.Add(new TableItem1("600249", "600249", Resource.Drawable.ac600249));
                tableItems1.Add(new TableItem1("6140", "6140", Resource.Drawable.ac6140));
                tableItems1.Add(new TableItem1("6250", "6250", Resource.Drawable.ac6250));
                tableItems1.Add(new TableItem1("666190", "666190", Resource.Drawable.ac666190));
                tableItems1.Add(new TableItem1("90998", "90998", Resource.Drawable.ac90998));
                tableItems1.Add(new TableItem1("999135", "999135", Resource.Drawable.ac999135));
            }

                //***

                grid1.Adapter = new HomeScreenAdapter1(this, tableItems1);
            grid1.ItemClick += OnListItemClick;
        }
        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var grid1 = sender as GridView;
            var t = tableItems1[e.Position];
            //excute when click item
            //send heading to another activity for check it

            Intent intent = new Intent(this, typeof(Description));
            intent.PutExtra("ItemID", t.Heading);
            StartActivity(intent);

           // Android.Widget.Toast.MakeText(this, t.Heading, Android.Widget.ToastLength.Short).Show();
        }

    }

    public class TableItem1
    {
        public string Heading;
        public string SubHeading;
        public int ImageResourceId;
        public TableItem1(string Heading, string SubHeading, int ImageResourceId)
        {
            this.Heading = Heading;
            this.SubHeading = SubHeading;
            this.ImageResourceId = ImageResourceId;
        }
    }
    public class HomeScreenAdapter1 : BaseAdapter<TableItem1>
    {
        List<TableItem1> items;
        Activity context;
        public HomeScreenAdapter1(Activity context, List<TableItem1> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override TableItem1 this[int position]
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
                view = context.LayoutInflater.Inflate(Resource.Layout.TicketItems, null);


            view.FindViewById<TextView>(Resource.Id.textView1).Text = item.SubHeading;
            //  view.FindViewById<TextView>(Resource.Id.Text2).Text = item.Heading;
            view.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(item.ImageResourceId);

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
