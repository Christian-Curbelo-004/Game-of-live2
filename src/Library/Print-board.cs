using System;
using System.Text;
using System.Threading;

namespace PrintBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 10;
            int height = 5;
            bool[,] b = new bool[width, height];

            b[1, 1] = true;
            b[2, 2] = true;
            b[3, 3] = true;

            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (b[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n"); 
                }

                Console.WriteLine(s.ToString());
                Thread.Sleep(300);
            }
        }
    }
}
