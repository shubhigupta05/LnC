using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tumblr_API.Models
{
    public class mainTumblrLog
    {
        public string title { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string timezone { get; set; }
        public bool cname { get; set; }
        public string[] feeds { get; set; }
    }
}
