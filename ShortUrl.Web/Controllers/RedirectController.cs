using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShortUrl.Web.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            return View();

            //var urlSegment = filterContext.HttpContext.Request.Url.Segments.LastOrDefault();
            //if (string.IsNullOrEmpty(urlSegment))
            //{
            //    base.OnActionExecuting(filterContext);
            //    return;
            //}

            //UrlWrapper shortenedUrl = _urlRepository.GetExistingUrls().FirstOrDefault(x => x.ShortenedUrl.Equals(urlSegment, StringComparison.InvariantCultureIgnoreCase));
            //if (shortenedUrl == null)
            //{
            //    base.OnActionExecuting(filterContext);
            //    return;
            //}

            //filterContext.Result = new RedirectResult(shortenedUrl.Url);
            //return;
        }
    }
}