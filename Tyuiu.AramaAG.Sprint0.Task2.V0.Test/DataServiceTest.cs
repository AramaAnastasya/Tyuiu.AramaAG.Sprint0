using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AramaAG.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessage()
        {
            var name = "Анастасия";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Анастасия", res);
        }
    }
}
