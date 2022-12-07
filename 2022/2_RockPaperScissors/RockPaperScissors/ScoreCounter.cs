using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ScoreCounter
    {
        public int Count(string path)
        {
            int result = 0;
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                switch (line[0])
                {
                    case (char)Weapon.ROCK:
                        if (line[2] == (char)Weapon.MYROCK)
                            result += (int)WeaponPoints.ROCK + (int)Points.DRAW;
                        else if (line[2] == (char)Weapon.MYPAPER)
                            result += (int)WeaponPoints.PAPER + (int)Points.WIN;
                        else
                            result += (int)WeaponPoints.SCISSORS;
                        break;
                    case (char)Weapon.PAPER:
                        if (line[2] == (char)Weapon.MYPAPER)
                            result += (int)WeaponPoints.PAPER + (int)Points.DRAW;
                        else if(line[2] == (char)Weapon.MYSCISSORS)
                            result += (int)WeaponPoints.SCISSORS + (int)Points.WIN;
                        else
                            result += (int)WeaponPoints.ROCK;
                        break;
                    default:
                        if(line[2] == (char)Weapon.MYSCISSORS)
                            result += (int)WeaponPoints.SCISSORS + (int)Points.DRAW;
                        else if( line[2] == (char)Weapon.MYROCK)
                            result += (int)WeaponPoints.ROCK + (int)Points.WIN;
                        else
                            result += (int)WeaponPoints.PAPER;
                        break;                  
                }

            }
            reader.Close();
            return result;
        }
        public int CountPossible(string path)
        {
            int result = 0;
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                switch (line[0])
                {
                    case (char)Weapon.ROCK:
                        if (line[2] == (char)WantedOutcome.LOSS)
                            result += (int)WeaponPoints.SCISSORS + (int)Points.LOSS;
                        else if (line[2] == (char)WantedOutcome.DRAW)
                            result += (int)WeaponPoints.ROCK + (int)Points.DRAW;
                        else
                            result += (int)WeaponPoints.PAPER + (int)Points.WIN;
                        break;
                    case (char)Weapon.PAPER:
                        if (line[2] == (char)WantedOutcome.LOSS)
                            result += (int)WeaponPoints.ROCK + (int)Points.LOSS;
                        else if (line[2] == (char)WantedOutcome.DRAW)
                            result += (int)WeaponPoints.PAPER + (int)Points.DRAW;
                        else
                            result += (int)WeaponPoints.SCISSORS + (int)Points.WIN;
                        break;
                    default:
                        if (line[2] == (char)WantedOutcome.LOSS)
                            result += (int)WeaponPoints.PAPER + (int)Points.LOSS;
                        else if (line[2] == (char)WantedOutcome.DRAW)
                            result += (int)WeaponPoints.SCISSORS + (int)Points.DRAW;
                        else
                            result += (int)WeaponPoints.ROCK + (int)Points.WIN;
                        break;
                }
            }
            reader.Close();
            return result;
        }
    }
    public enum Weapon
    {
        ROCK = 'A',
        MYROCK = 'X',
        PAPER = 'B',
        MYPAPER = 'Y',
        SCISSORS = 'C',
        MYSCISSORS = 'Z'
    }
    public enum Points
    {
        WIN = 6,
        DRAW = 3,
        LOSS = 0
    }
    public enum WeaponPoints
    {
        ROCK = 1,
        PAPER = 2,
        SCISSORS = 3
    }
    public enum WantedOutcome
    {
        LOSS = 'X',
        DRAW = 'Y',
        WIN = 'Z'
    }
}
