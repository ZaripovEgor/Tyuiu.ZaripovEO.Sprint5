using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaripovEO.Sprint5.Task3.V27.Lib;
using System.IO;

namespace Tyuiu.ZaripovEO.Sprint5.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedFileExists()
        {
            string path = @"C:\Users\zarip\source\repos\Tyuiu.ZaripovEO.Sprint5\Tyuiu.ZaripovEO.Sprint5.Task3.V27\bin\Debug\OutPutFileTask3.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
