using Android.Content;
using AndroidX.AppCompat.App;

namespace SysCredit.Android.Activities;

[Activity(Label = "LoginActivity", Theme = "@style/Theme.SysCredit")]
public class LoginActivity : AppCompatActivity
{
    private Button logInButton = default!;
    private Button forgetPasswordButton = default!;

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
        forgetPasswordButton = FindViewById<Button>(Resource.Id.forget_password_button)!;
    }

    private void InitListeners()
    {
        logInButton.Click += (sender, e) =>
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
        };

        forgetPasswordButton.Click += (sender, e) =>
        {
            StartActivity(new Intent(this, typeof(RecoverAccountActivity)));
        };
    }
}