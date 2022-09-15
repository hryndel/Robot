using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Graphic
    {
        public void Draw(char[] mas, int i, int y, int x, int sx, int sy)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.SetCursorPosition(sx / 2, sy - 10);
            var str = new string('█', 50);
            Console.Write(str);
            Console.SetCursorPosition(sx / 2, sy - 9);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 8);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 7);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 6);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 5);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 4);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 3);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 2);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 1);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy - 0);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 9);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 8);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 7);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 6);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 5);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 4);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 3);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 2);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx / 2, sy + 1);
            Console.WriteLine("▌");
            Console.SetCursorPosition(sx + 24, sy - 9);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 8);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 7);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 6);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 5);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 4);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 3);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 2);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 1);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy - 0);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 9);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 8);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 7);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 6);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 5);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 4);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 3);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 2);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx + 24, sy + 1);
            Console.WriteLine("▐");
            Console.SetCursorPosition(sx / 2, sy + 10);
            Console.Write(str);
            Console.SetCursorPosition(sx, sy);
            Console.Write("█");
            Console.WriteLine();
            NConsole.SetCursorPosition(x, y);
            Console.Write("●");
            
            switch (mas[i])
            {
                case 'N':
                    switch (mas[i - 1])
                    {
                        case 'E':
                            Console.SetCursorPosition(x, ++y);
                            Console.Write("┘");
                            break;
                        case 'W':
                            Console.SetCursorPosition(x, ++y);
                            Console.Write("└");
                            break;
                        case 'S':
                            Console.SetCursorPosition(x, ++y);
                            Console.Write("↑");
                            break;
                        case 'N':
                            Console.SetCursorPosition(x, ++y);
                            Console.Write("│");
                            break;
                    }
                    break;
                case 'S':
                    switch (mas[i - 1])
                    {
                        case 'E':
                            Console.SetCursorPosition(x, --y);
                            Console.Write("┐");
                            break;
                        case 'W':
                            Console.SetCursorPosition(x, --y);
                            Console.Write("┌");
                            break;
                        case 'N':
                            Console.SetCursorPosition(x, --y);
                            Console.Write("↓");
                            break;
                        case 'S':
                            Console.SetCursorPosition(x, --y);
                            Console.Write("│");
                            break;
                    }
                    break;
                case 'W':
                    switch (mas[i - 1])
                    {
                        case 'E':
                            Console.SetCursorPosition(++x, y);
                            Console.Write("←");
                            break;
                        case 'N':
                            Console.SetCursorPosition(++x, y);
                            Console.Write("┐");
                            break;
                        case 'S':
                            Console.SetCursorPosition(++x, y);
                            Console.Write("┘");
                            break;
                        case 'W':
                            Console.SetCursorPosition(++x, y);
                            Console.Write("─");
                            break;
                    }
                    break;
                case 'E':
                    switch (mas[i - 1])
                    {
                        case 'N':
                            Console.SetCursorPosition(--x, y);
                            Console.Write("┌");
                            break;
                        case 'W':
                            Console.SetCursorPosition(--x, y);
                            Console.Write("→");
                            break;
                        case 'S':
                            Console.SetCursorPosition(--x, y);
                            Console.Write("└");
                            break;
                        case 'E':
                            Console.SetCursorPosition(--x, y);
                            Console.Write("─");
                            break;
                    }
                    break;
            }
        }
    }
}
