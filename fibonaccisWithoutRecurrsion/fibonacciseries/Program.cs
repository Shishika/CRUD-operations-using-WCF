using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonaci
{
    public class Program
    {
        static void Main(string[] args)
        {
            int loop,first = 0,second = 1,third = 0;
            int count;
            Console.WriteLine("enter count value");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (loop = 0; loop <= count; loop++)
            {
                third = first + second;
                Console.WriteLine(third);
                first = second;
                second = third;
            }
            Console.ReadLine();
         }
    }
}