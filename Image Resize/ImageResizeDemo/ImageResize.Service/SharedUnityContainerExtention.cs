using ImageResize.Data;
using Microsoft.Practices.Unity;

namespace ImageResize.Service
{
    public class SharedUnityContainerExtention : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.AddExtension(new DataUnityContainerExtention());
            Container.RegisterType<IClientBrowserInfoService, ClientBrowserInfoService>(new HierarchicalLifetimeManager());            
        }
    }
}
