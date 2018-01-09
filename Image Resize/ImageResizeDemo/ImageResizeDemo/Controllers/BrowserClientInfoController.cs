using ImageResizeDemo.Models;
using System.Web.Http;
using Microsoft.Practices.Unity;
using ImageResize.Service;

namespace ImageResizeDemo.Controllers
{
    [RoutePrefix("api/BrowserClientInfo")]
    public class BrowserClientInfoController : ApiController
    {
        [Dependency]
        public IClientBrowserInfoService ClientBrowserInfoService { get; set; }

        [HttpGet]
        [Route("Test")]
        public IHttpActionResult Test()
        {
            var result = ClientBrowserInfoService.Get();

            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SetBrowserClientInfo(BrowserClientInfoDTO clientBrowserInfo)
        {
            return Ok();
        }
    }
}
