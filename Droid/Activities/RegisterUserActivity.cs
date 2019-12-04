
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
<<<<<<< Updated upstream
using Android.Runtime;
using Android.Views;
using Android.Widget;
=======
using Android.Widget;
using Designer.Droid;
>>>>>>> Stashed changes

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

            //Views
            ImageView backImgv;

            // Find View By Id's
            backImgv = FindViewById<ImageView>(Resource.Id.toolbar_back_imgv_id);

            backImgv.Click += delegate {
                Finish();
            };
        }
    }
}
