using Android;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.DrawerLayout.Widget;

namespace SysCredit.Android.Fragments;

public class HomeFragment : Fragment
{
    public override View OnCreateView(LayoutInflater? inflater, ViewGroup? container, Bundle? savedInstanceState)
    {
        return inflater!.Inflate(Resource.Layout.fragment_home, container, false)!;
    }
}
