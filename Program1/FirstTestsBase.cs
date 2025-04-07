using Valid;

namespace Logic
{
     class FirstTestsBase
    {
        public static void TestsComplite() 
        {
            // === ТЕСТИРОВАНИЕ BaseLogic ===
            Console.WriteLine("=== Тестирование BaseLogic ===");

            // 1. Создание объекта BaseLogic
            var baseLogic1 = new BaseLogic(false, false);
            Console.WriteLine(baseLogic1); // Ожидаем "FirstElement: False, SecondElement: False, Disjunction: False"

            var baseLogic2 = new BaseLogic(true, false);
            Console.WriteLine(baseLogic2); // Ожидаем "FirstElement: True, SecondElement: False, Disjunction: True"

            var baseLogic3 = new BaseLogic(false, true);
            Console.WriteLine(baseLogic3); // Ожидаем "FirstElement: False, SecondElement: True, Disjunction: True"

            var baseLogic4 = new BaseLogic(true, true);
            Console.WriteLine(baseLogic4); // Ожидаем "FirstElement: True, SecondElement: True, Disjunction: True"

            // 2. Тестирование метода Disjunction()
            Console.WriteLine($"\nТест Disjunction(): {baseLogic1.Disjunction()} (Ожидаем False)");
            Console.WriteLine($"Тест Disjunction(): {baseLogic2.Disjunction()} (Ожидаем True)");
            Console.WriteLine($"Тест Disjunction(): {baseLogic3.Disjunction()} (Ожидаем True)");
            Console.WriteLine($"Тест Disjunction(): {baseLogic4.Disjunction()} (Ожидаем True)");

            // 3. Тестирование конструктора копирования
            Console.WriteLine("\nТест конструктора копирования BaseLogic:");
            var copiedBaseLogic = new BaseLogic(baseLogic4);
            Console.WriteLine($"Оригинал: {baseLogic4}");
            Console.WriteLine($"Копия:    {copiedBaseLogic}\n");

        }

        public static void TestsConsole()
        {

            // Создание базового объекта BaseLogic через ввод пользователя
            Console.WriteLine("\nСоздание объекта BaseLogic...");

            // Получение первого логического значения
            bool firstElement = ValidBool.GetBooleanInput("Введите значение для firstElement (true/false): ");

            // Получение второго логического значения
            bool secondElement = ValidBool.GetBooleanInput("Введите значение для secondElement (true/false): ");

            // Создание объекта BaseLogic на основе ввода
            var baseLogic = new BaseLogic(firstElement, secondElement);
            Console.WriteLine($"Создан объект BaseLogic: {baseLogic}");

            // Демонстрация метода Disjunction()
            Console.WriteLine($"Результат Disjunction(): {baseLogic.Disjunction()}");
        }


    }
}
