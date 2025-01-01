using System;
public class Animal
{
    //data is hidden 
    private string animalname;
    private int animalcount;

    // method 
    public string Name
    {
        get { return animalname; }
        set { animalname = value; }
    }

    public int Count
    {
        get { return animalcount; }
        set { animalcount = value; }
    }
}

public class Program
{
    public static void Main()
    {
        Animal ani = new Animal();
        ani.Name = "Lion";
        ani.Count = 10;
        Console.WriteLine("Animal name is " + ani.Name + " total no. is " + ani.Count);
    }
}