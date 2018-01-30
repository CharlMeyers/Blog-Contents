using ImageResizeDemo.Models;
using ImageResizeDemo.Mappers;
using System.Web.Http;
using Microsoft.Practices.Unity;
using ImageResize.Service;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Collections.Specialized;

namespace ImageResizeDemo.Controllers
{
    [RoutePrefix("api/BrowserClientInfo")]
    public class BrowserClientInfoController : ApiController
    {
        [Dependency]
        public IClientBrowserInfoService ClientBrowserInfoService { get; set; }        

        [HttpPost]
        [Route("SetBrowserClientInfo")]
        public HttpResponseMessage SetBrowserClientInfo(BrowserClientInfoDTO clientBrowserInfoDTO)
        {
            var response = new HttpResponseMessage();

            var displayResolution = new NameValueCollection();
            displayResolution["DisplayResolutionHeight"] = clientBrowserInfoDTO.DisplayResolutionHeight.ToString();
            displayResolution["DisplayResolutionWidth"] = clientBrowserInfoDTO.DisplayResolutionWidth.ToString();            

            var cookie = new CookieHeaderValue("DisplayResolution", displayResolution);
            cookie.Domain = Request.RequestUri.Host;
            cookie.Path = "/";

            response.Headers.AddCookies(new CookieHeaderValue[] { cookie });
            return response;
        }

        [HttpGet]
        [Route("GetUserAgentString")]
        public IHttpActionResult GetUserAgentString()
        {
            CookieHeaderValue cookie = Request.Headers.GetCookies("ClientBrowserInfoId").FirstOrDefault();

            if (cookie != null)
            {
                Guid clientBrowserInfoId = Guid.Parse(cookie["ClientBrowserInfoId"].Value);
                var clientBrowserInfo = ClientBrowserInfoService.GetById(clientBrowserInfoId);
                return Ok(clientBrowserInfo.UserAgentString);
            }
            else
            {

                return Ok("Cookie not set");
            }
        }
    }
}
