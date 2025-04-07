using Line;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valid;

namespace Line
{
    class SecondTaskTest
    {
        public static void Test()
        {
            Console.WriteLine("=== Демонстрация работы класса LineSegment ===");

            // Ввод первого отрезка
            Console.WriteLine("Введите координаты начала и конца первого отрезка:");
            double begin1 = Validation.ReadDouble("Начало первого: ");
            double end1 = Validation.ReadDouble("Конец первого: ");
            LineSegment segment1 = new LineSegment(begin1, end1);
            Console.WriteLine($"Создан первый отрезок: {segment1}");

            // Ввод второго отрезка
            Console.WriteLine("Введите координаты начала и конца второго отрезка:");
            double begin2 = Validation.ReadDouble("Начало второго: ");
            double end2 = Validation.ReadDouble("Конец второго: ");
            LineSegment segment2 = new LineSegment(begin2, end2);
            Console.WriteLine($"Создан второй отрезок: {segment2}");

            // Меню выбора действий
            while (true)
            {
                Console.WriteLine("\n=== Меню действий ===");
                Console.WriteLine("1 - Проверить пересечение отрезков");
                Console.WriteLine("2 - Вычислить длину первого и второго отрезка");
                Console.WriteLine("3 - Расширить оба отрезка на 1 влево и вправо");
                Console.WriteLine("4 - Перегрузка преобразования типов");
                Console.WriteLine("5 - Уменьшение отрезков (операторы '-')");
                Console.WriteLine("6 - Проверить пересечение отрезков перегруженными методами (<, >)");
                Console.WriteLine("7 - Показать информацию об отрезках");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": // Проверка пересечения
                        Console.WriteLine($"Пересекаются ли отрезки? {(segment1.IsIntersection(segment2) ? "Да" : "Нет")}");
                        break;

                    case "2": // Длина отрезков
                        Console.WriteLine($"Длина первого отрезка: {!segment1}");
                        Console.WriteLine($"Длина второго отрезка: {!segment2}");
                        break;

                    case "3": // Расширить отрезки
                        ++segment1;
                        ++segment2;
                        Console.WriteLine($"Первый отрезок расширен: {segment1}");
                        Console.WriteLine($"Второй отрезок расширен: {segment2}");
                        break;

                    case "4": // Преобразования
                        Console.WriteLine($"Преобразование первого отрезка в int (целая часть начала): {(int)segment1}");
                        Console.WriteLine($"Преобразование первого отрезка в double (конец): {(double)segment1}");
                        break;

                    case "5": // Уменьшение отрезков
                        Console.WriteLine("Введите значение для уменьшения:");
                        int subtractValue = Validation.ReadInt("Значение: ");
                        LineSegment subLeft = segment1 - subtractValue;
                        LineSegment subRight = subtractValue - segment2;
                        Console.WriteLine($"Первый отрезок после уменьшения: {subLeft}");
                        Console.WriteLine($"Второй отрезок после уменьшения: {subRight}");
                        break;

                    case "6": // Сравнение отрезков
                        Console.WriteLine($"Пересечение есть? {(segment1 < segment2 ? "Да" : "Нет")}");
                        Console.WriteLine($"Пересечения нет? {(segment1 > segment2 ? "Да" : "Нет")}");
                        break;

                    case "7": // Информация об отрезках
                        Console.WriteLine($"Первый отрезок: {segment1}");
                        Console.WriteLine($"Второй отрезок: {segment2}");
                        break;

                    case "0": // Выход
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
