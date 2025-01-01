using System;
public class HelloWorld
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
        Console.Write("enter your name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + " How are you!");
    }
}