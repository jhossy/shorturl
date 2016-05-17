using ShortUrl.Library.Abstracts;
using ShortUrl.Library.Interfaces;
using ShortUrl.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortUrl.Web.Models.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            this.NewUrl = new TheUrlWrapper();
            this.ExistingUrls = new List<TheUrlWrapper>();
        }

        public IEnumerable<UrlWrapper> ExistingUrls { get; set; }
        
        public UrlWrapper NewUrl { get; set; }
    }
}