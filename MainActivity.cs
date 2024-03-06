using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using AndroidX.Fragment.App;
using Google.Android.Material.Navigation;
using SysCredit.Android.Fragments;

namespace SysCredit.Android;

[Activity(Label = "@string/app_name", MainLauncher = false, Theme = "@style/Theme.SysCredit.NoActionBar")]
public class MainActivity : AppCompatActivity
{
    private DrawerLayout? drawerLayout;
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
        menuButton = FindViewById<ImageButton>(Resource.Id.menu_button)!;
        menu = navigationView.Menu;

        // Load Home Fragment
        LoadFragment(new HomeFragment());
    }

    private void InitListeners()
    {
        SetSupportActionBar(FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar)!);
        SupportActionBar!.SetDisplayShowTitleEnabled(false);

        menuButton!.Click += (sender, e) => drawerLayout!.OpenDrawer(GravityCompat.Start);

        menu!.FindItem(Resource.Id.nav_home)!.SetChecked(true);

        navigationView!.NavigationItemSelected += HandleNavigation;
    }

    private void HandleNavigation(object? sender, NavigationView.NavigationItemSelectedEventArgs e)
    {
        e.MenuItem.SetChecked(true);

        // navigate to the item selected
        switch (e.MenuItem.ItemId)
        {
            case Resource.Id.nav_home:
                LoadFragment(new HomeFragment());
                break;
            case Resource.Id.nav_client_registration:
                LoadFragment(new ConstructionFragment());
                break;
            case Resource.Id.nav_client_list:
                LoadFragment(new ConstructionFragment());
                break;
            case Resource.Id.nav_loan_application:
                LoadFragment(new ConstructionFragment());
                break;
            case Resource.Id.nav_routes:
                LoadFragment(new ConstructionFragment());
                break;
            case Resource.Id.nav_reports:
                LoadFragment(new ConstructionFragment());
                break;
            case Resource.Id.nav_about:
                LoadFragment(new ConstructionFragment());
                break;
            case Resource.Id.nav_help:
                LoadFragment(new ConstructionFragment());
                break;
            case Resource.Id.nav_logout:
                LoadFragment(new ConstructionFragment());
                break;
        }

        drawerLayout!.CloseDrawers();
    }

    private void LoadFragment(AndroidX.Fragment.App.Fragment fragment)
    {
        SupportFragmentManager.BeginTransaction()
            .Replace(Resource.Id.i_fragment_container, fragment)
            .Commit();
    }
}