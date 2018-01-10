using System;
using System.Collections.Generic;
using ImageResize.Domain;

namespace ImageResize.Data
{
    public interface IClientBrowserInfoRepository
    {
        ClientBrowserInfo GetById(Guid id);

        void Add(ClientBrowserInfo clientBrowserInfo);

        void Save();
    }
}
