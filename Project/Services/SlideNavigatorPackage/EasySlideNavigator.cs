using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.SlideNavigatorPackage
{
    public class EasySlideNavigator
    {
        // đây là class singleton
        //http://csharpindepth.com/Articles/General/Singleton.aspx
        private static EasySlideNavigator instance;
        private static readonly object padlock = new object();

        private EasySlideNavigator()
        {
        }

        public static EasySlideNavigator Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new EasySlideNavigator();
                    return instance;
                }
            }
        }

        public SlideNavigator SlideNavigator;
        public int Test;


    }
}
