using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace fifthfebruarylesson
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            GestureLabel.Text = "Xamarin";
        }

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            LinkLabel.TextColor = Color.Purple;
            Browser.OpenAsync("https://google.rs");
        }
    }
}
