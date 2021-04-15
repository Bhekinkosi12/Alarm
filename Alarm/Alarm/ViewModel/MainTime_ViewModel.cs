using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Timers;
using System.Threading.Tasks;

namespace Alarm.ViewModel
{
    class MainTime_ViewModel : BaseModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Timer timer = new Timer();
        protected void OnProperty(string name)
        {
            var handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }

        }




        DateTime time = DateTime.Now;
        
        
        public DateTime Data { get; set; }

        private string hours;
        public string Hours {

            get { return hours; }

            set {  hours = value;
                OnProperty("Hours");   
            }
        
        }

        //Timers


        
        private string secondsT;
        public string SecondsT
        {
            get => secondsT;
            set
            {
                secondsT = value;
                OnProperty(nameof(SecondsT));
            }
        }


        private string minutes;
        public string Minutes {

            get { return minutes; }

            set {  minutes = value;

                OnProperty("Minutes");
            }
        
        }

        private string seconds;
        public string Seconds {
            get { return seconds; }

            set {  seconds = value;
                OnProperty("Seconds");
            }
        }

        private string pm_am;
        public string Pm_Am {
            get { return pm_am; }

            set {
                pm_am = value;
                    
                OnProperty("Pm_am");
            }
        
        }


        public  MainTime_ViewModel()
        {
            

           
                hours = time.Hour.ToString();

                minutes = time.Minute.ToString();

                seconds = time.Second.ToString();

                

                

                

            



            

            defaltData();

            


        }
        public Boolean HourLenght()
        {
            if(time.Hour.ToString().Length == 2)
            {
                return true;

            }
            else
            {

                return false;
            }

        }









        public List<AlarmViewModel> DataAccess { get => ShowData();

           set
            {
                
                 alarmViewModels = value;
                OnProperty(nameof(DataAccess));
            }
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



        public void AddNewItem(string item)
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
                LastTime = "07.00 AM"

            };
            var data1 = new AlarmViewModel
            {
                 LastTime = "04:00 AM"
            };


            alarmViewModels.Add(data);
            alarmViewModels.Add(data1);
        }


    }


}
