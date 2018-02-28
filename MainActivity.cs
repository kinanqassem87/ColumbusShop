using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;

namespace ColumbusShop
{
    [Activity(Label = "Columbus Shop", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button btnAbout = FindViewById<Button>(Resource.Id.btnAbout);
            Button btnShow = FindViewById<Button>(Resource.Id.btnShow);

            AdView mAdView1 = FindViewById<AdView>(Resource.Id.adView1);
            var adRequest1 = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView1.LoadAd(adRequest1);

            //  ********

            AdView mAdView2 = FindViewById<AdView>(Resource.Id.adView2);
            var adRequest2 = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView2.LoadAd(adRequest2);

            btnAbout.Click += delegate 
            {
                StartActivity(typeof(AboutUs));
            };

            btnShow.Click += delegate 
            {
                StartActivity(typeof(Category));
            };
        }
    }
}

