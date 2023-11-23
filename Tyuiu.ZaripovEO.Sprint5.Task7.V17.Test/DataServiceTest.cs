using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaripovEO.Sprint5.Task7.V17.Lib;
using System.IO;

namespace Tyuiu.ZaripovEO.Sprint5.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidPath()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
