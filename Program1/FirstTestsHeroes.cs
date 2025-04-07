using Logic;
using System;
using Valid;

class FirstTestsHeroes
{
    public static void TestsComplite()
    {
        // === ТЕСТИРОВАНИЕ HeroState ===
        Console.WriteLine("=== Тестирование HeroState ===");

        // 1. Создание объекта HeroState
        var hero = new HeroState(false, false, "Archer");
        Console.WriteLine(hero); // Ожидаем все False: In Combat, Using Ability, Active Status

        // 2. Сценарий: Герой входит в бой
        Console.WriteLine("\nГерой входит в бой...");
        hero.EnterCombat();
        Console.WriteLine(hero); // Ожидаем: In Combat = True, Using Ability = False, Active Status = True

        // 3. Сценарий: Герой использует способность
        Console.WriteLine("\nГерой использует способность...");
        hero.UseAbility();
        Console.WriteLine(hero); // Ожидаем: In Combat = True, Using Ability = True, Active Status = True

        // 4. Сценарий: Герой умирает
        Console.WriteLine("\nГерой умирает...");
        hero.HeroDie();
        Console.WriteLine(hero); // Ожидаем все False: In Combat, Using Ability, Active Status

        // 5. Тестирование копирования объекта HeroState
        Console.WriteLine("\nТест конструктора копирования HeroState:");
        hero.EnterCombat();
        hero.UseAbility(); // Герой в бою и использует способность
        var copiedHero = new HeroState(hero);
        Console.WriteLine($"Оригинал: {hero}"); // Статус героя: In Combat = True, Using Ability = True
        Console.WriteLine($"Копия:    {copiedHero}"); // Копия должна быть идентична оригиналу

        // 6. Тест активного состояния
        Console.WriteLine("\nТест активного состояния IsActive():");
        Console.WriteLine($"Герой активен? {hero.IsActive()}"); // Ожидаем True
        hero.HeroDie();
        Console.WriteLine($"Герой активен после смерти? {hero.IsActive()}"); // Ожидаем False

        // 7. Тест героя с разными комбинациями
        Console.WriteLine("\nКомбинации состояний героя:");
        var hero2 = new HeroState(false, false, "Mage");
        Console.WriteLine(hero2); // In Combat = False, Using Ability = False, Active Status = False

        hero2.EnterCombat();
        Console.WriteLine(hero2); // In Combat = True, Using Ability = False, Active Status = True

        hero2.UseAbility();
        Console.WriteLine(hero2); // In Combat = True, Using Ability = True, Active Status = True

        hero2.HeroDie();
        Console.WriteLine(hero2); // In Combat = False, Using Ability = False, Active Status = False

        // 8. Пограничные тесты для вызова методов
        Console.WriteLine("\nПограничные тесты:");
        var hero3 = new HeroState(false, false, "Tank");
        Console.WriteLine(hero3); // Начальное состояние

        hero3.UseAbility(); // Использование способности без боя
        Console.WriteLine($"После использования способности: {hero3}");

        hero3.EnterCombat(); // Вход в бой после начала использования способности
        Console.WriteLine($"После входа в бой: {hero3}");

        hero3.HeroDie(); // Герой умирает
        Console.WriteLine($"После смерти героя: {hero3}");
    }

    public static void TestsConsole()
    {
        // Создание объекта HeroState через ввод пользователя
        Console.WriteLine("\nСоздание объекта HeroState...");

        // Получение имени героя
        Console.Write("Введите имя героя: ");
        string heroName = Console.ReadLine();

        // Получение состояния героя (в бою и использование способности)
        bool isInCombat = ValidBool.GetBooleanInput("Герой находится в бою? (true/false): ");
        bool isUsingAbility = ValidBool.GetBooleanInput("Герой использует способность? (true/false): ");

        // Создание объекта HeroState
        var hero = new HeroState(isInCombat, isUsingAbility, heroName);
        Console.WriteLine($"Создан объект HeroState: {hero}");

        // Взаимодействие с объектом HeroState через методы
        while (true)
        {
            Console.WriteLine("\nВыберите действие с героем:");
            Console.WriteLine("1. Проверить, активен ли герой");
            Console.WriteLine("2. Перевести героя в боевой режим");
            Console.WriteLine("3. Герой использует способность");
            Console.WriteLine("4. Убить героя");
            Console.WriteLine("5. Вывести текущий статус героя");
            Console.WriteLine("0. Выйти из программы");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Герой активен? {hero.IsActive()}");
                    break;
                case "2":
                    hero.EnterCombat();
                    Console.WriteLine("Герой теперь находится в бою.");
                    break;
                case "3":
                    hero.UseAbility();
                    Console.WriteLine("Герой теперь использует способность.");
                    break;
                case "4":
                    hero.HeroDie();
                    Console.WriteLine("Герой умер.");
                    break;
                case "5":
                    Console.WriteLine($"Статус героя: {hero}");
                    break;
                case "0":
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите действие от 0 до 5.");
                    break;
            }
        }
    }
} 
    

