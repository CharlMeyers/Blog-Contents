using ImageResize.Service;
using Microsoft.Practices.Unity;
using System;
using System.IO;
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
            CookieHeaderValue cookie = Request.Headers.GetCookies("ClientBrowserInfoId").FirstOrDefault();

            Guid clientBrowserInfoId = Guid.Parse(cookie["ClientBrowserInfoId"].Value);
            var clientBrowserInfo = ClientBrowserInfoService.GetById(clientBrowserInfoId);

            byte[] image = ImageService.GetImageByName(imageName, clientBrowserInfo.DisplayResolutionHeight, clientBrowserInfo.DisplayResolutionWidth);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new ByteArrayContent(image);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpg");

            return response;
        }
    }
}
