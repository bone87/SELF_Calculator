using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;
using System.Threading;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestInitialize]
        public void TestInit()
        {
            CalcFactory.Instance.Launch();
            MainWindow mainWindow = new MainWindow("Calculator");
            mainWindow.getButtonWithText("1").Click();
            Thread.Sleep(100);
            mainWindow.getButtonWithText("2").Click();
            mainWindow.getButtonWithText("Add").Click();
            mainWindow.getButtonWithText("9").Click();
            mainWindow.getButtonWithText("9").Click();
            mainWindow.getButtonWithText("9").Click();
            mainWindow.getButtonWithText("Equals").Click();
            mainWindow.getButtonWithText("Memory add").Click();
            mainWindow.getButtonWithText("1").Click();
            mainWindow.getButtonWithText("9").Click();
            mainWindow.getButtonWithText("Add").Click();
            mainWindow.getButtonWithText("Memory recall").Click();
            mainWindow.getButtonWithText("Equals").Click();
            // mainWindow.MenuBar.MenuItem("View", "Scientific").Click();
            Thread.Sleep(3100);

        }

        [TestMethod]
        public void Test1() {
            }

        [TestCleanup]
        public void TestCleanUp()
        {
            CalcFactory.Instance.Dispose();
        }
    }
}
