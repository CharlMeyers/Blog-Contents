using Microsoft.Practices.Unity;

namespace ImageResize.Data
{
    public class DataUnityContainerExtention : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IClientBrowserInfoRepository, ClientBrowserInfoRepository>(new HierarchicalLifetimeManager());            
        }
    }
}
