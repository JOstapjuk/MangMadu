using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangMadu
{
    internal class Figure
    {
        // List, et salvestada joont esindavaid punktiobjekte
        protected List<Point> pList;

        // Horisontaalse joone joonistamise funktioon
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
