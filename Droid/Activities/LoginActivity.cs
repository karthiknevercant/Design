﻿using Android.App;
<<<<<<< Updated upstream
using Android.OS;
=======
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Designer.Droid;
>>>>>>> Stashed changes

namespace Design.Droid.Activities
{
    [Activity(Label = "LoginActivity", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Views
            TextView loginTitleTv, forgotPasswordTv;
            EditText usernameEdt, passwordEdt;
            Button loginBtn, registerBtn;

            // Create your application here
            SetContentView(Resource.Layout.Login_Layout);
<<<<<<< Updated upstream
=======

            // Find View By Id's
            loginTitleTv = FindViewById<TextView>(Resource.Id.login_title_tv_id);
            usernameEdt = FindViewById<EditText>(Resource.Id.username_edt_id);
            passwordEdt = FindViewById<EditText>(Resource.Id.password_edt_id);
            loginBtn = FindViewById<Button>(Resource.Id.login_btn_id);
            registerBtn = FindViewById<Button>(Resource.Id.register_btn_id);
            forgotPasswordTv = FindViewById<TextView>(Resource.Id.forgot_pswd_tv_id);

            // Set Fonts
            loginTitleTv.SetTypeface(BaseActivity.BOLD, TypefaceStyle.Normal);
            //usernameEdt.SetTypeface(BaseActivity.MEDIUM, TypefaceStyle.Normal);
            //passwordEdt.SetTypeface(BaseActivity.MEDIUM, TypefaceStyle.Normal);
            //loginBtn.SetTypeface(BaseActivity.BOLD, TypefaceStyle.Normal);
            //registerBtn.SetTypeface(BaseActivity.BOLD, TypefaceStyle.Normal);
            //forgotPasswordTv.SetTypeface(BaseActivity.BOLD, TypefaceStyle.Normal);

            registerBtn.Click += delegate {
                NavigateToRegisterationScreen();
            };
        }

        public void SetFonts()
        {
            
        }

        public void NavigateToRegisterationScreen()
        {
            Intent intent = new Intent(this, typeof(RegisterUserActivity));
            StartActivity(intent);
>>>>>>> Stashed changes
        }
    }
}
