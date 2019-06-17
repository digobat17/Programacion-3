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
using static Android.App.ActionBar;

namespace xamarinFinal
{
    [Activity(Label = "Datos")]
    public class Datos : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.datos);

            EditText numeropedido = FindViewById<EditText>(Resource.Id.txtnumerodepedido);
            EditText monto = FindViewById<EditText>(Resource.Id.txtmonto);
            EditText horapedido = FindViewById<EditText>(Resource.Id.textpedido);
            EditText horaentrega = FindViewById<EditText>(Resource.Id.txtentrega);
            ListView lista = FindViewById<ListView>(Resource.Id.listView1);
            Button agregrar = FindViewById<Button>(Resource.Id.btnAgregar);
            agregrar.Click += (sender, e) =>
            {
                int npedido;
                 double mont;
                 string hentrega, hpedido;
                 npedido =Convert.ToInt32( numeropedido.Text);
                 mont = Convert.ToDouble(monto.Text);
                 hpedido = horapedido.Text;
                 hentrega = horaentrega.Text;
                      
                    

                

            };
        }
    }
}