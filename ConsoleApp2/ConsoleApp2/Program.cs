using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Element ob = new Element();
            ob.x = 3;
            Console.WriteLine(ob.x);

            Element[] num = new Element[5];
            for (int i = 0; i < 5; i++)
            {
                num[i] = new Element();
                num[i].x = i;
            }
            for(int i=0;i<5;i++) { 
                Console.WriteLine(num[i].x);
               
            }
            Console.ReadLine();
        }
        class Element
        {
           public int x;
            
        }
    }
}
