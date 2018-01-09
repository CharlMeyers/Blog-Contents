using System;
using System.Collections.Generic;
using ImageResize.Domain;

namespace ImageResize.Service
{
    public class ClientBrowserInfoService : IClientBrowserInfoService
    {
        private List<ClientBrowserInfo> ClientBrowserInfoList;

        public ClientBrowserInfoService()
        {
            ClientBrowserInfoList = new List<ClientBrowserInfo>();
        }

        public void Create(ClientBrowserInfo clientBrowserInfo)
        {
            ClientBrowserInfoList.Add(clientBrowserInfo);
        }        
    }
}
