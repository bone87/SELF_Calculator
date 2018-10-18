using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;

namespace Framework
{
    public class CalcFactory : IDisposable
    {
        private static CalcFactory _instance;

        public static CalcFactory Instance
        {
            get { return _instance ?? (_instance = new CalcFactory()); }
        }

        private const string CalculatorExecPath = "D:\\PROJECTS\\Self\\Calculator\\classic_calculator_x64\\Calc 64-bit\\calc1.exe";
        private Application _calcApp;

        public Application getCalc() {
            return _calcApp; 
        }
        public void Launch() {
            if (_calcApp == null)
                _calcApp = Application.Launch(CalculatorExecPath);
        }

        public void Dispose()
        {
            _calcApp.Close();
            _calcApp.Dispose();
            _calcApp = null;
            _instance = null;
        }
    }
}
