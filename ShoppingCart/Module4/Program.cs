using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = new DateTime(1999, 01, 06);
            DateTime secondDate = new DateTime(2004, 03, 15);

            int result = DateTime.Compare(firstDate, secondDate);

            if(result ==1)
            {
                Console.WriteLine(firstDate);
            }
            else
            {
                Console.WriteLine(secondDate);
            }
        }
    }
}
