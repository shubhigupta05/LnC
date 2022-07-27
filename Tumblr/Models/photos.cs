using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tumblr_API.Models
{
    public class photos
    {
        public string offset { get; set; }
        public string caption { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string photo_url_1280 { get; set; }
        public string photo_url_500 { get; set; }
        public string photo_url_400 { get; set; }
        public string photo_url_250 { get; set; }
        public string photo_url_100 { get; set; }
        public string photo_url_75 { get; set; }
    }
}
