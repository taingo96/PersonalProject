using GalaSoft.MvvmLight;
using Project.SlideNavigatorPackage;
using Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class MainContentViewModel : ViewModelBase, ISlideNavigationSubject
    {
        private readonly SlideNavigator _slideNavigator;
        public int IndexOfSlide<TSlide>()
        {
            return Slides.Select((o, i) => new { o, i }).First(a => a.o.GetType() == typeof(TSlide)).i;
        }
        public MainContentViewModel()
        {
            Slides = new object[] { TellerStory, MainForm, Reminder, LocazationInfor, SpellingGame, Discovery, MediaPlay };
            _slideNavigator = new SlideNavigator(this, Slides);
            _slideNavigator.GoTo(0);
            EasySlideNavigator.Instance.SlideNavigator = _slideNavigator;
        }
        public object[] Slides { get; }
        public MainForm MainForm { get; } = new MainForm();
        public TellerStory TellerStory { get; } = new TellerStory();
        public Reminder Reminder { get; } = new Reminder();
        public LocazationInforViewModel LocazationInfor { get; } = new LocazationInforViewModel();
        public SpellingGame SpellingGame { get; } = new SpellingGame();
        public DiscoveryViewModel Discovery { get; } = new DiscoveryViewModel();
        public MediaPlay MediaPlay { get; } = new MediaPlay();

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

    }
}
