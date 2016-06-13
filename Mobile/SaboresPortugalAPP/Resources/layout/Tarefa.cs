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
using static Android.Media.TV.TvContract.Channels;

namespace SaboresPortugalAPP.Resources.layout
{
    [Activity(Label = "Tarefa")]
    public class Tarefa : Activity
    {


        List<string> ListaTarefas;
        private ListView ListaTarefasView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.tarefaGUI);
            Logic.TarefaDados tarefadados = new Logic.TarefaDados();

            ListaTarefasView = FindViewById<ListView>(Resource.Id.listView1);

            ListaTarefas = new List<string>();
            ListaTarefas.Add("Tasca");
            ListaTarefas.Add("Ze do pipo");
            ListaTarefas.Add("Avo do Gtox restaurante");
            ArrayAdapter<string> ListaTarefasAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1,ListaTarefas);
            ListaTarefasView.Adapter = ListaTarefasAdapter;

            ListaTarefasView.ItemClick += (sender, e) =>
            {

                StartActivity(typeof(Resources.layout.Critica));
            };



        }
    }
}