using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Создаем и настраиваем потоки
        Thread chickenThread = new Thread(PrintChicken);
        Thread eggThread = new Thread(PrintEgg);

        // Запускаем потоки
        chickenThread.Start();
        eggThread.Start();

        // Ждем завершения потоков
        chickenThread.Join();
        eggThread.Join();

        // Определяем, какой поток завершился последним
        // Если chickenThread все еще активен, значит eggThread завершился первым
        if (chickenThread.IsAlive)
        {
            Console.WriteLine("Последним завершилось: Яйцо");
        }
        else
        {
            Console.WriteLine("Последним завершилось: Курица");
        }
    }

    // Метод, который выполняется в потоке, выводит "Курица"
    static void PrintChicken()
    {
        Console.WriteLine("Курица");
    }

    // Метод, который выполняется в потоке, выводит "Яйцо"
    static void PrintEgg()
    {
        Console.WriteLine("Яйцо");
    }
}
