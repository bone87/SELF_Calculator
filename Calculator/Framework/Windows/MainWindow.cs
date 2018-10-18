using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace Framework
{
    public class MainWindow
    {
        private Window calcWindow;
        public MainWindow(string windowName)
        {
            calcWindow = CalcFactory.Instance.getCalc().GetWindow(windowName);
        }

        public Window CalcWindow {
            get { return calcWindow; }
        }

        public MenuBar MenuBar {
            get { return calcWindow.MenuBar; }
        }

        public Button getButtonWithText(string text) {
            return calcWindow.Get<Button>(SearchCriteria.ByText(text));
        }
    }
}
