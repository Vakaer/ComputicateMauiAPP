using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Microsoft.Maui.Platform;
using Android.Graphics;
using System.Drawing;

namespace ComputicateMobileAPP;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
     
    public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
    {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
        {
            Window.InsetsController?.SetSystemBarsAppearance((int)WindowInsetsControllerAppearance.LightStatusBars, (int)WindowInsetsControllerAppearance.LightStatusBars);
            Window.SetStatusBarColor(Android.Graphics.Color.Argb(1, 64, 39, 234));
        }
        base.OnCreate(savedInstanceState, persistentState);
    }
}
