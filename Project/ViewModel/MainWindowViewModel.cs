using GalaSoft.MvvmLight;
using Project.Control;
using Project.SlideNavigatorPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
   public class MainWindowViewModel:ViewModelBase, ISlideNavigationSubject
    {
        private readonly SlideNavigator slideNavigator;
        private readonly ControlService _controlService;
        
        public object[] Slides { get; }
        public MainWindowViewModel()
        {
           // _controlService = ControlService;
            Slides = new object[] { BlackScreen,ShowScreen, LowBattery};
            slideNavigator = new SlideNavigator(this, Slides);
            slideNavigator.GoTo(1);
            
        }
        public ShowScreen ShowScreen { get; } = new ShowScreen();
        public BlackScreen BlackScreen { get; } = new BlackScreen();
        public LowBattery LowBattery { get; } = new LowBattery();
        private int _activeSlideIndex;
        public int ActiveSlideIndex
        {
            get { return _activeSlideIndex; }
            set
            {
                _activeSlideIndex = value;
                RaisePropertyChanged();
            }
        }
        public int IndexOfSlide<TSlide>()
        {
            return Slides.Select((o, i) => new { o, i }).First(a => a.o.GetType() == typeof(TSlide)).i;
        }
    }
}
