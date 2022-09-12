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
                        switch (mas[i + 1])
                        {
                            case 'E':
                                Console.Write("┌");
                                break;
                            case 'W':
                                Console.Write("┐");
                                break;
                            case 'S':
                                Console.Write("↓");
                                break;
                            case 'N':
                                Console.Write("│");
                                break;
                        }
                        break;
                    case 'S':
                        Console.SetCursorPosition(x, ++y);
                        switch (mas[i + 1])
                        {
                            case 'E':
                                Console.Write("└");
                                break;
                            case 'W':
                                Console.Write("┘");
                                break;
                            case 'N':
                                Console.Write("↑");
                                break;
                            case 'S':
                                Console.Write("│");
                                break;
                        }
                        break;
                    case 'W':
                        Console.SetCursorPosition(--x, y);
                        switch (mas[i + 1])
                        {
                            case 'E':
                                Console.Write("→");
                                break;
                            case 'N':
                                Console.Write("└");
                                break;
                            case 'S':
                                Console.Write("┌");
                                break;
                            case 'W':
                                Console.Write("─");
                                break;
                        }
                        break;
                    case 'E':
                        Console.SetCursorPosition(++x, y);
                        switch (mas[i + 1])
                        {
                            case 'N':
                                Console.Write("┘");
                                break;
                            case 'W':
                                Console.Write("←");
                                break;
                            case 'S':
                                Console.Write("┐");
                                break;
                            case 'E':
                                Console.Write("─");
                                break;
                        }
                        break;
                }
            }
            Console.SetCursorPosition(x, y);
            char konec = (x == sx && y == sy ? '▓': '┼');
            Console.Write(konec);
        }
    }
}
