using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Content;
using System.Diagnostics;
//using Android.Widget;
using MauiBlazorNew.Platforms.Android;
using Android.Runtime;
using Android.Views;

namespace MauiBlazorNew;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    public static MainActivity Instance;
    Button btnsend;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Instance = this;
        SetContentView(Resource.Layout.Main);
        btnsend = FindViewById<Button>(Resource.Id.btnsend);
        btnsend.Pressed += Button_Click;
    }
    private void Button_Click(object sender, EventArgs e)
    {
        var intent = new Intent(this, typeof(SecondActivity));
        intent.PutExtra("DATA_PASS", "SCAM MAUI");
        this.StartActivity(intent);
    }
}
