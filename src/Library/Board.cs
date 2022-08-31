using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        public bool[,] Tablero{get; set;}

        public Board(bool[,] board)
        {
            this.Tablero = board;            
        } 
    }
}

/*La clase cumple el principio SRP ya que tiene una sola función asignada, la cual es crear el objeto tablero.*/