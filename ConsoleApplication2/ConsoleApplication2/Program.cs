using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberCounter = 0;
            while (numberCounter < 100) 
            {
                numberCounter++;
                if (numberCounter % 5 == 0 && numberCounter % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (numberCounter % 5 == 0) 
                {
                    Console.WriteLine("buzz");
                }
                else if (numberCounter % 3 == 0)
                {
                    Console.WriteLine("fiz");
                }
                else
                {
                    Console.WriteLine(numberCounter);
                }
                      
               }
            Console.ReadLine();
            }






        }
}
