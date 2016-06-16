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
    [Activity(Label = "Critica")]
    public class CriticaMENU : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            

            // Create your application here
            SetContentView(Resource.Layout.CriticaMENUGUI);
            TextView nomeRestaurante =FindViewById<TextView>(Resource.Id.textView1);
            nomeRestaurante.Text = Intent.GetStringExtra("restaurante");

            Button critica = FindViewById<Button>(Resource.Id.button1);
            Button mapa = FindViewById<Button>(Resource.Id.button2);

            critica.Click += (sender, e) =>
            {
                Intent i = new Intent(this, typeof(Resources.layout.Critica));
                String nome = Intent.GetStringExtra("restaurante");
                i.PutExtra("restaurante", nome);
                StartActivity(i);
            };
            mapa.Click += (sender, e) =>
            {
                Intent i = new Intent(this, typeof(Resources.layout.Mapa));
                String nome = Intent.GetStringExtra("restaurante");
                i.PutExtra("restaurante", nome);
                StartActivity(i);
            };
        }
        }
}