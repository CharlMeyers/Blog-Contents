using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace ImageResize.Service
{
    public class SharedUnityContainerExtention : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IClientBrowserInfoService>(new HierarchicalLifetimeManager());            
        }
    }
}
