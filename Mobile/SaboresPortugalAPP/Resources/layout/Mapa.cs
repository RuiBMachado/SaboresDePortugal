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

namespace SaboresPortugalAPP.Resources.layout
{
    [Activity(Label = "Mapa")]
    public class Mapa : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            string nome = Intent.GetStringExtra("restaurante");
            string latitude = Intent.GetStringExtra("latitude");
            string longitude = Intent.GetStringExtra("longitude");
         

            // Set our view from the "main" layout resource
            var geoUri = Android.Net.Uri.Parse("geo:0,0?q="+latitude+','+longitude+"("+nome+")");
            var mapIntent = new Intent(Intent.ActionView, geoUri);
            StartActivity(mapIntent);
        }
    }
}