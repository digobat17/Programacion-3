using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace operacionesXamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText n = FindViewById<EditText>(Resource.Id.txtN);
            Button resul = FindViewById<Button>(Resource.Id.button1);
            RadioButton sum = FindViewById<RadioButton>(Resource.Id.radioButton1);
            RadioButton fac = FindViewById<RadioButton>(Resource.Id.radioButton2);
            TextView resultado = FindViewById<TextView>(Resource.Id.txtResultado);
            resul.Click += (sender, e) =>
            {
                if(sum.Checked)
                {
                    int re = operacionesXamarin.operaciones.getInstancia().sumatoria(int.Parse( n.Text));
                    resultado.Text = re.ToString();
                }
                if(fac.Checked)
                {
                    int re = operacionesXamarin.operaciones.getInstancia().factorial(int.Parse(n.Text));
                    resultado.Text = re.ToString();
                }
                    

                

            };
        }
    }
}