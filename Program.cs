using Robot;
using System.Globalization;
using System.Reflection;

class Zadanie
{
    public static void Main()
    {
        Console.SetWindowSize(100, 50);
        var count = 0;
        var i = 0;
        bool check = false;
        char output;

        char[] mas = new char[100];
        char[] storoni = {'N', 'S', 'W', 'E'};
        Chet ch = new Chet();

        do
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите сторону направления(N,S,W,E) K-окончание программы: ");
            var userinput = Console.ReadLine();
            char.TryParse(userinput, out output);
            for (var j = 0; j < 4; j++)
            {
                if (output == storoni[j])
                {
                    i++;
                    mas[i] = output;
                    ch.Shag(output, ref count, ref check, mas, ref i);
                }
            }
            if (check)
            {
                break;
            }
            Console.SetCursorPosition(0, 0);
            Console.Write(new String(' ', Console.BufferWidth));
        } while (output != 'K');

        Console.SetCursorPosition(0, 2);
        if (!check)
        {
            Console.WriteLine("Не пришли в исходную точку.");
        }
        else
        {
            Console.WriteLine("Пришли в исходную точку пути.");
        }

        Console.WriteLine("Шагов пройдено: " + count);
        Console.Write("Проделанный путь: ");
        Console.WriteLine(String.Join(" ", mas));
        Console.ReadKey();
    }
}