using Logic;

class Program1
{
    static void Main(string[] args)
    {
        FirstTestsBase.TestsComplite();
        FirstTestsHeroes.TestsComplite();

        Console.WriteLine("\n\n=== Тестирование с вводом данных с клавиатуры ===");

        FirstTestsBase.TestsConsole();
        FirstTestsHeroes.TestsConsole();
    }
}

