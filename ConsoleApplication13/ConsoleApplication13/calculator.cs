using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class calculator
    {
        int num1,num2;
        public calculator()
        {
            Console.Write("enter a num:");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("enter Operator");
            string op = Console.ReadLine();
            Console.Write("enter another num:");
            num2 = Convert.ToInt16(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "%")
            {
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("invalid operator");
            }

            Console.ReadLine();
        }
    }
}
