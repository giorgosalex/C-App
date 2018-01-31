using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using App15.ViewModels;
using System.Net;
using Windows.UI.Xaml.Media.Imaging;
using System.Net.Http;

namespace App15
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            ViewPosts viewp = new ViewPosts();
            BindingContext = viewp;

            List<string> comments = new List<string>
            {
                "aaaaaaaaaaaaaaa", "bbbbbbbbbbbbbbbbbbbbbbbbbb", "ccccccccccccccccccccccccccc"
            };

            InitializeComponent();
            

            HomeListView.ItemsSource = viewp.posts.result;
            

            /*HomeListView.ItemsSource = new List<Post>
            {
                new Post
                {
                    full_name = "Galex",
                    description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    myurl = "https://www.xamarin.com/content/images/pages/forms/example-app.png"
                },
                new Post
                {
                    full_name = "Galex",
                    description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    myurl = "https://infra-gateway.d4science.org/image/user_male_portrait?img_id=35744387&img_id_token=VE5DUP516O6ejB0jqdgrc3v97KA%3D"
                }
            };*/
        }

        /*private void Button_OnClicked(Object sender, EventArgs e)
        {
            string text = MainEntry.Text;

            MainLabel.Text = "Hello" + text;
        }*/

        private async void NavigateButton_OnClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private void PostsDoneRecognizer_OnTapped(Object sender, EventArgs e)
        {
            BackgroundColor = Color.Aqua;
        }

        private void LikesDoneRecognizer_OnTapped(Object sender, EventArgs e)
        {
            BackgroundColor = Color.White;
        }

        private void RepliesDoneRecognizer_OnTapped(Object sender, EventArgs e)
        {
            BackgroundColor = Color.Gray;
        }

        private void LikesGotRecognizer_OnTapped(Object sender, EventArgs e)
        {
            BackgroundColor = Color.Transparent;
        }

        private void RepliesGotRecognizer_OnTapped(Object sender, EventArgs e)
        {
            BackgroundColor = Color.Maroon;
        }
    }
}
