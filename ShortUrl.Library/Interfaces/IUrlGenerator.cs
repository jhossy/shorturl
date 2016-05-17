using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.Library.Interfaces
{
    interface IUrlGenerator
    {
        string GenerateShortUrl(string inputUrl);        
    }
}
