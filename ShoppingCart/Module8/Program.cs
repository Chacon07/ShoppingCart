using System;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass<int> firstClass = new FirstClass<int>();

            firstClass.Height = 180;
            firstClass.Weight = 190;

            Console.WriteLine("Height: " + firstClass.Height);
            Console.WriteLine("Weight: " + firstClass.Weight);

        }
    }
}
public class FirstClass<A>
{
    public A Height { get; set; }
    public A Weight { get; set; }
}
