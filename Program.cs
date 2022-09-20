using System;
using System.Threading;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("You have accessed the menu.");
            Console.WriteLine("");

            Console.WriteLine("Choose what type of operation you want to perform: ");
            Console.WriteLine("");

            Console.WriteLine("0 - Sum");
            Console.WriteLine("1 - Subtraction");
            Console.WriteLine("2 - Division");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Exit the application");
            Console.WriteLine("");

            short res = short.Parse(Console.ReadLine());

            try
            { 
                switch(res)
                {
                    case 0: Sum(); break;
                    case 1: Subtraction(); break;
                    case 2: Division(); break;
                    case 3: Multiplication(); break;
                    case 4: Environment.Exit(0); break;
                    default: Menu(); break;
                }
            }
            catch
            {
                Console.WriteLine("Oops, you entered a number that doesn't match the options :(");
                Console.WriteLine("");

                Console.WriteLine("Saindo da aplicação...");
                Thread.Sleep(2000);
            }
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("You have accessed: Sum.");
            Console.WriteLine("");

            Console.WriteLine("Enter the value to be added: ");
            double value1 = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value to add: ");
            double value2 = short.Parse(Console.ReadLine());

            double result = value1 + value2;

            Console.WriteLine($"The result of {value1} plus {value2} is {result}.");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");

            Console.ReadKey();
            Console.WriteLine("");
            
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            
            Console.WriteLine("You have accessed: Subtraction.");
            Console.WriteLine("");

            Console.WriteLine("Enter the value to be subtracted: ");
            double value1 = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value to subtract: ");
            double value2 = short.Parse(Console.ReadLine());

            double result = value1 - value2;

            Console.WriteLine($"The result of {value1} minus {value2} is {result}.");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");

            Console.ReadKey();
            Console.WriteLine("");

            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("You have accessed: Division.");
            Console.WriteLine("");

            Console.WriteLine("Enter the value to be divided: ");
            double value1 = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter the divisor value: ");
            double value2 = short.Parse(Console.ReadLine());

            double result = value1 / value2;

            Console.WriteLine($"The result of {value1} divided by {value2} is {result}.");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");

            Console.ReadKey();
            Console.WriteLine("");

            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            
            Console.WriteLine("You have accessed: Multiplication.");
            Console.WriteLine("");

            Console.WriteLine("Enter the value to be multiplied: ");
            double value1 = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter the multiplier value: ");
            double value2 = short.Parse(Console.ReadLine());

            double result = value1 * value2;

            Console.WriteLine($"The result of {value1} multiplied by {value2} is {result}.");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");

            Console.ReadKey();
            Console.WriteLine("");

            Menu();
        }

    }
}
