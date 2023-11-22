using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZaripovEO.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int x = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length - 1; i++)
                    {
                        if (Char.IsDigit(line[i]) && Char.IsDigit(line[i + 1]) && (Char.IsLetter(line[i + 2]) || Char.IsWhiteSpace(line[i + 2])))
                        {
                            count++;
                        }
                        else if (Char.IsDigit(line[i]) && Char.IsDigit(line[i + 1]) && Char.IsDigit(line[i + 2]))
                        {
                            i += 2;
                        }
                    }
                }
                return count;
            }       
        }
    }
}
