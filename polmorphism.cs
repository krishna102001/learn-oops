using System;
public class Animal
{
    public void Sound()
    {
        Console.WriteLine("the animal make sound");
    }
}

public class Pig : Animal
{
    public void Sound()
    {
        Console.WriteLine("the pig make sound");
    }
}

public class Dog : Animal
{
    public void Sound()
    {
        Console.WriteLine("the dog make sound");
    }
}

public class Program
{
    public static void Main()
    {
        Animal ani = new Animal();
        Animal mypig = new Pig();
        Pig myPig = new Pig();
        Animal mydog = new Dog();
        ani.Sound();
        mypig.Sound();
        mydog.Sound();
        myPig.Sound();
    }
}