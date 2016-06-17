using AppInformation.Core;
using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace Droid 
{
    public class Plugin : IMvxPlugin 
    {
        public void Load() 
        {
            Mvx.RegisterSingleton<IAppInformation>(new DroidAppInformation());
        }
    }
}
