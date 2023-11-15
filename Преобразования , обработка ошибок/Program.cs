using System;

namespace Convet
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Say your age");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine(age);
        }
    }
}