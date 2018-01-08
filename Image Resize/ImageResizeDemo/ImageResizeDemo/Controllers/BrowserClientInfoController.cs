using ImageResizeDemo.Models;
using System.Web.Http;

namespace ImageResizeDemo.Controllers
{
    public class BrowserClientInfoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult SetBrowserClientInfo(BrowserClientInfoDTO clientBrowserInfo)
        {
            return Ok();
        }
    }
}
