using System;

namespace Convet
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Say your age");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            // checked проверяет правильность вывода, при сужении выдает ошибку 
            Console.WriteLine(age);

            Console.WriteLine("Say age your brather");
            byte ageb;
            bool iscorrect =  byte.TryParse(Console.ReadLine(), out ageb);
            Console.WriteLine("ageb = {0}",ageb);
        }
    }
}