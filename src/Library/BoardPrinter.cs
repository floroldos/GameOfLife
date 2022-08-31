using System;
using System.Text;

namespace PII_Game_Of_Life
{
    public class Printer
    {
        public static string Print(Board tablero)
        {
            bool[,] b = tablero.Tablero; 
            int width = tablero.Tablero.GetLength(0); 
            int height = tablero.Tablero.GetLength(1); 
            
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|O|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            return s.ToString();
            }
        }
 }
