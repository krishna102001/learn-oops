using System;
public class Shape
{

    //field define
    public int a, b;

    //constructor 
    public Shape(int num1, int num2)
    {
        this.a = num1;
        this.b = num2;
    }

    //method display is defined
    public void display()
    {
        Console.WriteLine("multiplication of a and b is : " + (a * b));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // object is created of shape datatype variable newshape 
        Shape newshape = new Shape(2, 3);
        newshape.display();
    }
}