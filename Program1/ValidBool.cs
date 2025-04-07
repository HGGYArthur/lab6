using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid
{
    class ValidBool
    {
        public static bool GetBooleanInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "true")
                {
                    return true;
                }
                else if (input == "false")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите 'true' или 'false'.");
                }
            }
        }
    }
}
