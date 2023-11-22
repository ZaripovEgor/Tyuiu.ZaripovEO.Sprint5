using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.ZaripovEO.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            double res = 10;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if ((Math.Round(Convert.ToDouble(line),1) == 2))
                    {
                        res = Convert.ToDouble(line);
                    } 
                }
            }
            return res;
        }
    }
}