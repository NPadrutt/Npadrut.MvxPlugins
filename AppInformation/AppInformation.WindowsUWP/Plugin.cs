using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace Npadrutt.MvxPlugins.AppInformation.WindowsUWP {
    public class Plugin : IMvxPlugin 
    {
        public void Load() 
        {
            Mvx.RegisterSingleton<IAppInformation>(new WindowsAppInformation());
        }
    }
}
