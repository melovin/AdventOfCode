using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CampCleanup
{
    public class Overlap
    {
        public int CountOverlaps(string path)
        {
            int result = 0;
            StreamReader reader = new StreamReader(path);
            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                string[] lines = line.Split(',');
                string[] numLeft = lines[0].Split('-');
                string[] numRight = lines[1].Split('-');
                //int maxLeft = Math.Max(Int16.Parse(numLeft[0]), Int16.Parse(numRight[0]));
                if (Int16.Parse(numLeft[0]) <= Int16.Parse(numRight[0]) && Int16.Parse(numLeft[1]) >= Int16.Parse(numRight[1]) || Int16.Parse(numRight[0]) <= Int16.Parse(numLeft[0]) && Int16.Parse(numRight[1]) >= Int16.Parse(numLeft[1]))
                    result++;
                //int min
            }
            return result;
        }
        public int CountAllOverlaps(string path)
        {
            int result = 0;
            StreamReader reader = new StreamReader(path);
            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                string[] lines = line.Split(',');
                string[] numLeft = lines[0].Split('-');
                string[] numRight = lines[1].Split('-');
                if (Int16.Parse(numRight[0]) >= Int16.Parse(numLeft[0]) && Int16.Parse(numRight[0]) <= Int16.Parse(numLeft[1]) || Int16.Parse(numLeft[0]) >= Int16.Parse(numRight[0]) && Int16.Parse(numLeft[0]) <= Int16.Parse(numRight[1]))
                    result++;
            }
            return result;
        }
    }
}
