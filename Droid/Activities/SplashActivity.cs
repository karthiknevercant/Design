using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Design.Droid.Activities;
using Designer.Droid;
using System.Threading.Tasks;

namespace Design.Droid
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Splash_Layout);

            Intialize();
        }

        async Task Intialize()
        {
            await Task.Delay(2000);

            var newIntent = new Intent(this, typeof(LoginActivity));
            newIntent.AddFlags(ActivityFlags.ClearTop);
            newIntent.AddFlags(ActivityFlags.SingleTop);

            StartActivity(newIntent);
            Finish();
        }
    }
}
