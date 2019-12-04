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
using Design.Droid;

namespace Designer.Droid.Activities
{
    [Activity(Label = "FogortPasswordActivity")]
    public class FogortPasswordActivity : BaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Views
            TextView forgotTitleTv, forgotPasswordTv;
            EditText usernameEdt, passwordEdt;
            Button loginBtn, registerBtn;

            // Create your application here
            SetContentView(Resource.Layout.Login_Layout);

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
        }
    }
}