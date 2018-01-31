using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App15.Models;
using System.Diagnostics;
using System.Net.Http;
using ModernHttpClient;
using Newtonsoft.Json;

namespace App15.ViewModels
{
    class ViewPosts
    {
        public VrePosts posts { get; set; }

        public ViewPosts()
        {

            posts = GetPosts_Request().Result;

            foreach (var post in posts.result)
            {
                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime date = start.AddMilliseconds(post.time).ToLocalTime();

                switch (date.Month)
                {
                    case 1:
                        post.date = "January ";
                        break;
                    case 2:
                        post.date = "February ";
                        break;
                    case 3:
                        post.date = "March ";
                        break;
                    case 4:
                        post.date = "April ";
                        break;
                    case 5:
                        post.date = "May ";
                        break;
                    case 6:
                        post.date = "June ";
                        break;
                    case 7:
                        post.date = "July ";
                        break;
                    case 8:
                        post.date = "August ";
                        break;
                    case 9:
                        post.date = "September ";
                        break;
                    case 10:
                        post.date = "October ";
                        break;
                    case 11:
                        post.date = "November ";
                        break;
                    case 12:
                        post.date = "December ";
                        break;
                }
                post.date += date.Day + " " + date.Year + ", " + date.Hour + ":" + date.Minute;

                //post.thumbnail_url = "https://infra-gateway.d4science.org:443" + post.thumbnail_url;
                post.comments.Add("aaaaaaaaaaaaaaaaaaaaaaa");
                post.comments.Add("bbbbbbbbbbbbbbbbbbbbbbb");
                post.comments.Add("ccccccccccccccccccccccc");
            }
        }

        private async Task<VrePosts> GetPosts_Request()
        {
            HttpClient client = new HttpClient(new NativeMessageHandler());

            HttpResponseMessage response = await client.GetAsync("https://socialnetworking1.d4science.org/social-networking-library-ws/rest/2/posts/get-posts-vre?gcube-token=994e41a4-01fb-4c6b-b953-24d02c8a5949-843339462").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var posts = JsonConvert.DeserializeObject<VrePosts>(content);
                //Debug.WriteLine(myprofile.result.fullname);
                return posts;
            }
            else
            {
                Debug.WriteLine("Why the fuck");
            }
            return null;
        }
    }
}
