using System;
using System.Data.SqlTypes;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 10;
            int height = 5;
            bool[,] b = new bool[width,height];
            
            b[1, 3] = true;
            b[2, 2] = true;
            b[4, 1] = true;

        StringBuilder sb = new StringBuilder();

        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
        	{
                if(b[x,y])
                {
                    sb.Append("X");
                }
                else
                {
                    sb.Append("___");
                }
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb.ToString());
        }
    }
}