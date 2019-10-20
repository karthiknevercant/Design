using Android.App;
using Android.OS;
using Designer.Droid;

namespace Design.Droid.Activities
{
    [Activity(Label = "RegisterUserActivity")]
    public class RegisterUserActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register_Layout);
        }
    }
}
