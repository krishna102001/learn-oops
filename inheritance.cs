using System;
public class Animal
{
    //field defined
    public string animalname;

    // constructor
    public Animal()
    {
        this.animalname = "Lion";
    }

    //method
    public void Eat()
    {
        Console.WriteLine("Animal can eat");
    }
}

public class Dog : Animal
{
    public string dogname;

    public Dog()
    {
        this.dogname = this.animalname;
    }

    public void Bark()
    {
        Console.WriteLine("Bark Bark Bark!!");
    }
}

public class Program
{
    public static void Main()
    {
        Animal ani = new Animal();
        Dog myDog = new Dog();
        Console.WriteLine(myDog.dogname);
        ani.Eat();

    }
}