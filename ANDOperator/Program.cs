using System;

namespace ANDOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND - &&
            //1. true && true => true - username && password => welcome
            //2. true && false => false - username && password => access denied
            //3. false && true => false - username && password => access denied
            //4. false && false => false - username && password => access denied

            //контрольные данные: username - admin, password - 1234
            //Задание 1. Дополнить приложение, чтобы дать пользователю только 3 попытки для входа в систему

            int tries = 0;

            while (tries != 3)
            {
                string username, password;

                Console.WriteLine("Enter username:");
                username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    Console.WriteLine("Access denied.");
                    tries++;
                    Console.WriteLine($"You have made {tries} attempt.");
                }

            }

            Console.WriteLine("Have a nice day.");

        }
    }
}
