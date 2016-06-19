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
using Android.Media;

namespace SaboresPortugalAPP.Resources.layout
{
    [Activity(Label = "Critica")]
    public class Critica : Activity
    {
        MediaRecorder _recorder;
        MediaPlayer _player;
        Button _start;
        Button _stop;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.criticaGUI);
            TextView nomeRestaurante = FindViewById<TextView>(Resource.Id.textView3);
            string nome = Intent.GetStringExtra("restaurante");
            nomeRestaurante.Text = nome;

            // Create intent to Open Image applications like Gallery, Google Photos
            Button imagem = FindViewById<Button>(Resource.Id.button1);
            _start = FindViewById<Button>(Resource.Id.button2);
            _stop = FindViewById<Button>(Resource.Id.button3);
            string path = "/storage/emulated/0/SaboresPortugal/"+nome+".3gpp";


            imagem.Click += (sender, e) =>
            {

                // Start the Intent
                var imageIntent = new Intent();
                imageIntent.SetType("image/*");
                imageIntent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(
                Intent.CreateChooser(imageIntent, "Select photo"), 0);
            };

            _start.Click += (sender, e) =>
            {
                
                _start.Enabled = !_start.Enabled;

                _recorder.SetAudioSource(AudioSource.Mic);
                _recorder.SetOutputFormat(OutputFormat.ThreeGpp);
                _recorder.SetAudioEncoder(AudioEncoder.AmrNb);
                _recorder.SetOutputFile(path);
                _recorder.Prepare();
                _recorder.Start();
            };

            _stop.Click += (sender, e) =>
            {
                _stop.Enabled = !_stop.Enabled;

                _recorder.Stop();
                _recorder.Reset();

                _player.SetDataSource(path);
                _player.Prepare();
                _player.Start();
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

        protected override void OnResume()
        {
            base.OnResume();

            _recorder = new MediaRecorder();
            _player = new MediaPlayer();

            _player.Completion += (sender, e) => {
                _player.Reset();
                _start.Enabled = !_start.Enabled;
            };

        }

        protected override void OnPause()
        {
            base.OnPause();

            _player.Release();
            _recorder.Release();
            _player.Dispose();
            _recorder.Dispose();
            _player = null;
            _recorder = null;
        }

    }
}