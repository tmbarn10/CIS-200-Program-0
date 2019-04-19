// Program 1A
// CIS-200-01
// Fall 2017
// Due: 9/25/2017
// By: C5503

// File: GroundPackage.cs
// The GroundPackage class is derived from the Package class and uses a method to calculate ZoneDistance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class GroundPackage : Package
    {
        // Preconditions: Length, width, height, weight, must be positive numbers
        // Postconditions: GroundPackage is created with the properties below
        public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight)
            : base(originAddress, destAddress, length, width, height, weight)
        {

        }
        
        // Preconditions: None
        // Postconditions: Zonedistance is calculated using absolute value of formula and is returned
        public int ZoneDistance
        {
           get
            {
                const int FIRST_DIGIT_DIVIDER = 10000; // First digit divider used to get the first digit of each address
                int zoneDistance; // zoneDistance int

                zoneDistance = Math.Abs((OriginAddress.Zip / FIRST_DIGIT_DIVIDER) - (DestinationAddress.Zip / FIRST_DIGIT_DIVIDER));

                return zoneDistance;
            }
        }
        
        // Preconditions: Length, width, height, weight must be positive
        // Postconditions: GroundPackage cost is calculated and returned
        public override decimal CalcCost()
        {
            const decimal VOLUME_MULTIPLIER = .20M;
            const decimal WEIGHT_MULTIPLIER = .05M;

            return (VOLUME_MULTIPLIER * ((decimal)Length + (decimal)Width + (decimal)Height)) + (WEIGHT_MULTIPLIER * (ZoneDistance + 1) * (decimal)Weight);
        }

        // Preconditions: None
        // Postconditions: String with groundpackage data and zonedistance is formatted and returned
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return string.Format($"Ground{base.ToString()}{NL}Zone Distance: {ZoneDistance:D}");
        }
    }

}
