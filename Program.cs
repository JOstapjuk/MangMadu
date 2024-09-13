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

            // Joonistame seinad kasutades eraldi klassi
            Walls walls = new Walls(80,25);
            walls.Draw();

            // madude joonistamine
            Point p = new Point(4, 5, '#');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // Loome toitu
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // Tsükkel madudele liikumiseks ja toidu söömiseks
            while (true)
            {
                // tingimus, kui madu sõitis vastu seina või oma saba
                if (walls.isHit(snake) || snake.isHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }      
        }
    }
}