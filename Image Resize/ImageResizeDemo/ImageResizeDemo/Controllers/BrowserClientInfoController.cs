using ImageResizeDemo.Models;
using System.Web.Http;
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
    }
}
