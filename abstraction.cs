using System;

//abstarct class
public abstract class Animal
{
    private string animalname;
    private int animalcount;

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

    //abstarct method 
    public abstract void Display();
}


public class Lion : Animal
{
    //override the abstract to implement the Display method
    public override void Display()
    {
        Console.WriteLine("Animal name is " + Name + " total is " + Count);
    }
}

public class Program
{
    public static void Main()
    {
        Lion newLion = new Lion();
        newLion.Name = "Lion";
        newLion.Count = 20;
        newLion.Display();
    }
}