using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Chet
    {
        public int x = 0;
        public int y = 0;

        public void Shag(char o, ref int count, ref bool proof)
        {
            switch (o)
            {
                case 'N':
                    y++;
                    break;
                case 'S':
                    y--;
                    break;
                case 'W':
                    x--;
                    break;
                case 'E':
                    x++;
                    break;
            }
            Console.WriteLine("X = " + x + "\tY = " + y);
            Proverka(ref proof);
            count++;
            if (proof)
            {
                return;
            }
        }
        public void Proverka(ref bool proof)
        {
            if (x == 0 && y == 0)
            {
                proof = true;
            }
        }
    }
}
