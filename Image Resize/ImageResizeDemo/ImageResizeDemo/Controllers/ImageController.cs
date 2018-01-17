using System.Web.Http;

namespace ImageResizeDemo.Controllers
{
    [RoutePrefix("api/image")]
    public class ImageController : ApiController
    {
        [HttpGet]
        [Route("{imageName}")]
        public IHttpActionResult GetImage(string imageName)
        {
            return BadRequest("Not implemented, image name: " + imageName);
        }
    }
}
