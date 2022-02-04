using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            int score = 0;
            //drawing a game field game
            Walls walls = new Walls(80, 25);
            Walls.Draw();

            Point snakeTail = new Point(15, 15, 's');
            Snake snake = new Snake(snakeTail, 10, Direction.Right);
            snake.Draw();

            FoodGenerator foodGenerator = new FoodGenerator(80, 25, '$');
            Point food = FoodGenerator.GenerateFood():
            food.Draw();

            while (true)
            {  
                if(walls.IsHit(snake)  snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodGenerator.GenerateFood();
                    food.Draw();
                    score++;
                } else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKeys(key.key);
                }

                Thread.Sleep(300);
            }


            string str_score = Convert.ToString(score);
            WriteGameOver(str_score);
            Console.ReadLine();
        }

        public static void WriteGameOver(string score)
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("====================", xOffset, yOffset++);
            WriteText("      GAME OVER         ", xOffset + 1, yOffset++);
            WriteText($" You scored {score} points", xOffset + 2, yOffset++);
            WriteText("", xOffset + 1, yOffset++);
            WriteText("====================", xOffset, yOffset++);
        }
        public static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.Writeline(text);
        }
    }
}
