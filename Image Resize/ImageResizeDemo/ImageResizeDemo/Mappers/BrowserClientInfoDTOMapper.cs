using ImageResize.Domain;
using ImageResizeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageResizeDemo.Mappers
{
    public static class BrowserClientInfoDTOMapper
    {
        public static ClientBrowserInfo MapToDomain(BrowserClientInfoDTO dto)
        {
            Guid clientBrowserInfoId = Guid.NewGuid();
            ClientBrowserInfo clientBrowserInfo = new ClientBrowserInfo();

            clientBrowserInfo.BrowserClientID = clientBrowserInfoId;
            clientBrowserInfo.DisplayResolutionHeight = dto.DisplayResolutionHeight;
            clientBrowserInfo.DisplayResolutionWidth = dto.DisplayResolutionWidth;
            clientBrowserInfo.UserAgentString = dto.UserAgentString;

            return clientBrowserInfo;
        }
    }
}