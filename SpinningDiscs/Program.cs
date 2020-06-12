using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD myCD = new CD("Cool CD");
            DVD myDVD = new DVD("Cool DVD");

            // TODO: Call each CD and DVD method to verify that they work as expected.
            myCD.SpinDisc();
            Console.WriteLine(myCD.ToString());
            myCD.WriteData("What");
            myCD.WriteData("is");
            myCD.WriteData("this");
            myCD.WriteData("doing?");
            Console.WriteLine(myCD.ToString());
            myCD.ReadData();


            myDVD.SpinDisc();
            Console.WriteLine(myDVD.ToString());
            myDVD.WriteData("All");
            myDVD.WriteData("the");
            myDVD.WriteData("pretty");
            myDVD.WriteData("horses");
            Console.WriteLine(myDVD.ToString());
            myDVD.ReadData();
        }
    }
}
