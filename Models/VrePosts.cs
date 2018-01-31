using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15.Models
{
    class VrePosts
    {
        public string success { get; set; }
        public string message { get; set; }
        public List<Post> result { get; set; }

        public VrePosts()
        {
            result = new List<Post>();
        }
    }

    class Post
    {
        public string key { get; set; }
        public string type { get; set; }
        public string entity_id { get; set; }
        public long time { get; set; }
        public string vreid { get; set; }
        public string uri { get; set; }
        public string uri_thumbnail { get; set; }
        public string description { get; set; }
        public string privacy { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string thumbnail_url { get; set; }
        public string comments_no { get; set; }
        public string likes_no { get; set; }
        public string link_title { get; set; }
        public string link_description { get; set; }
        public string link_host { get; set; }
        public bool application_feed { get; set; }
        public bool multi_file_upload { get; set; }

        public string date { get; set; }
        public List<string> comments { get; set; }

        public Post()
        {
            comments = new List<string>();
        }
    }
}
