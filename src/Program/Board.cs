using System;

using System.Collections.Generic;

namespace Ucu.Poo.GameOfLife;

public class Board
{
    public int height
    {
        get { return height; }
        set {}
    }

    public int width
    {
        get { return width;}
        set{}
    }

    public bool[,] cellstatus;

    public void princCells()
    {
        foreach (bool i in cellstatus)
        {
            Console.WriteLine(i);
        }
    }

    public bool GetCellStatus(int i, int x)
    {
        bool cellvalue = cellstatus[i, x];
        return cellvalue;
    }

    public void SetcellValues(int i, int x, bool value)
    {
        cellstatus[i, x] = value;
    }

    public Board(int height, int width)
    {
        this.height = height;
        this.width = width;
        this.cellstatus = new bool[height, width];
    }
    
}