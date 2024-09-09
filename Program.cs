using System;
using System.Runtime.Serialization;
namespace MangMadu
{
    class Program
    {
        static void Main(string[] args)
        {
            //loome klassis Point uue obekti kasutades konstruktorit
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            // loome klassis HorizontalLine uue objekti kasutades konstruktorit
            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Drow();


        }
    }
}