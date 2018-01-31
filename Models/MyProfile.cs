using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15.Models
{
    public class MyProfile
    {
        public String success { get; set; }
        public String message { get; set; }
        public Profile result { get; set; }

        public MyProfile()
        {
            result = new Profile();
        }
    }

    public class Profile
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string fullname { get; set; }
        public long registration_date { get; set; }
        public string user_avatar_url { get; set; }
        public bool male { get; set; }
        public string job_title { get; set; }
        public string location_industry { get; set; }
        public string custom_attrs_map { get; set; }
        public List<String> email_addresses { get; set; }
        public string screen_name { get; set; }
        public string user_avatar_id { get; set; }

        public Profile()
        {
            email_addresses = new List<string>();
        }
    }
}
