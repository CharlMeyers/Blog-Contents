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
        private string DataStorePath = AppDomain.CurrentDomain.GetData("DataDirectory").ToString() + "/ClientBrowserInfo.json";        

        public void Add(ClientBrowserInfo clientBrowserInfo)
        {
            string json = File.ReadAllText(DataStorePath);
            ClientBrowserInfoList = JsonConvert.DeserializeObject<List<ClientBrowserInfo>>(json);

            ClientBrowserInfoList.Add(clientBrowserInfo);            
        }

        public ClientBrowserInfo GetById(Guid id)
        {
            string json = File.ReadAllText(DataStorePath);
            ClientBrowserInfoList = JsonConvert.DeserializeObject<List<ClientBrowserInfo>>(json);

            ClientBrowserInfo clientBrowserInfo = ClientBrowserInfoList.Find(x => x.BrowserClientID == id);
            return clientBrowserInfo;
        }

        public void Save()
        {
            string jsonToSave = JsonConvert.SerializeObject(ClientBrowserInfoList);
            File.WriteAllText(DataStorePath, jsonToSave);
        }
    }
}
