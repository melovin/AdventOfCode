using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counting
{
    public class Counter
    {
        public int CountCalories(string path)
        {
            int result = 0;
            int temp = 0;
            StreamReader reader = new(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if(line == "")
                {
                    if (temp > result)
                        result = temp;
                    temp = 0;
                    continue;
                }
                temp += int.Parse(line);
            }
            reader.Close();
            return result;
        }
        public int CountBiggestThree(string path)
        {
            int result = 0;
            int temp = 0;
            int[] pole = new int[3];
            StreamReader reader = new(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == "")
                {
                    int index = this.FindSmallest(pole);
                    if (temp > pole[index])
                        pole[index] = temp;
                           
                    temp = 0;
                    continue;
                }
                temp += int.Parse(line);
            }
            result = pole.Sum();
            reader.Close();
            return result;
        }
        public int FindSmallest(int[] pole)
        {
            int index = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < pole[index])
                    index = i;
            }
            return index;
        }
    }
}
