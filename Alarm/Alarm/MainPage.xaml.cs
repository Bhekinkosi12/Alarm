using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Alarm.VIews.Popup;
using Alarm.ViewModel;
using Alarm.Model;

namespace Alarm
{
    public partial class MainPage : ContentPage
    {


        MainTime_ViewModel AlarmData = new MainTime_ViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainTime_ViewModel();

            //First digit
            if(AlarmData.HourLenght() == true)
            {
                time_firstDigit.Text = "";


            }
            else
            {
                time_firstDigit.Text = "0";
            }

          

            
            }
   

        private async void Button_Clicked(object sender, EventArgs e)
        {
            AlarmData.clearData();
            await Navigation.PushAsync(new Popups());

        }
    }
}
