using System;

class Program
{
    static void Main(string[] args)
    {

        Circle myCircle = new Circle(12);
        // myCircle.SetRadius(12);
        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}

//if a method is only needed inside of a class, make it private
