using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiplicationOfValues(1, 2));
        }
        static int MultiplicationOfValues(int value1,int value2)
        {
            int a = 900;
            int b = 3;
            int result = 0;
            result = a * b;

            return result;
        }
    }
}
