using Android.Content;
using AndroidX.AppCompat.App;

namespace SysCredit.Android.Activities;

[Activity(Label = "@string/app_name", MainLauncher = true, Theme = "@style/SplashScreen")]
public class SplashScreenActivity : AppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        StartActivity(new Intent(this, typeof(LoginActivity)));
        Finish();
    }
}
