using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tumblr_API.Models
{
    public class Post_Details
    {
        public string id { get; set; }
        public string url { get; set; }
        public string url_with_slug { get; set; }
        public string type { get; set; }
        public string date_gmt { get; set; }
        public DateTime date { get; set; }
        public int bookmarklet { get; set; }
        public int mobile { get; set; }
        public string feed_item { get; set; }
        public int from_feed_id { get; set; }
        public int unix_timestamp { get; set; }
        public string format { get; set; }
        public string reblog_key { get; set; }
        public string slug { get; set; }
        public bool is_submission { get; set; }
        public string like_button { get; set; }
        public string reblog_button { get; set; }
        public string note_count { get; set; }

        public tumblelog tumblelog { get; set; }

        public string photo_caption { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string photo_url_1280 { get; set; }
        public string photo_url_500 { get; set; }
        public string photo_url_400 { get; set; }
        public string photo_url_250 { get; set; }
        public string photo_url_100 { get; set; }
        public string photo_url_75 { get; set; }

        public IList<photos> photos { get; set; }

        public List<string> tags { get; set; }
    }
}
