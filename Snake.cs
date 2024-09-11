using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangMadu
{

    internal class Snake : Figure
    {
        Direction direction;
        //Loonud uue alaklassi, kus joonistub välja madu
        public Snake(Point tail, int length,Direction _direction) 
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        //Madu liigub varem märgitud suunal
        internal void Move()
        {
            Point tail = pList.First(); // First() - tagastab listi esimese elemendi
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        //Tagastab mao pea punkti
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point (head);
            nextPoint.Move(1, direction); 
            return nextPoint;
        }
    }
}
