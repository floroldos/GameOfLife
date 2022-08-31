using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] lector = Reader.LeerArchivo(@"../../assets/board.txt");
            Board Game1 = new Board(lector);
            while (true)
            {
                Console.WriteLine(Printer.Print(Game1));
                BoardLogic.GameLogic(Game1);
                Thread.Sleep(300);
            }
        }
    }
}

/* EXPERT.
Program es el Experto en información. Tiene la información de todas las clases y se encarga de llamar todo lo necesario para "correr" el programa.
No hay clases que tengan más de una tarea. Program accede a todas las clases.*/