using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;
using StoreOperations;
using StoreOperations.Droid;

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
