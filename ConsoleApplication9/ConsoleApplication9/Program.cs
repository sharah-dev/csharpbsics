using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = "sharah";
            int age = 21;
            Console.WriteLine("hii " + name + "you are " + age +'\n' + name.Length);
            int a, b;
            Console.Write("enter a value");
            a =Convert.ToInt32(Console.ReadLine());
            Console.Write("enter b value");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + b);
            Console.ReadLine();
            int num1, num2;
            Console.Write("enter num1:");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("enter num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(num1, num2));
            int[] numbers = { 1, 2, 3, 4, 4, 5 };
            Console.WriteLine(numbers[2]);
            Console.ReadLine();
            Console.WriteLine(Math.Sqrt(45));
            Console.ReadLine();
            string[] names = new string[3];
            names[0] = "sam";
            names[1] = "semiya";
            names[2] = "manu";
            Console.WriteLine(names);
        }
    }
}
