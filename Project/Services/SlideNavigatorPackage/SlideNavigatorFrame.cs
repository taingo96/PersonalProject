using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.SlideNavigatorPackage
{
    internal class SlideNavigatorFrame
    {
        public SlideNavigatorFrame(int slideIndex, Action setupSlide)
        {
            SlideIndex = slideIndex;
            SetupSlide = setupSlide;
        }

        public int SlideIndex { get; }

        public Action SetupSlide { get; }
    }
}
