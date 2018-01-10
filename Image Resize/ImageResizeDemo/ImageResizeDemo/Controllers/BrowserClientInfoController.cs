using ImageResizeDemo.Models;
using ImageResizeDemo.Mappers;
using System.Web.Http;
using Microsoft.Practices.Unity;
using ImageResize.Service;
using System;

namespace ImageResizeDemo.Controllers
{
    [RoutePrefix("api/BrowserClientInfo")]
    public class BrowserClientInfoController : ApiController
    {
        [Dependency]
        public IClientBrowserInfoService ClientBrowserInfoService { get; set; }        

        [HttpPost]
        [Route("SetBrowserClientInfo")]
        public IHttpActionResult SetBrowserClientInfo(BrowserClientInfoDTO clientBrowserInfoDTO)
        {
            var clientBrowserInfo = BrowserClientInfoDTOMapper.MapToDomain(clientBrowserInfoDTO);

            ClientBrowserInfoService.Create(clientBrowserInfo);

            return Ok(clientBrowserInfo.BrowserClientID);
        }

        [HttpGet]
        [Route("GetUserAgentString")]
        public IHttpActionResult GetUserAgentString(Guid clientBrowserInfoId)
        {
            var clientBrowserInfo = ClientBrowserInfoService.GetById(clientBrowserInfoId);

            return Ok(clientBrowserInfo.UserAgentString);
        }
    }
}
