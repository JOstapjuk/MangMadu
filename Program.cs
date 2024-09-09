using System;
using System.Runtime.Serialization;
namespace MangMadu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Määran konsooli suuruse
            Console.SetWindowSize(80, 25);

            // tõstan välja sümbolid mida neist teha seinad
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();



        }
    }
}