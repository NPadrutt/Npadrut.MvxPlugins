using AppInformation.Core;
using Android.App;

namespace Droid {
    public class DroidAppInformation : IAppInformation {
        public string GetVersion() 
            => Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0).VersionName;
    }
}