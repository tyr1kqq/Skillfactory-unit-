using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string myName = "Igor";
        byte MyAge = 23;
        bool MyPeet = true;
        double MyShoeSize = 41;

        Console.WriteLine("My name is " + myName);
        Console.WriteLine("My age is " + MyAge);
        Console.WriteLine("I have pet? " + MyPeet);
        Console.WriteLine("Shoe size - " + MyShoeSize);
        Console.WriteLine(myName);

        Console.ReadKey();
    }
}