using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App15.Models;
using System.Net.Http;
using ModernHttpClient;
using Newtonsoft.Json;
using System.Diagnostics;

namespace App15.ViewModels
{
    class ViewProfile
    {
        public MyProfile profile { get; set; }

        public ViewProfile()
        {
            
            profile = GetProfile_Request().Result;
            


            Debug.WriteLine(profile.result.fullname);
        }

        private async Task<MyProfile> GetProfile_Request()
        {
            HttpClient client = new HttpClient(new NativeMessageHandler());

            HttpResponseMessage response = await client.GetAsync("https://socialnetworking1.d4science.org/social-networking-library-ws/rest/2/users/get-profile?gcube-token=994e41a4-01fb-4c6b-b953-24d02c8a5949-843339462").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var profile = JsonConvert.DeserializeObject<MyProfile>(content);
                //Debug.WriteLine(myprofile.result.fullname);
                return profile;
            }
            else
            {
                Debug.WriteLine("Why the fuck");
            }
            return null;
        } 
    }
}
