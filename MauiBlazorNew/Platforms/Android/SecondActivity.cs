using Android.App;
using Android.Content.PM;
using Android.OS;
using static Android.Content.Res.Resources;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MauiBlazorNew.Platforms.Android;


[Activity(Theme = "@style/Maui.SplashTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class SecondActivity : Activity
{
    public static SecondActivity Instance;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Instance = this;
        SetContentView(Resource.Layout.SecondActivity);
    }
}

