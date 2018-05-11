using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Project.ViewModel
{
  public  class TimeDateLanguageViewModel:ViewModelBase
    {
        public TimeDateLanguageViewModel()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timeElapsed;
            timer.Start();
        }

        private void timeElapsed(object sender, ElapsedEventArgs e)
        {
            TimeNow = DateTime.Now;
        }

        private DateTime _timeNow;
        public DateTime TimeNow
        {
            get { return _timeNow; }
            set
            {
                _timeNow = value;
                RaisePropertyChanged();

            }
        }
    }
}
