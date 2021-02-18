using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators

            //multiplies num1 with -1
            num3 = -num1;
            Console.WriteLine("Num3 is {0}", num3);

            bool isSunny = false;
            // "!" makes it the opposite
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            //increment operators
            int num = 0;
            // increases by 1
            num++;
            Console.WriteLine("num is {0}",num);
            Console.WriteLine("num is {0}", num++);
            //increment happens on the line above, below is "preincrement"
            Console.WriteLine("num is {0}", ++num);

            //decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            //pre decrement
            Console.WriteLine("num is {0}", --num);


        }
    }
}
