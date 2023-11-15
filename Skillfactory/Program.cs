using System;
using System.Xml.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        Semaphore Color;
        Color = (Semaphore)300;
        Console.WriteLine(Color);

        var name = "Jane";
        var age = "27";
        var favcolor = "black";

        Console.WriteLine("{0} \n {1} \n {2}", name, age, favcolor);
    }
}

enum Semaphore : int
{
   red =100,
   yellow =200,
   green = 300,

}