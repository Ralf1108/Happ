using Android.OS;

[assembly: Xamarin.Forms.Dependency(typeof(HApp.Droid.NativeHelper))]
namespace HApp.Droid
{
    public class NativeHelper : INativeHelper
    {
        public void CloseApp()
        {
            Process.KillProcess(Process.MyPid());
        }
    }
}