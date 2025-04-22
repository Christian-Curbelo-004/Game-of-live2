using System;
using System.Data.SqlTypes;
using System.Text;

using System.Collections.Generic;

<<<<<<< HEAD
using System.Collections.Generic;

namespace Ucu.poo.GameOfLife
=======
namespace Ucu.Poo.GameOfLife
>>>>>>> Boardreadfile
{
    public class nextmove()
    {
    using System;

    using System.Collections.Generic;

    namespace Ucu.poo.GameOfLife
    {
        public class GameCore()
        {
<<<<<<< HEAD
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
<<<<<<< HEAD






=======
            public static bool[,] NextMove(bool [,]Board)
            {
                bool[,] gameBoard = Board
                int boardWidth = gameBoard.GetLength(0);
                int boardHeight = gameBoard.GetLength(1);

                bool[,] cloneboard = new bool[boardWidth, boardHeight];
                    for (int x = 0; x<boardWidth;
                x++)
                {
                    for (int y = 0; y < boardHeight; y++)
                    {
                        int aliveNeighbors = 0;
                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            for (int j = y - 1; j <= y + 1; j++)
                            {
                                if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                                {
                                    aliveNeighbors++;
                                }
                            }
                        }

                        if (gameBoard[x, y])
                        {
                            aliveNeighbors--;
                        }

                        if (gameBoard[x, y] && aliveNeighbors < 2)
                        {
                            //Celula muere por baja población
                            cloneboard[x, y] = false;
                        }
                        else if (gameBoard[x, y] && aliveNeighbors > 3)
                        {
                            //Celula muere por sobrepoblación
                            cloneboard[x, y] = false;
                        }
                        else if (!gameBoard[x, y] && aliveNeighbors == 3)
                        {
                            //Celula nace por reproducción
                            cloneboard[x, y] = true;
                        }
                        else
                        {
                            //Celula mantiene el estado que tenía
                            cloneboard[x, y] = gameBoard[x, y];
                        }
                    }
                }
                gameBoard = cloneboard;
            }
        }
        }
    }
}
>>>>>>> Game-Core
=======
// boardreadfile("board.txt");
>>>>>>> Boardreadfile
