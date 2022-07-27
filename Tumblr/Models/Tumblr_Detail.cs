using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tumblr_API.Models
{
    public class Tumblr_Detail
    {
        public mainTumblrLog tumblelog { get; set; }

        public int posts_start { get; set; }

        public int posts_total { get; set; }

        public string posts_type { get; set; }

        public IList<Post_Details> posts { get; set; }
    }
}
