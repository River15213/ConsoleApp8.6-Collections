using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPhoneBook
{
    internal class PhoneBook
    {
        Dictionary<int, string> _phoneNumbers = new Dictionary<int, string>();
        public void CreateInfoPhoneBook()
        {
            while (true)
            {
                Console.WriteLine("Введите номер телефона: ");
                if (!int.TryParse(Console.ReadLine(), out var phoneNumber))
                {
                    Console.WriteLine("Номер не верный, ввод завершен");
                    return;
                }
                if (_phoneNumbers.ContainsKey(phoneNumber))
                {
                    Console.WriteLine("Такой номер уже есть.");
                    continue;
                }

                Console.WriteLine("Введите ФИО: ");
                var fullName = Console.ReadLine();

                if (string.IsNullOrEmpty(fullName))
                {
                    Console.WriteLine("Ввод закончен.");
                    continue;
                }
                _phoneNumbers.Add(phoneNumber, fullName);
                Console.WriteLine("Информация сохранена");
            }

        }


        public void FindPhoneBook()
        {
            Console.WriteLine("Введите номер телефона для поиска: ");
            if (int.TryParse(Console.ReadLine(),out var phoneNumber))
            {
                if (_phoneNumbers.TryGetValue(phoneNumber, out var phoneBook))
                {
                    Console.WriteLine($"Номер телефона: {phoneNumber}: ФИО: {phoneBook}");
                }
                else
                {
                    Console.WriteLine($"Такого пользователя нет.");
                }
            }
            else
            {
                Console.WriteLine("Неверный номер телефона");
            }

        }
    }
}
