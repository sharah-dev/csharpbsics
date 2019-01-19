using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class factorial
    {
        
        int i, fact = 1, num;
        public factorial()
        {
            Console.Write("enter a num:");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of" + num + " is:" + fact);
        }
    }
}
