using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using ModernHttpClient;
using Newtonsoft.Json;
using App15.Models;

namespace App15
{
    public class App : Application
    {
        
        
        public App()
        {
            string url = "http://socialnetworking-d-d4s.d4science.org/social-networking-library-ws/rest/2/people/profile";
            GetRequest(url);

            MainPage = new NavigationPage( new MenuPage() );
            //MainPage = new NavigationPage( new HomePage() );
            //MainPage = new MyTabbedPage2();
            /*MainPage = new TabbedPage
            {
                Children =
                {
                    new HomePage
                    {
                        Icon = "home_icon.png"
                    },
                    new VirtualWorkspacePage
                    {
                        Icon = "folder_icon.png"
                    },
                    new DataCataloguePage
                    {
                        Icon = "folder_icon.png"
                    },
                    new MessagesPage
                    {
                        Icon = "folder_icon.png"
                    }
                }
            };*/
        }

        async static void GetRequest2()
        {
            var request = HttpWebRequest.Create("http://socialnetworking-d-d4s.d4science.org/social-networking-library-ws/rest/2/users/get-profile?gcube-token=0bc91164-86a0-446e-9cbf-b0c9806f7ad3-98187548");
            request.Method = "GET";
            request.ContentType = "application/json";

            using (HttpWebResponse response = (HttpWebResponse) (await Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null)))
            {

            }
        }

        async static void GetRequest(string url)
        {
            HttpClient client = new HttpClient(new NativeMessageHandler());
            client.DefaultRequestHeaders.Add("gcube-token", "994e41a4-01fb-4c6b-b953-24d02c8a5949-843339462");
           
            //client.BaseAddress = new Uri("https://socialnetworking-d-d4s.d4science.org/social-networking-library-ws/rest");
            HttpResponseMessage response = await client.GetAsync("https://socialnetworking1.d4science.org/social-networking-library-ws/rest/2/users/get-profile?gcube-token=994e41a4-01fb-4c6b-b953-24d02c8a5949-843339462");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                //var posts = JsonConvert.DeserializeObject<VrePosts>(content);
                long unixDate = 1490149263303;
                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime date = start.AddMilliseconds(unixDate).ToLocalTime();
                Debug.WriteLine(date.ToString());
            }else
            {
                Debug.WriteLine("Why the fuck");
            }
            //client.BaseAddress = new Uri("https://www.google.com");
            //HttpResponseMessage respone = await client.PostAsync("", null);
        }

        async static void PostRequest(string url)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "gcube-token","0bc91164-86a0-446e-9cbf-b0c9806f7ad3-98187548" }
                };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(url, content);

                var responseString = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(responseString);
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
