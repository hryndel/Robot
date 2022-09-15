using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Chet
    {
        public int chetx = 0;
        public int chety = 0;

        public int y = Console.WindowHeight / 2;
        public int x = Console.WindowWidth / 2;

        public int sx = Console.WindowWidth / 2;
        public int sy = Console.WindowHeight / 2;

        public void Shag(char o, ref int count, ref bool proof, char[] mas, ref int i)
        {
            Graphic gr = new Graphic();
            switch (o)
            {
                case 'N':
                    y--;
                    chety++;
                    break;
                case 'S':
                    y++;
                    chety--;
                    break;
                case 'W':
                    x--;
                    chetx--;
                    break;
                case 'E':
                    x++;
                    chetx++;
                    break;
            }
            Console.SetCursorPosition(0, 1);
            Console.Write(new String(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, 1);
            if (chetx > 20)
            {
                Console.Write("X = " + chetx + "\tY = " + chety);
                gr.Draw(mas, i, y, x, sx, sy);
                Proverka(ref proof);
                count++;
                if (proof)
                {
                    return;
                }
            }
        }
        public void Proverka(ref bool proof)
        {
            if (chetx == 0 && chety == 0)
            {
                proof = true;
            }
        }
    }
}
