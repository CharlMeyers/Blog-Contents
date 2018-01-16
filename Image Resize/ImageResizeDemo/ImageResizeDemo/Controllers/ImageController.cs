using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ImageResizeDemo.Controllers
{
    [RoutePrefix("api/image")]
    public class ImageController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetImage(string imageName)
        {
            return BadRequest("Not implemented");
        }
    }
}
