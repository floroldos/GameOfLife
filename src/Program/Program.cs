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
