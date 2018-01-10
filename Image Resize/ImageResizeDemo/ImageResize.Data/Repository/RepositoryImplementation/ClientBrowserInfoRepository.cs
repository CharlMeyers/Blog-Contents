using ImageResize.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ImageResize.Data
{
    public class ClientBrowserInfoRepository : IClientBrowserInfoRepository
    {
        private List<ClientBrowserInfo> ClientBrowserInfoList;

        public ClientBrowserInfoRepository()
        {
            ClientBrowserInfoList = new List<ClientBrowserInfo>();
        }

        public void Add(ClientBrowserInfo clientBrowserInfo)
        {
            string json = File.ReadAllText(AppDomain.CurrentDomain.GetData("DataDirectory").ToString() + "/ClientBrowserInfo.json");
            ClientBrowserInfoList = JsonConvert.DeserializeObject<List<ClientBrowserInfo>>(json);
            throw new NotImplementedException();
        }

        public ClientBrowserInfo GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
