using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Designer.Droid;

namespace Design.Droid.Activities
{
    [Activity(Label = "Design", MainLauncher = false)]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Login_Layout);

            Button loginBtn, registerBtn;

            loginBtn = FindViewById<Button>(Resource.Id.login_btn_id);

            registerBtn = FindViewById<Button>(Resource.Id.register_btn_id);

            registerBtn.Click += delegate {
                NavigateToRegisterationScreen();
            };
        }

        public void NavigateToRegisterationScreen()
        {
            Intent intent = new Intent(this, typeof(RegisterUserActivity));
            StartActivity(intent);
        }
    }
}
