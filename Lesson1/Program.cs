using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");

            Console.Write("Enter a: ");
            int a;
            //a = int.Parse(Console.ReadLine());
            bool s = int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($@"The expression ""a+b"" result: {a + b}");

        }
    }
}
