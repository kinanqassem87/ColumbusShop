using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ColumbusShop
{
    [Activity(Label = "About US")]
    class AboutUs : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.AboutUs);
            Button btnWebSite = FindViewById<Button>(Resource.Id.btnWebSite);
            Button btnFB = FindViewById<Button>(Resource.Id.btnFB);
            Button btnInsta = FindViewById<Button>(Resource.Id.btnInsta);

            AdView mAdView3 = FindViewById<AdView>(Resource.Id.adView3);
            var adRequest3 = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView3.LoadAd(adRequest3);

            btnWebSite.Click += delegate 
            {
                var url = Android.Net.Uri.Parse("http://columbus-lb.com/");
                Intent intent1 = new Intent(Intent.ActionView,url);
                StartActivity(intent1);


            };

            btnFB.Click += delegate 
            {
                var url = Android.Net.Uri.Parse("https://www.facebook.com/columbuslb/");
                Intent intent2 = new Intent(Intent.ActionView, url);
                StartActivity(intent2);
            };

            btnInsta.Click += 
                delegate 
                {
                    var url = Android.Net.Uri.Parse("https://www.instagram.com/columbus.leb/");
                    Intent intent3 = new Intent(Intent.ActionView, url);
                    StartActivity(intent3);
                };
        }

        /* 
         * open another App..
          Intent intent = PackageManager.GetLaunchIntentForPackage("com.facebook.katana");
          StartActivity(intent);
          */
        /* public Task<bool> LaunchApp(string uri)
         {
             bool result = false;

             try
             {
                 var aUri = Android.Net.Uri.Parse(uri.ToString());
                 var intent = new Intent(Intent.ActionView, aUri);
                 StartActivity(intent);
                 result = true;
             }
             catch (ActivityNotFoundException)
             {
                 result = false;
             }

             return Task.FromResult(result);
         }*/

    }
}