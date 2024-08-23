using Refernces;
using System;

internal class Program
{
    static void Main(string[] args)
    {   // creates the first sedan
        Sedan myFirstSedan = new Sedan(0);
        IAutoMobile myAutomobile = myFirstSedan;
        //creates a new sedan
        Sedan myOtherSedan = new Sedan(0);
        //prints speed to console and compares to other automobile
        myFirstSedan.IncreaseSpeed();
        Console.WriteLine(myFirstSedan.Speed);
        Console.WriteLine(myAutomobile.Speed);
        Console.WriteLine(myFirstSedan.Equals(myAutomobile));
        //prints speed to console and compares to other automobile
        myOtherSedan.IncreaseSpeed();
        Console.WriteLine(myFirstSedan.Speed);
        Console.WriteLine(myAutomobile.Speed);
        Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

        Truck myTruck = new Truck(50, 500, "MyTruck");
        //calls stringify method and describes automobiles
        myFirstSedan.Stringify();
        myAutomobile.Stringify();
        myOtherSedan.Stringify();
        myTruck.Stringify();
    }
}
}