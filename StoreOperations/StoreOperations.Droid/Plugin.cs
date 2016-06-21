using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;
using Npadrutt.MvxPlugins.StoreOperations;
using Npadrutt.MvxPlugins.StoreOperations.Droid;

namespace Npadrutt.MvxPlugins.StoreOperations.Droid 
{
    public class Plugin : IMvxPlugin 
    {
        public void Load() 
        {
            Mvx.RegisterSingleton<IStoreOperations>(new PlayStoreOperations());
        }
    }
}
