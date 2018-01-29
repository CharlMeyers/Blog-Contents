using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ImageResizeDemo.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View("Error");
        }

        public ActionResult NotFound()
        {
            Response.StatusCode = (int) HttpStatusCode.NotFound;
            return View("NotFound");
        }

        public ActionResult ServerError()
        {
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return View("InternalServerError");
        }

        public ActionResult BadRequest()
        {
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return View("BadRequest");
        }
    }
}