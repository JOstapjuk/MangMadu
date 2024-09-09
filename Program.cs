using System;
namespace MangMadu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Määratlege esimene sümbol, mis joonistab
            int x1 = 1; // x koordinaat
            int y1 = 3; // y koordinaat
            char sym1 = '*'; // sümbol joonistada
            Draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);


        }

        // Funktsioon joonistussümboli kindlal positsioonil
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}