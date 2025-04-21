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
    
    
    public Board(int height, int width)
    {
        this.height = height;
        this.width = width;
    }
}