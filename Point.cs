using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangMadu
{
    internal class Point
    {
        // Kuulutame välja klassimuutujad
        public int x;
        public int y;
        public char sym;

        public Point() {}

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        // Funktsioon joonistussümboli kindlal positsioonil
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
