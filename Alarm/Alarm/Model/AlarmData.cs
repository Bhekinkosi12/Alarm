using System;
using System.Collections.Generic;
using System.Text;
using Alarm.ViewModel;

namespace Alarm.Model
{
    public class AlarmData
    {
        public List<AlarmViewModel> DataAccess { get => ShowData(); }

        public AlarmData()
        {

            defaltData();
        }



        private List<AlarmViewModel> alarmViewModels = new List<AlarmViewModel>();

        public List<AlarmViewModel> ShowData()
        {

            return alarmViewModels;

        }
        public void clearData()
        {

            alarmViewModels.Clear();
        }



        public void AddNewItem (string item)
        {
            var data = new AlarmViewModel
            {
                LastTime = item
            };
            alarmViewModels.Add(data);

        }


        private void defaltData()
        {
            var data = new AlarmViewModel
            {
                LastTime = "00.00 pm"

            };
            alarmViewModels.Add(data);

        }


    }
}
