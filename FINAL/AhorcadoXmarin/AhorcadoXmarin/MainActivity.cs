using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace AhorcadoXmarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText letra = FindViewById<EditText>(Resource.Id.txtletra);
            Button btnletra = FindViewById<Button>(Resource.Id.Boton);
            TextView ResultadoLetra = FindViewById<TextView>(Resource.Id.txtresultado);

            btnletra.Click += (sender, e) =>
            {
                char l = letra.Text[0];
                string resultado =AhorcadoXmarin.Ahorcado.getInstancia().Buscar(l);
                ResultadoLetra.Text = resultado;
                
            };
        }
    }
}