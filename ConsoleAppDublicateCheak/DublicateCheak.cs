using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDublicateCheak
{
    internal class DublicateCheak
    {
        public void DublicateCheakNumbers() 
        {
            HashSet<int> numbers = new HashSet<int>();
            while (true)
            {
                Console.WriteLine("Введите число: ");
                var inputUser = Console.ReadLine();

                if (inputUser == "")
                {
                    ConclusionNumbers(numbers);
                    break;
                }

                if(int.TryParse(inputUser, out var num))
                {
                    if (numbers.Contains(num))
                    {
                        Console.WriteLine("Такое число уже есть.");
                        continue;
                    }
                    numbers.Add(num);
                    Console.WriteLine("Число добавлено.");
                }
                else
                {
                    Console.WriteLine("Не верный ввод");
                    continue;
                }

            }
        }

        public void ConclusionNumbers(HashSet<int> numbers)
        {
            Console.WriteLine("Вывод: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number}, ");
            }
        }
    }
}
