using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tumblr_API.Models
{
    public class tumblelog
    {
        public string title { get; set; }
        public string name { get; set; }
        public bool cname { get; set; }
        public string url { get; set; }
        public string timezone { get; set; }
        public string avatar_url_512 { get; set; }
        public string avatar_url_128 { get; set; }
        public string avatar_url_96 { get; set; }
        public string avatar_url_64 { get; set; }
        public string avatar_url_48 { get; set; }
        public string avatar_url_40 { get; set; }
        public string avatar_url_30 { get; set; }
        public string avatar_url_24 { get; set; }
        public string avatar_url_16 { get; set; }
    }
}
