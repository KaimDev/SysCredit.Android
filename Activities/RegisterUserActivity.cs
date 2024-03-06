using Android.Content;
using AndroidX.AppCompat.App;

namespace SysCredit.Android.Activities;

[Activity(Label = "RegisterUserActivity", Theme = "@style/Theme.SysCredit")]
public class RegisterUserActivity : AppCompatActivity
{
    private Button registerUserButton = default!;
    private Button goToLoginButton = default!;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Create your application here
        SetContentView(Resource.Layout.activity_register_user);

        InitComponents();
        InitListeners();
    }

    private void InitComponents()
    {
        registerUserButton = FindViewById<Button>(Resource.Id.register_user_button)!;
        goToLoginButton = FindViewById<Button>(Resource.Id.go_to_login_button)!;
    }

    private void InitListeners()
    {
        registerUserButton.Click += (sender, e) =>
        {
            StartActivity(new Intent(this, typeof(LoginActivity)));
        };

        goToLoginButton.Click += (sender, e) =>
        {
            StartActivity(new Intent(this, typeof(LoginActivity)));
        };
    }
}