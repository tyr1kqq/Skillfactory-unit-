using System;

namespace myInfo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello my creator \n What is your name" );
            var name = Console.ReadLine();
            Console.WriteLine("Very nice, {0} what is your age?", name);
            var age = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("You are old , your age {0}  \n When's your birthday?");
            var birthday = Console.ReadLine();
            Console.WriteLine("I remembered your date of birth: {0}", birthday);


        }
    }
}