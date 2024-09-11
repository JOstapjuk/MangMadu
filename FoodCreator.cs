using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangMadu
{
    // Klass toidu loomiseks ja mis loob toitu randomsele kohale
    internal class FoodCreator
    {
        int mapWidht;
        int mapHeidht;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidht = mapWidth;
            this.mapHeidht = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeidht - 1);
            return new Point(x,y,sym);
        }
    }
}
