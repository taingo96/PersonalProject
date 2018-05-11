﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Project.SlideNavigatorPackage
{
    public class SlideNavigator
    {
        private readonly ISlideNavigationSubject _slideNavigationSubject;
        private readonly object[] _slides;
        private readonly LinkedList<SlideNavigatorFrame> _historyLinkedList = new LinkedList<SlideNavigatorFrame>();
        private LinkedListNode<SlideNavigatorFrame> _currentPositionNode = null;

        public SlideNavigator(ISlideNavigationSubject slideNavigationSubject, object[] slides)
        {
            if (slideNavigationSubject == null) throw new ArgumentNullException(nameof(slideNavigationSubject));
            if (slides == null) throw new ArgumentNullException(nameof(slides));

            _slideNavigationSubject = slideNavigationSubject;
            _slides = slides;
        }

        public void GoTo(int slideIndex)
        {
            GoTo(slideIndex, () => { });
        }

        UserControl CurrentSlide { get; set; }

        public void GoTo(int slideIndex, Action setupSlide)
        {
            if (_currentPositionNode == null)
            {
                _currentPositionNode = new LinkedListNode<SlideNavigatorFrame>(new SlideNavigatorFrame(slideIndex, setupSlide));
                _historyLinkedList.AddLast(_currentPositionNode);
            }
            else
            {
                var newNode = new LinkedListNode<SlideNavigatorFrame>(new SlideNavigatorFrame(slideIndex, setupSlide));
                _historyLinkedList.AddAfter(_currentPositionNode, newNode);
                _currentPositionNode = newNode;
                var tail = newNode.Next;
                while (tail != null)
                {
                    _historyLinkedList.Remove(tail);
                    tail = tail.Next;
                }
            }


            CurrentSlide = (UserControl)_slides[_currentPositionNode.Value.SlideIndex];
            var tidyable = CurrentSlide.DataContext as ITidyable;

            //var tidyable = _slides[_currentPositionNode.Value.SlideIndex] as ITidyable;
            tidyable?.Tidy();
            setupSlide();
            GoTo(_currentPositionNode);
        }

        public void GoBack()
        {
            if (_currentPositionNode?.Previous == null) return;

            _currentPositionNode = _currentPositionNode.Previous;
            GoTo(_currentPositionNode);
        }

        public void GoForward()
        {
            if (_currentPositionNode?.Next == null) return;

            _currentPositionNode = _currentPositionNode.Next;
            GoTo(_currentPositionNode);
        }

        private void GoTo(LinkedListNode<SlideNavigatorFrame> node)
        {
            _slideNavigationSubject.ActiveSlideIndex = node.Value.SlideIndex;
        }
    }
}
