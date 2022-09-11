using Robot;
using System.Globalization;
using System.Reflection;

class Zadanie
{
    public static void Main()
    {
        var strk = 0;
        var count = 0;
        var i = 0;
        bool check = false;
        char output;

        char[] mas = new char[100];
        char[] storoni = {'N', 'S', 'W', 'E'};
        Chet ch = new Chet();
        Graphic gr = new Graphic();

        do
        {
            Console.Write("Введите сторону направления(N,S,W,E) K-окончание программы: ");
            var userinput = Console.ReadLine();
            char.TryParse(userinput, out output);
            for (var j = 0; j < 4; j++)
            {
                if (output == storoni[j])
                {
                    mas[i] = output;
                    ch.Shag(output, ref count, ref check);
                    i++;
                }
            }
            strk += 2;
            if (check)
            {
                break;
            }
        } while (output != 'K');

        if (!check)
        {
            Console.WriteLine("---------------------\nНе пришли в исходную точку.");
        }
        else
        {
            Console.WriteLine("---------------------\nПришли в исходную точку пути.");
        }

        Console.WriteLine("Шагов пройдено: " + count);
        Console.Write("Проделанный путь: ");
        Console.WriteLine(String.Join(" ", mas));
        gr.Draw(mas, count, strk);
        Console.ReadKey();
    }
}