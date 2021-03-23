using System;
using System.Collections.Generic;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;


            Console.WriteLine("Numbers:");


            foreach(var number in array1)
            {
                Console.Write(number + ", ");
            }



            List<string> newList = new List<string>();

            newList.Add("1");
            newList.Add("2");
            newList.Add("3");
            newList.Add("4");
            newList.Add("5");
            newList.Add("6");
            newList.Add("7");
            newList.Add("8");
            newList.Add("9");
            newList.Add("10");
            Console.WriteLine("");
            Console.WriteLine("List Numbers:");


            foreach (var number in newList) 
            {
                Console.Write(number + ",");
            }
        }
    }
}
