using System;
using System.Collections.Generic;
using ImageResize.Data;
using ImageResize.Domain;
using Microsoft.Practices.Unity;

namespace ImageResize.Service
{
    public class ClientBrowserInfoService : IClientBrowserInfoService
    {
        [Dependency]
        public IClientBrowserInfoRepository ClientBrowserInfoRepository  { get; set; }        

        public void Create(ClientBrowserInfo clientBrowserInfo)
        {
            ClientBrowserInfoRepository.Add(clientBrowserInfo);
        }

        public ClientBrowserInfo GetById(Guid id)
        {
            //var clientBrowerInfo = ClientBrowserInfoList.Find(x => x.BrowserClientID == id);

            return null;
        }
    }
}
