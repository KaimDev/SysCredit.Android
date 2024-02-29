using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.AppBar;
using Google.Android.Material.Navigation;

namespace SysCredit.Android;

[Activity(Label = "@string/app_name", MainLauncher = false, Theme = "@style/Theme.SysCredit.NoActionBar")]
public class MainActivity : AppCompatActivity
{
    private DrawerLayout? drawerLayout;
    private ActionBarDrawerToggle? drawerToggle;
    private NavigationView? navigationView;
    private ImageButton? menuButton;
    private IMenu? menu;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);

        InitComponents();
        InitListeners();
    }

    private void InitComponents()
    {
        drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout)!;
        navigationView = FindViewById<NavigationView>(Resource.Id.nav_view)!;
        drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, Resource.String.nav_open, Resource.String.nav_close);
        menuButton = FindViewById<ImageButton>(Resource.Id.menu_button)!;
        menu = navigationView.Menu;
    }

    private void InitListeners()
    {
        SetSupportActionBar(FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar)!);
        SupportActionBar!.SetDisplayShowTitleEnabled(false);

        menuButton!.Click += (sender, e) => drawerLayout!.OpenDrawer(GravityCompat.Start);

        menu!.FindItem(Resource.Id.nav_home)!.SetChecked(true);
    }
}