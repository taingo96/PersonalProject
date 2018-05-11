using Microsoft.Practices.ServiceLocation;
using Project.SlideNavigatorPackage;
using Project.ViewModel;
using Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project.ViewModel
{
  public  class RegisteringGlobalMethods
    {
        static RegisteringGlobalMethods()
        {
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(GlobalCommands.ShowSpellingGame, GlobalMethods.ShowSpellingGame));
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(GlobalCommands.ShowTellerStory, GlobalMethods.ShowTellerStory));
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(GlobalCommands.ShowReminder, GlobalMethods.ShowReminder));
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(GlobalCommands.ShowMediaPlay, GlobalMethods.ShowMediaPlay));
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(GlobalCommands.ShowLocazationInfor, GlobalMethods.ShowLocazationInfor));
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(GlobalCommands.ShowDiscovery, GlobalMethods.ShowDiscovery));
        }
    }
}
public class GlobalMethods
{
    public GlobalMethods() { }
    public static void ShowSpellingGame(object o, ExecutedRoutedEventArgs e)
    {
        int index = ServiceLocator.Current.GetInstance<MainContentViewModel>().IndexOfSlide<SpellingGame>();
        EasySlideNavigator.Instance.SlideNavigator.GoTo(index);
    }
    public static void ShowReminder(object o, ExecutedRoutedEventArgs e)
    {
        int index = ServiceLocator.Current.GetInstance<MainContentViewModel>().IndexOfSlide<Reminder>();
        EasySlideNavigator.Instance.SlideNavigator.GoTo(index);
    }
    public static void ShowDiscovery(object o, ExecutedRoutedEventArgs e)
    {
        int index = ServiceLocator.Current.GetInstance<MainContentViewModel>().IndexOfSlide<Discovery>();
        EasySlideNavigator.Instance.SlideNavigator.GoTo(index);
    }
    public static void ShowTellerStory(object o, ExecutedRoutedEventArgs e)
    {
        int index = ServiceLocator.Current.GetInstance<MainContentViewModel>().IndexOfSlide<TellerStory>();
        EasySlideNavigator.Instance.SlideNavigator.GoTo(index);
    }
    public static void ShowMediaPlay(object o, ExecutedRoutedEventArgs e)
    {
        int index = ServiceLocator.Current.GetInstance<MainContentViewModel>().IndexOfSlide<MediaPlay>();
        EasySlideNavigator.Instance.SlideNavigator.GoTo(index);
    }
    public static void ShowLocazationInfor(object o, ExecutedRoutedEventArgs e)
    {
        int index = ServiceLocator.Current.GetInstance<MainContentViewModel>().IndexOfSlide<LocazationInfor>();
        EasySlideNavigator.Instance.SlideNavigator.GoTo(index);
    }
}