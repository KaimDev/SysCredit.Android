namespace SysCredit.Android.Activities;

[Activity(Label = "@string/app_name", MainLauncher = false)]
public class HomeActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_home);
    }
}
