using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        private const string discType = "CD";
        private const int discMinSpeed = 200;
        private const int discMaxSpeed = 500;
        private const int discCapacity = 800;
        public CD(string discLabel) : base(discLabel, discType, discMinSpeed, discMaxSpeed, discCapacity)
        {

        }
        // TODO: Implement your custom interface.
        
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
