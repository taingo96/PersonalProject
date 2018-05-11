using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project.ViewModel
{
   public class GlobalCommands
    {
        public static RoutedCommand ShowSpellingGame = new RoutedCommand();
        public static RoutedCommand ShowDiscovery = new RoutedCommand();
        public static RoutedCommand ShowLocazationInfor = new RoutedCommand();
        public static RoutedCommand ShowReminder = new RoutedCommand();
        public static RoutedCommand ShowMediaPlay = new RoutedCommand();
        public static RoutedCommand ShowTellerStory = new RoutedCommand();
    }
}
