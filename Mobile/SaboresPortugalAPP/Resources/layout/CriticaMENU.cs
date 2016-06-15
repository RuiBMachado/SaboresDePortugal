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
    [Activity(Label = "CriticaMENU")]
    public class CriticaMENU : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CriticaMENUGUI);

            Button critica = FindViewById<Button>(Resource.Id.button1);
            Button mapa = FindViewById<Button>(Resource.Id.button2);

            critica.Click += (sender, e) =>
            {

                StartActivity(typeof(Resources.layout.Critica));
            };
            mapa.Click += (sender, e) =>
            {

                StartActivity(typeof(Resources.layout.Mapa));
            };
        }
        }
}