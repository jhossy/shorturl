using ShortUrl.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.Library.Interfaces
{
    public interface IUrlRepository
    {
        IEnumerable<UrlWrapper> GetExistingUrls();

        void AddUrl(UrlWrapper urlToAdd);

        bool Exists(UrlWrapper inputUrl);
    }
}
