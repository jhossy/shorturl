using ShortUrl.Library.Abstracts;
using ShortUrl.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortUrl.Library.Models
{
    public class UrlRepository : IUrlRepository
    {
        public List<UrlWrapper> _urls = new List<UrlWrapper>();

        private static UrlRepository _instance;
        public static UrlRepository Instance 
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UrlRepository();
                }
                return _instance;
            }
        }

        public void AddUrl(UrlWrapper urlToAdd)
        {
            _urls.Add(urlToAdd);
        }

        public IEnumerable<UrlWrapper> GetExistingUrls()
        {
            return _urls;
        }

        public bool Exists(UrlWrapper inputUrl)
        {
            if (_urls.Any(x => x.Equals(inputUrl)))
            {
                return false;
            }

            if (_urls.Any(x => x.Url.Equals(inputUrl.Url)) 
                || _urls.Any(x => x.ShortenedUrl.Equals(inputUrl.ShortenedUrl, StringComparison.InvariantCultureIgnoreCase)))
            {
                return false;
            }
            
            return true;
        }
    }
}
