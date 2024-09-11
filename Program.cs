using System;
using System.Runtime.Serialization;
namespace MangMadu
{
    class Program
    {
        static void Main(string[] args)
        {

            // tõstan välja sümbolid mida neist teha seinad
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            // Määran konsooli suuruse
            Console.SetWindowSize(80, 25);

            // madude joonistamine
            Point p = new Point(4, 5, '#');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            // paneme madu liikuma vajutatud tulistajale suunas
            while (true)
            {
                if (Console.KeyAvailable) 
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // loeb infot, millist nuppu (tulistajat) vajutati
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100); //Thread.Sleep() - viivitus
                snake.Move();
            }

                      

        }
    }
}