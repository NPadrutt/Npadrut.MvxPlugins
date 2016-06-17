using Android.App;

namespace Npadrutt.MvxPlugins.AppInformation.Droid 
{
    public class DroidAppInformation : IAppInformation {
        public string GetVersion() 
            => Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0).VersionName;
    }
}