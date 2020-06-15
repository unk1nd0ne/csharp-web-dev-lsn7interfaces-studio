using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        private const string discType = "DVD";
        private const int discMinSpeed = 570;
        private const int discMaxSpeed = 1600;
        private const int discCapacity = 47000;
        public DVD (string discLabel) : base(discLabel, discType, discMinSpeed, discMaxSpeed, discCapacity)
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
