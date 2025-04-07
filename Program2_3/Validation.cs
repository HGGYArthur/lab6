using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid
{
    class Validation
    {
        // Метод для проверки корректности ввода вещественного числа
        static public double ReadDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Неправильный формат числа! Попробуйте снова.");
                }
            }
        }

        // Метод для проверки корректности ввода целого числа
        static public int ReadInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Неправильный формат числа! Попробуйте снова.");
                }
            }
        }
    }

}

