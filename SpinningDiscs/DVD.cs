using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public DVD (string discLabel) : base(discLabel, "DVD", 570, 1600, 47000)
        {

        }
        // TODO: Implement your custom interface.
        //public void SpinDisc()
        //{
        //    Console.WriteLine($"A {type} spins at a rate of {DiscMinSpeed} - {DiscMaxSpeed} rpm.");
        //}

       
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
