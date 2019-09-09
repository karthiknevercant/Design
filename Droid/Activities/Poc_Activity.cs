using Android.App;
using Android.OS;

namespace Design.Droid.Activities
{
    [Activity(Label = "Poc_Activity", MainLauncher = false)]
    public class Poc_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Poc_Layout);
        }
    }
}
