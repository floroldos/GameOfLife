using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Reader
    {
        public static bool[,] LeerArchivo(string url)
        {
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
            return board;
        }
    }
}

/*La clase cumple el principio SRP ya que tiene una sola función asignada, la cual es leer el archivo que contiene las filas de la matriz para armar el tablero.*/
