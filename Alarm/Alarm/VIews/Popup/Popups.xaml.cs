using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Alarm.Model;
using Alarm.ViewModel;

namespace Alarm.VIews.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popups : Rg.Plugins.Popup.Pages.PopupPage
    {
        public Popups()
        {
            InitializeComponent();
        }
        MainTime_ViewModel alarmData = new MainTime_ViewModel();

        public void OnAnimationStarted(bool isPopAnimation)
        {
            // optional code here   
        }


        public void OnAnimationFinished(bool isPopAnimation)
        {
            // optional code here   
        }

       


        // Invoked when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Return false if you don't want to close this popup page when a background of the popup page is clicked
            return false;
        }

        private async void CloseBtn_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
        }

        private void PM_button_Clicked(object sender, EventArgs e)
        {

            PM_button.TextColor = Color.White;
            PM_button.BackgroundColor = Color.Black;
            AM_button.TextColor = Color.Black;
            AM_button.BackgroundColor = Color.White;


        }

        private void AM_button_Clicked(object sender, EventArgs e)
        {

            PM_button.TextColor = Color.Black;
            PM_button.BackgroundColor = Color.White;
            AM_button.TextColor = Color.White;
            AM_button.BackgroundColor = Color.Black;



        }

        private async void BTN_Submit_Clicked(object sender, EventArgs e)
        {
            string name = ENT_minutes.Text + ":" + ENT_Hours.Text;

            alarmData.AddNewItem(name);


            await Navigation.PushAsync(new MainPage());
        }
    }
}