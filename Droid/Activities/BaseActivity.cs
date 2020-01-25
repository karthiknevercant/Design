using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Designer.Droid;
using Design.Constant;
using Android.App;
namespace Design.Droid
{
    public class BaseActivity : AppCompatActivity
    {
        // Fonts
        public static Typeface BOLD = Typeface.CreateFromAsset(Application.Context.Assets, Constants.FONT_PATH_BOLD);

        //public static Typeface MEDIUM = Typeface.CreateFromAsset(Application.Context.Assets, Constants.FONT_PATH_MEDIUM);
        //public static Typeface REGULAR = Typeface.CreateFromAsset(Application.Context.Assets, Constants.FONT_PATH_REGULAR);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(LayoutResource);
            Toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            if (Toolbar != null)
            {
                SetSupportActionBar(Toolbar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(true);
                SupportActionBar.SetHomeButtonEnabled(true);

            }
        }

        public Toolbar Toolbar
        {
            get;
            set;
        }

        protected virtual int LayoutResource
        {
            get;
        }

        protected int ActionBarIcon
        {
            set { Toolbar?.SetNavigationIcon(value); }
        }
    }
}
