using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace sc01_DialMyNumber
{
    [Activity(Label = "sc01_DialMyNumber", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button dialButton = FindViewById<Button>(Resource.Id.btnDial);

            dialButton.Click += delegate
            {
                EditText phoneNum = FindViewById<EditText>(Resource.Id.phoneNumber);
                string phoneNumber = phoneNum.Text; 
                var uri = Android.Net.Uri.Parse("tel:" + phoneNumber);
                Intent myIntent = new Intent(Intent.ActionDial, uri);
                StartActivity(myIntent);
            };
        }
    }
}

