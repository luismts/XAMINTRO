using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMINTRO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Tus eventos van aqui
        private async void joinUsBtn_Clicked(object sender, EventArgs e)
        {
            var list = new string[] { "Facebook", "Telegram", "Whatsapp" };
            var resp = await DisplayActionSheet("Únete a nosotros en:", "", null, list);

            switch (resp)
            {
                case "Facebook":
                    //Device.OpenUri(new Uri("https://www.facebook.com/groups/XamarinUniverse")); //English
                    Device.OpenUri(new Uri("https://www.facebook.com/groups/UniversoXamarin/")); //Spanish
                    break;
                case "Telegram":
                    //Device.OpenUri(new Uri("https://t.me/joinchat/B4AGWhFRPcNHt6tn7MZR8Q")); //English
                    Device.OpenUri(new Uri("https://t.me/joinchat/B4AGWhJ2bt4WhMvYx65_rA")); //Spanish
                    break;
                case "Whatsapp":
                    //Device.OpenUri(new Uri("https://chat.whatsapp.com/1TzGSXaB1wv75mAUW2JGvs")); //English
                    Device.OpenUri(new Uri("https://chat.whatsapp.com/HPxFDgTx1da2NZZNNKv4XH")); //Spanish
                    break;
                default:
                    break;
            }
        }
        
        private async void startBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert(":)", "Vamos bien!", "Ok");
        }
    }
}
