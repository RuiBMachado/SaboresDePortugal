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
using SaboresPortugalAPP.Logic;

namespace SaboresPortugalAPP.Resources.layout
{
    [Activity(Label = "Tarefa")]
    public class Tarefa : Activity
    {


        List<TarefaDados> ListaTarefas;
        List<String> ListaAmostra;
        private ListView ListaTarefasView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.tarefaGUI);

            ListaTarefasView = FindViewById<ListView>(Resource.Id.listView1);

            TarefaDados tarefa1 = new TarefaDados("Tasca do Ze", "-8.3231", "41.2323");
            TarefaDados tarefa2 = new TarefaDados("Cozinha da Avó", "-8.5144043", "41.5990130");
            TarefaDados tarefa3 = new TarefaDados("Porto Comilao", "-8.692", "41.1817");

            ListaTarefas = new List<TarefaDados>();
            ListaTarefas.Add(tarefa1);
            ListaTarefas.Add(tarefa2);
            ListaTarefas.Add(tarefa3);

            ListaAmostra = new List<string>();
            ListaAmostra.Add(tarefa1.nomeRestaurante);
            ListaAmostra.Add(tarefa2.nomeRestaurante);
            ListaAmostra.Add(tarefa3.nomeRestaurante);
            

            ArrayAdapter<String> ListaTarefasAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1,ListaAmostra);
            ListaTarefasView.Adapter = ListaTarefasAdapter;
            
            ListaTarefasView.ItemClick += (sender, e) =>
            {
                Intent i = new Intent(this, typeof(Resources.layout.CriticaMENU));
                //String nome = ListaTarefasView.GetItemAtPosition(e.Position).ToString();
                TarefaDados a = ListaTarefas[e.Position];
                i.PutExtra("restaurante",a.nomeRestaurante);
                i.PutExtra("latitude", a.latitude1);
                i.PutExtra("longitude", a.longitude1);

                StartActivity(i);
            };



        }
    }
}