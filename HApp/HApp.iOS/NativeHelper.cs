using System.Diagnostics;

[assembly: Xamarin.Forms.Dependency(typeof(HApp.iOS.NativeHelper))]
namespace HApp.iOS
{
    public class NativeHelper : HApp.INativeHelper
    {
        public void CloseApp()
        {
            Process.GetCurrentProcess().CloseMainWindow();
            Process.GetCurrentProcess().Close();
        }
    }
}
