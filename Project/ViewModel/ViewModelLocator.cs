/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:Project.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Project.Model;

namespace Project.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator:ViewModelBase
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {       
            }
            else
            {
            }

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<TimeDateLanguageViewModel>();
            SimpleIoc.Default.Register<TellerStoryViewModel>();
            SimpleIoc.Default.Register<MainFormViewModel>();
            SimpleIoc.Default.Register<TellerStoryViewModel>();
            SimpleIoc.Default.Register<SpellingGameViewModel>();
            SimpleIoc.Default.Register<ReminderViewModel>();
            SimpleIoc.Default.Register<DiscoveryViewModel>();
            SimpleIoc.Default.Register<MediaPlayViewModel>();
            SimpleIoc.Default.Register<LocazationInforViewModel>();
            SimpleIoc.Default.Register<MainContentViewModel>();
            new RegisteringGlobalMethods();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public MainWindowViewModel MainWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainWindowViewModel>();
            }
        }
        public TimeDateLanguageViewModel TimeDateLanguage
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TimeDateLanguageViewModel>();
            }
        }
        public MainFormViewModel MainForm
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainFormViewModel>();
            }
        }
        public SpellingGameViewModel SpellingGame
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SpellingGameViewModel>();
            }
        }
        public ReminderViewModel Reminder
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ReminderViewModel>();
            }
        }
        public MediaPlayViewModel MediaPlay
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MediaPlayViewModel>();
            }
        }
        public TellerStoryViewModel TellerStory
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TellerStoryViewModel>();
            }
        }
        public LocazationInforViewModel LocazationInforViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LocazationInforViewModel>();
            }
        }
        public MainContentViewModel MainContent
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainContentViewModel>();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}