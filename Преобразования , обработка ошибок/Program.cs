using System;

namespace Convet
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1- конвертация TryParse , checked, 2- код с перечесленим");
            
            string s = Console.ReadLine();

            switch (s)
            {

                case "1":


                    Console.WriteLine("Say your age");
                    byte age = checked((byte)int.Parse(Console.ReadLine()));
                    // checked проверяет правильность вывода, при сужении выдает ошибку 
                    Console.WriteLine(age);

                    Console.WriteLine("Say age your brather");
                    byte ageb;
                    bool iscorrect = byte.TryParse(Console.ReadLine(), out ageb);
                    Console.WriteLine("ageb = {0}", ageb);
                    // конвертация метотодом tryParse , при ошибке выдает булевое значение 0

                break;

                    case "2":
                    Console.Write("Enter your name:");
                    string name = Console.ReadLine();
                    Console.Write("Enter your age:");
                    string ages = Console.ReadLine();
                    Console.WriteLine("Yuor Name is {0}, your age {1}", name, ages);
                    Console.Write("What is faworit day of week ");
                   

                    DayOfWeek day = (DayOfWeek) int.Parse( Console.ReadLine());

                    Console.WriteLine("Your favirit day {0}", day);


                    break;
            }
        }
    }
}