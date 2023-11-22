using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZaripovEO.Sprint5.Task5.V30.Lib;

namespace Tyuiu.ZaripovEO.Sprint5.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\zarip\source\repos\Tyuiu.ZaripovEO.Sprint5\Tyuiu.ZaripovEO.Sprint5.Task5.V30\bin\Debug\InPutDataFileTask5V30.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
