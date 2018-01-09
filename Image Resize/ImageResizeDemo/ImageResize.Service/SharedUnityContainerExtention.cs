using Microsoft.Practices.Unity;

namespace ImageResize.Service
{
    public class SharedUnityContainerExtention : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IClientBrowserInfoService, ClientBrowserInfoService>(new HierarchicalLifetimeManager());            
        }
    }
}
