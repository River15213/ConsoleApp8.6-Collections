namespace ConsoleAppPhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            bool exitProgram = false;
            while (exitProgram == false)
            {
                Console.WriteLine($"Выберите что хотите сделать\n" +
                  $"0. Выход\n" +
                  $"1. Создать запись в телефоную книгу\n" +
                  $"2. Найти информацию в телефоной книге.");

                if (int.TryParse(Console.ReadLine(), out var inputUser))
                {
                    switch (inputUser)
                    {
                        case 0:
                            Console.WriteLine("Приложение закрыто");
                            exitProgram = true;
                            break;
                        case 1:
                            phoneBook.CreateInfoPhoneBook();
                            break;
                        case 2:
                            phoneBook.FindPhoneBook();
                            break;
                        default:
                            Console.WriteLine("Не верный выбор");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введите цифры.");
                }


            }

        }
    }
}
