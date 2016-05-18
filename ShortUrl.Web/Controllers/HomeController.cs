using ShortUrl.Library.Abstracts;
using ShortUrl.Library.Interfaces;
using ShortUrl.Library.Models;
using ShortUrl.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShortUrl.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUrlRepository _urlRepository = UrlRepository.Instance;
                
        public HomeController()
        {
            
        }

        public HomeController(IUrlRepository urlRepository)
        {
            this._urlRepository = urlRepository;
        }

        public ActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel();
            viewModel.ExistingUrls = _urlRepository.GetExistingUrls();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HomeViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", viewModel);
            }

            TheUrlWrapper urlToAdd = new TheUrlWrapper()
            {
                Url = viewModel.NewUrl.Url,
                ShortenedUrl = viewModel.NewUrl.ShortenedUrl
            };

            if (!_urlRepository.Exists(viewModel.NewUrl))
            {
                throw new Exception("Url already exists");
            }
            
            _urlRepository.AddUrl(urlToAdd);

            return RedirectToAction("Index");
        }
    }
}