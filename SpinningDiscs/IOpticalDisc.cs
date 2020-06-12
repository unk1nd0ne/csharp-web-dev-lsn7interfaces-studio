using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IOpticalDisc
    {
        void SpinDisc();

        void WriteData(string toWrite);

        void ReadData();
    }
}
