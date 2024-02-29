using Android.Content;
using AndroidX.AppCompat.App;

namespace SysCredit.Android.Activities;

[Activity(Label = "RecoverAccountActivity", Theme = "@style/Theme.SysCredit")]
public class RecoverAccountActivity : AppCompatActivity
{
    private Button loginButton = default!;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Create your application here
        SetContentView(Resource.Layout.activity_recover_account);

        InitComponents();
        InitListeners();
    }

    private void InitComponents()
    {
        loginButton = FindViewById<Button>(Resource.Id.login_button)!;
    }

    private void InitListeners()
    {
        loginButton.Click += (sender, e) =>
        {
            StartActivity(new Intent(this, typeof(LoginActivity)));
        };
    }
}