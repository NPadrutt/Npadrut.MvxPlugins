using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;
using StoreOperations;
using StoreOperations.WindowsUWP;

namespace Npadrutt.MvxPlugins.StoreOperations.WindowsUWP 
{
    public class Plugin : IMvxPlugin 
    {
        public void Load() 
        {
            Mvx.RegisterSingleton<IStoreOperations>(new MarketplaceOperations());
        }
    }
}
