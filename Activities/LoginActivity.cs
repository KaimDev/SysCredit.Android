using Android.Content;
using AndroidX.AppCompat.App;

namespace SysCredit.Android.Activities;

[Activity(Label = "LoginActivity", Theme = "@style/Theme.SysCredit")]
public class LoginActivity : AppCompatActivity
{
    private Button logInButton = default!;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Create your application here
        SetContentView(Resource.Layout.activity_login);

        InitComponents();
        InitListeners();
    }

    private void InitComponents()
    {
        logInButton = FindViewById<Button>(Resource.Id.login_button)!;
    }

    private void InitListeners()
    {
        logInButton.Click += (sender, e) =>
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
        };
    }
}