using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortUrl.Library.Abstracts
{
    public abstract class UrlWrapper
    {
        [Url]
        [Required]
        public string Url { get; set; }

        [Url]
        [Required]
        public string ShortenedUrl { get; set; }        
    }   
}
