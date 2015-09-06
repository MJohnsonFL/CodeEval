using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboAndRobitta
{
    /// <summary>
    /// Program written by Michael P. Johnson
    /// for the Robo and Robitta Challenge found on
    /// https://www.codeeval.com/open_challenges/212/
    /// </summary>
    class RoboAndRobitta
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('|');
                    int MapX = Int32.Parse(line[0].Substring(0, line[0].IndexOf('x')));
                    int MapY = Int32.Parse(line[0].Substring(line[0].IndexOf('x') + 1));
                    int RobittaX = Int32.Parse(line[1].Trim().Substring(0, line[1].Trim().IndexOf(' ')));
                    int RobittaY = Int32.Parse(line[1].Trim().Substring(line[1].Trim().IndexOf(' ') + 1));

                    Map map = new Map(MapX, MapY, RobittaX, RobittaY);
                    Robo robo = new Robo();
                    int NutCount = 0;

                    do
                    {
                        map.getNut(robo);
                        NutCount++;
                        robo.Forward(map);
                    } while (!map.RobittaFound);

                    Console.WriteLine(NutCount);
                }
            }
        }
    }

    class Robo
    {
        public int X;
        public int Y;

        public char Direction;

        public Robo()
        {
            X = 0;
            Y = 0;
            Direction = 'e';
        }

        public void Turn()
        {
            switch (Direction)
            {
                case 'e':
                    Direction = 's';
                    break;
                case 's':
                    Direction = 'w';
                    break;
                case 'w':
                    Direction = 'n';
                    break;
                case 'n':
                    Direction = 'e';
                    break;
            }
        }

        public void Forward(Map map)
        {
            switch (Direction)
            {
                case 'e':
                    if ((map.grid.GetLength(1) == X + 1) || (map.grid[Y, X + 1] == 0))
                    {
                        Turn();
                        Forward(map);
                    }
                    else
                        X++;
                    break;
                case 's':
                    if ((Y == map.grid.GetLength(0) - 1) || (map.grid[Y + 1, X] == 0))
                    {
                        Turn();
                        Forward(map);
                    }
                    else
                        Y++;
                    break;
                case 'w':
                    if ((X == 0) || (map.grid[Y, X - 1] == 0))
                    {
                        Turn();
                        Forward(map);
                    }
                    else
                        X--;
                    break;
                case 'n':
                    if (map.grid[Y - 1, X] == 0) // No need to test Y == 0 because we start at 0,0 heading East
                    {
                        Turn();
                        Forward(map);
                    }
                    else
                        Y--;
                    break;
            }
        }
    }

    class Map
    {
        public int[,] grid;
        public bool RobittaFound;

        public Map(int MapX, int MapY, int RobittaX, int RobittaY)
        {
            grid = new int[MapY, MapX]; // All arrays in C# are initialized to 0
            FillArrayWithNuts();
            grid[grid.GetLength(0) - RobittaY, RobittaX - 1] = 2;
            RobittaFound = false;
        }


        public void getNut(Robo robo)
        {
            grid[robo.Y, robo.X] -= 1;
            if (grid[robo.Y, robo.X] == 1)
                RobittaFound = true;
        }

        public bool hasNut(int x, int y)
        {
            if (grid[x, y] == 1)
                return true;
            return false;
        }

        private void FillArrayWithNuts()
        {
            for (int y = 0; y < grid.GetLength(0); y++)
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    grid[y, x] = 1;
                }
        }
    }
}
