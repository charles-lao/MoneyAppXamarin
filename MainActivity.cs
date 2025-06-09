using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Calligraphy;

namespace MoneyAppXamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
            //    .SetDefaultFontPath("fonts/GlacialIndifference-Regular.ttf")
            //    .SetFontAttrId(Resource.Attribute.fontPath)
            //    .Build());

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }

        //protected override void AttachBaseContext(Context @base)
        //{
        //    base.AttachBaseContext(CalligraphyContextWrapper.Wrap(@base));
        //}
        
    }
}