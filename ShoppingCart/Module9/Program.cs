using System;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass variable = new MainClass();

            variable.GenMethod<string>("first", "second");

            Console.WriteLine(variable.Color);

            Console.WriteLine(variable.Shape);
        }
    }
}
public class MainClass
{
    public string Color { get; set; }
    public string Shape { get; set; }
    public void GenMethod<X>(X first, X second)
    {
        this.Color = first.ToString();
        this.Shape = second.ToString();
    }
}
