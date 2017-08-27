using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Third();
            Fourth();
            Fifth();
        }

        private static void First()
        {
            Console.WriteLine("\n 1е задание ");
            int count = 0;
            char sumbol = '1';
            Console.WriteLine("Введите предлложение:");
            while (sumbol != '.')
            {
                sumbol = Console.ReadKey().KeyChar;
                if (sumbol == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("\nПробелов: {0}", count);
            Console.ReadLine();
        }

        private static void Second()
        {
            Console.WriteLine("\n 2е задание ");
            Console.WriteLine("Введите номер вашего билета(ХХХХХХ): ");
            string strNumber = Console.ReadLine();
            int number;
            bool isOk = Int32.TryParse(strNumber, out number);
            if (!isOk || number > 999999 || number < 100000)
            {
                Console.WriteLine("Номер вашего билета не верный!");
            }
            else if (number % 10 + number % 100 / 10 + number % 1000 / 100 ==
                number % 10000 / 1000 + number % 100000 / 10000 + number % 1000000 / 100000)
            {
                Console.WriteLine("Ваш билет счастливый");
            }
            else
            {
                Console.WriteLine("Ваш билет не счастливый");
            }

            Console.ReadLine();
        }

        private static void Third()
        {
            Console.WriteLine("\n 3е задание ");
            char symbol = '0';
            while (symbol != '.')
            {
                symbol = Console.ReadKey().KeyChar;
                if (symbol >= 'а' && symbol <= 'я')
                {
                    Console.Write("\b" + (char)(symbol - 32));
                }
                else if (symbol >= 'А' && symbol <= 'Я')
                {
                    Console.Write("\b" + (char)(symbol + 32));
                }
            }
            Console.ReadLine();
        }

        private static void Fourth()
        {
            Console.WriteLine("\n 4е задание ");
            Console.WriteLine("Введите первое число: ");
            string strFirstNumber = Console.ReadLine();
            int firstNumber = Int32.Parse(strFirstNumber);
            Console.WriteLine("Введите второе число: ");
            string strSecondNumber = Console.ReadLine();
            int secondNumber = Int32.Parse(strSecondNumber);

            if(firstNumber > secondNumber)
            {
                int interim = firstNumber;
                firstNumber = secondNumber;
                secondNumber = interim;
            }

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void Fifth()
        {
            Console.WriteLine("\n 5е задание ");
            Console.WriteLine("Введите число: ");
            string strNumber = Console.ReadLine();
            int number = Int32.Parse(strNumber);
            double newNumber = 0;

            if (number < 0)
            {
                Console.WriteLine("Число отрицательное!");
            }
            
            while (number > 0)
            {
                newNumber += number % 10;
                number /= 10;
                newNumber *= 10;
            }
            newNumber /= 10;

            Console.WriteLine(newNumber);
            Console.ReadLine();
        }
    }
}
