using ImageResize.Service;
using Microsoft.Practices.Unity;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ImageResizeDemo.Controllers
{
    [RoutePrefix("api/image")]
    public class ImageController : ApiController
    {
        [Dependency]
        public IImageService ImageService { get; set; }

        [Dependency]
        public IClientBrowserInfoService ClientBrowserInfoService { get; set; }

        [HttpGet]
        [Route("{imageName}")]
        public HttpResponseMessage GetImage(string imageName)
        {
            CookieHeaderValue cookie = Request.Headers.GetCookies("DisplayResolution").FirstOrDefault();
            CookieState cookieState = cookie["DisplayResolution"];

            int resolutionHeight = Convert.ToInt32(cookieState["DisplayResolutionHeight"]);
            int resolutionWidth = Convert.ToInt32(cookieState["DisplayResolutionWidth"]);

            byte[] image = ImageService.GetImageByName(imageName, resolutionHeight, resolutionWidth);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new ByteArrayContent(image);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");

            return response;
        }

        [HttpGet]
        [Route("GetImage")]
        public HttpResponseMessage GetImage(Guid id)
        {
            byte[] image = ImageService.GetImage(id);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new ByteArrayContent(image);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");

            return response;
        }

        [HttpGet]
        [Route("GetProfilePicture")]
        public HttpResponseMessage GetProfilePicture(Guid id, int height, int width)
        {
            byte[] image = ImageService.GetProfilePicture(id, height, width);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new ByteArrayContent(image);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");

            return response;
        }

        [HttpGet]
        [Route("GetProfilePictureBase64")]
        public IHttpActionResult GetProfilePictureBase64(Guid id, int height, int width)
        {
            byte[] image = ImageService.GetProfilePicture(id, height, width);
            string base64String = Convert.ToBase64String(image);            

            return Ok(base64String);
        }
    }
}
