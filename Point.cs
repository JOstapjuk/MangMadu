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

        // Funktsioon joonistussümboli kindlal positsioonil
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
