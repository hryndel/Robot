using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Graphic
    {
        public void Draw(char[] mas, int count, int strk)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var y = Console.WindowHeight/ 2+strk;
            var x = Console.WindowWidth / 2;
            var sx = x;
            var sy = y;
            Console.SetCursorPosition(x, y);
            Console.Write("█");
            strk += 5;
            for (var i=0; i<count; i++)
            {
                Console.WriteLine();
                switch (mas[i])
                {
                    case 'N':
                        Console.SetCursorPosition(x, --y);
                        if (mas[i + 1] == 'E')
                        {
                            Console.Write("┌");
                        }
                        else if (mas[i + 1] == 'W')
                        {
                            Console.Write("┐");
                        }
                        else if (mas[i + 1] == 'S')
                        {
                            Console.Write("↓");
                        }
                        else
                        {
                            Console.Write("│");
                        }
                        break;
                    case 'S':
                        Console.SetCursorPosition(x, ++y);
                        if (mas[i + 1] == 'E')
                        {
                            Console.Write("└");
                        }
                        else if (mas[i + 1] == 'W')
                        {
                            Console.Write("┘");
                        }
                        else if (mas[i + 1] == 'N')
                        {
                            Console.Write("↑");
                        }
                        else
                        {
                            Console.Write("│");
                        }
                        break;
                    case 'W':
                        Console.SetCursorPosition(--x, y);
                        if (mas[i + 1] == 'E')
                        {
                            Console.Write("→");
                        }
                        else if (mas[i + 1] == 'N')
                        {
                            Console.Write("└");
                        }
                        else if (mas[i + 1] == 'S')
                        {
                            Console.Write("┌");
                        }
                        else
                        {
                            Console.Write("─");
                        }
                        break;
                    case 'E':
                        Console.SetCursorPosition(++x, y);
                        if (mas[i + 1] == 'N')
                        {
                            Console.Write("┘");
                        }
                        else if (mas[i + 1] == 'W')
                        {
                            Console.Write("←");
                        }
                        else if (mas[i + 1] == 'S')
                        {
                            Console.Write("┐");
                        }
                        else
                        {
                            Console.Write("─");
                        }
                        break;
                }
            }
            Console.SetCursorPosition(x, y);
            if (x==sx && y==sy)
            {
                Console.Write("▓");
            }
            else
            {
                Console.Write("┼");
            }
        }
    }
}
