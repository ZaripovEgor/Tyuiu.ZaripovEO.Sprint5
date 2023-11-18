using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZaripovEO.Sprint5.Task2.V8;

namespace Tyuiu.ZaripovEO.Sprint5.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\zarip\source\repos\Tyuiu.ZaripovEO.Sprint5\Tyuiu.ZaripovEO.Sprint5.Task2.V8\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
