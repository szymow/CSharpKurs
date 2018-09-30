
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var name in args)
            Console.WriteLine("Hello, "+name);
        }
    }
}
