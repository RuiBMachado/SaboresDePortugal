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
    public class Critica : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.criticaGUI);
            TextView nomeRestaurante = FindViewById<TextView>(Resource.Id.textView3);
            nomeRestaurante.Text = Intent.GetStringExtra("restaurante");

            // Create intent to Open Image applications like Gallery, Google Photos
            Button imagem = FindViewById<Button>(Resource.Id.button1);


            imagem.Click += (sender, e) =>
            {

                // Start the Intent
                var imageIntent = new Intent();
                imageIntent.SetType("image/*");
                imageIntent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(
                    Intent.CreateChooser(imageIntent, "Select photo"), 0);
            };
            

        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok)
            {
                var imageView =
                    FindViewById<ImageView>(Resource.Id.imageView1);
                imageView.SetImageURI(data.Data);
            }
        }

    }
}