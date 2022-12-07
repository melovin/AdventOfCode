using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Rucksack
{
    public class Reorganisator
    {
        private Dictionary<char, int> Letters = new Dictionary<char, int>() { 
            { 'a' ,1},
            { 'b' ,2},
            { 'c' ,3},
            { 'd' ,4},
            { 'e' ,5},
            { 'f' ,6},
            { 'g' ,7},
            { 'h' ,8},
            { 'i' ,9},
            { 'j' ,10 },
            { 'k' ,11 },
            { 'l' ,12 },
            { 'm' ,13 },
            { 'n' ,14 },
            { 'o' ,15 },
            { 'p' ,16 },
            { 'q' ,17 },
            { 'r' ,18 },
            { 's' ,19 },
            { 't' ,20 },
            { 'u' ,21 },
            { 'v' ,22 },
            { 'w' ,23 },
            { 'x' ,24 },
            { 'y' ,25 },
            { 'z' ,26 },

            { 'A' ,27 },
            { 'B' ,28 },
            { 'C' ,29 },
            { 'D' ,30 },
            { 'E' ,31 },
            { 'F' ,32 },
            { 'G' ,33 },
            { 'H' ,34 },
            { 'I' ,35 },
            { 'J' ,36 },
            { 'K' ,37 },
            { 'L' ,38 },
            { 'M' ,39 },
            { 'N' ,40 },
            { 'O' ,41 },
            { 'P' ,42 },
            { 'Q' ,43 },
            { 'R' ,44 },
            { 'S' ,45 },
            { 'T' ,46 },
            { 'U' ,47 },
            { 'V' ,48 },
            { 'W' ,49 },
            { 'X' ,50 },
            { 'Y' ,51 },
            { 'Z' ,52 }
        };
        public int SumPriorites(string path)
        {
            List<char> listOfChars = new();
            int result = 0;
            StreamReader reader = new StreamReader(path);
            bool found = false;
            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();              
                for (int i = 0; i < line.Length /2; i++)
                {
                    for (int j = line.Length/2; j < line.Length; j++)
                    {
                        if (line[i] == line[j])
                        {
                            listOfChars.Add(line[i]);
                            found = true;
                            break;
                        }
                    }
                    if(found)
                        break;
                }
                found = false;
            }
            foreach (char item in listOfChars)
            {
                result += Letters[item];
            }
            reader.Close();
            return result;
        }
        public int SumThreePriorities(string path)
        {
            int result = 0;
            List<char> listOfChars = new();
            StreamReader reader = new StreamReader(path);
            List<string> lines = new();
            bool found = false;
            while (!reader.EndOfStream)
            {
                for (int i = 0; i < 3; i++)
                {
                    lines.Add(reader.ReadLine());
                }
                for (int i = 0; i < lines[0].Length; i++)
                {
                    for (int j = 0; j < lines[1].Length; j++)
                    {
                        if (lines[0][i] == lines[1][j])
                        {
                            if (lines[2].Contains(lines[0][i]))
                            {
                                listOfChars.Add(lines[0][i]);
                                found = true;
                                break;
                            }
                            
                        }
                    }
                    if (found)
                        break;
                }
                found = false;
                lines.Clear();
            }
            foreach (char item in listOfChars)
            {
                result += Letters[item];
            }
            reader.Close();
            return result;
        }
    }
}
