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

namespace PilaXamarin
{
    [Activity(Label = "ActivityInsertar")]
    public class ActivityInsertar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Create your application here
            SetContentView(Resource.Layout.InsertaLO);

            EditText numero = FindViewById<EditText>(Resource.Id.txtintroducir);
            Button agregar = FindViewById<Button>(Resource.Id.btnAgregar);



        }
    }
}