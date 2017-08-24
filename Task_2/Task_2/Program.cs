using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("Hello! This is your simple calculator. You should enter two numbers and chooose action you going to do with these numbers. Let's calculate!");

            //Declaring variables
            double a;
            double b;
            char c;

            Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            //Choice of action
            Console.WriteLine("Choose your action:");
            Console.WriteLine("'+' - addition");
            Console.WriteLine("'-' - substraction");
            Console.WriteLine("'*' - multiplication");
            Console.WriteLine("'/' - division");
            Console.WriteLine("'%' - rest of division");
            Console.Write("Enter your choice: ");

            c = char.Parse(Console.ReadLine());

            //Calculating
            if (c == '+')
            {
                Console.WriteLine("You choose an addition. The result is: " + (a + b));
            }
            if (c == '-')
            {
                Console.WriteLine("You choose a substraction. The result is: " + (a - b));
            }
            if (c == '*')
            {
                Console.WriteLine("You choose a multiplication. The result is: " + (a * b));
            }
            if (c == '/')
            {
                Console.WriteLine("You choose a division. The result is: " + (a / b));
            }
            if (c == '%')
            {
                Console.WriteLine("You choose a rest of division. The result is: " + (a % b));
            }
            else if (c != '+' && c != '-' && c != '*' && c != '/' && c != '%')
            {
                Console.WriteLine("You choose incorrect value");
            }


            Console.ReadLine();

        }
    }
}
