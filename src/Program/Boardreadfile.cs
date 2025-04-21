namespace Ucu.Poo.GameOfLife;

using System.IO;

class Boardreadfile
{
    public static void Main()
    {
        string url = "board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');

        bool[,] board = new bool[contentLines.Length, contentLines[0].Trim().Length];

        for (int y = 0; y < contentLines.Length; y++)
        {
            string line = contentLines[y].Trim();
            for (int x = 0; x < line.Length; x++)
            {
                if (line[x] == '1')
                {
                    board[y, x] = true;
                }
            }
        }
    }    
}    