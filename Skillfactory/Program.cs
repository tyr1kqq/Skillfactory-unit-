using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Semaphore Color;
        Color = (Semaphore)300;
        Console.WriteLine(Color);
    }
}

enum Semaphore : int
{
   red =100,
   yellow =200,
   green = 300,

}