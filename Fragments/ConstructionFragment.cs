using Android.Views;
using AndroidX.Fragment.App;

namespace SysCredit.Android.Fragments;

public class ConstructionFragment : AndroidX.Fragment.App.Fragment
{
    public override View OnCreateView(LayoutInflater? inflater, ViewGroup? container, Bundle? savedInstanceState)
    {
        return inflater!.Inflate(Resource.Layout.fragment_construction, container, false)!;
    }
}
