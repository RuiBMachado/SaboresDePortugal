using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SaboresPortugalAPP
{
    [Activity(Label = "SaboresPortugalAPP", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.mainmenuGUI);

            // Get our button from the layout resource,
            // and attach an event to it
            Button critica = FindViewById<Button>(Resource.Id.button1);
            Button mapa = FindViewById<Button>(Resource.Id.button2);


            critica.Click += (sender, e) =>
            {

                StartActivity(typeof(Resources.layout.Tarefa));
            };

            mapa.Click += (sender, e) =>
            {

                StartActivity(typeof(Resources.layout.Mapa));
            };
        }
        }
}

