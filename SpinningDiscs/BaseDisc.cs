using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        private static int nextId = 1;
        private int diskId { get; }
        private string DiscLabel { get; }
        private string DiscType;
        private int DiscMinSpeed;
        private int DiscMaxSpeed;
        private int DiscCapacity;
        private int DiscFreeSpace;
        private List<string> DiscData = new List<string>();
        private bool DiscOpen = true;
        
        
        public BaseDisc ()
        {
            diskId = nextId;
            nextId++;
        }

        public BaseDisc (string discLabel, string discType, int discMinSpeed, int discMaxSpeed, int discCapacity) : this()
        {
            DiscLabel = discLabel;
            DiscType = discType;
            DiscMinSpeed = discMinSpeed;
            DiscMaxSpeed = discMaxSpeed;
            DiscCapacity = discCapacity;
            DiscFreeSpace = discCapacity;
        }

        public void SpinDisc()
        {
            Console.WriteLine($"A {DiscType} spins at a rate of {DiscMinSpeed} - {DiscMaxSpeed} rpm.");
        }

        public void WriteData(string toWrite)
        {
            if (DiscOpen)
            {
                DiscData.Add(toWrite);
                DiscFreeSpace--;
                if (DiscFreeSpace == 0)
                {
                    DiscOpen = false;
                }
            }
            else
            {
                Console.WriteLine("ERROR: Disc Closed!");
            }

        }

        public void ReadData()
        {
            foreach (string item in DiscData)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }

        public override bool Equals(object obj)
        {
            return obj is BaseDisc disc &&
                   diskId == disc.diskId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(diskId);
        }

        public override string ToString()
        {
            Dictionary<string, string> toStringDict = new Dictionary<string, string>();
            toStringDict.Add("Disc Label", DiscLabel);
            toStringDict.Add("Capacity", $"{DiscCapacity}");
            toStringDict.Add("Space Remaining", $"{DiscFreeSpace}");
            string toStringStr = "\n";

            foreach (string key in toStringDict.Keys)
            {
                toStringStr += $"{key}: {toStringDict[key]}\n";
                //Console.WriteLine($"{key}: {toStringDict[key]}\n");
            }

            return toStringStr;
        }
    }
}
