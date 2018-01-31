using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App15
{
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void HomePageRecognizer_OnTapped(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
