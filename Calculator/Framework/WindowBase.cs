using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Framework
{
    public class WindowBase
    {
        private Window _window;
        private bool _initialize;
        private IUIItem[] _uiItems;

        public WindowBase(Window window)
        {
            _window = window;
        }

        public Window Window {
            get { return _window; }
        }


        public void Initialize() {
            if (!_initialize) {
                _uiItems = _window.GetMultiple(SearchCriteria.All);
                _initialize = true;
            }
        }
    }
}
