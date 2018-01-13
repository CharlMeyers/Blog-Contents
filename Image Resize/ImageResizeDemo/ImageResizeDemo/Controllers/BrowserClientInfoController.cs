﻿using ImageResizeDemo.Models;
using ImageResizeDemo.Mappers;
using System.Web.Http;
using Microsoft.Practices.Unity;
using ImageResize.Service;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;

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
            var clientBrowserInfo = BrowserClientInfoDTOMapper.MapToDomain(clientBrowserInfoDTO);

            ClientBrowserInfoService.Create(clientBrowserInfo);

            var cookie = new CookieHeaderValue("ClientBrowserInfoId", clientBrowserInfo.BrowserClientID.ToString());
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
