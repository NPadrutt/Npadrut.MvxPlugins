using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace Npadrutt.MvxPlugins.AppInformation.Droid 
{
    public class Plugin : IMvxPlugin 
    {
        public void Load() 
        {
            Mvx.RegisterSingleton<IAppInformation>(new DroidAppInformation());
        }
    }
}
