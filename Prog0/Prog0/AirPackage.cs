// Program 1A
// CIS-200-01
// Fall 2017
// Due: 9/25/2017
// By: C5503

// File: AirPackage.cs
// The AirPackage class is derived from the Package class and adds whether package can be considered heavy or large.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage : Package
    {
        public const double IS_HEAVY = 75; // If package is >=75, is considered heavy
        public const double IS_LARGE = 100; // If package is >=100 is considered large

        // Preconditions: Length, width, height, weight, must be positive numbers
        // Postconditions: AirPackage is created with the properties below
        public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight)
            : base(originAddress, destAddress, length, width, height, weight)
        {

        }

        // Preconditions: None
        // Postconditions: True if package weight is greater than or equal to 75, false if not
        public bool IsHeavy()
        {
            return (Weight >= IS_HEAVY);
        }
        // Preconditions: None
        // Postconditions: True if package weight is greater than or equal to 100, false if not
        public bool IsLarge()
        {
            return ((Length + Width + Height) >= IS_LARGE);
        }

        // Preconditions: None
        // Postconditions: String with AirPackage data is formatted and returned with true and false values for IsHeavy and IsLarge
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return string.Format($"Air{base.ToString()}{NL}IsHeavy: {IsHeavy()}{NL}IsLarge: {IsLarge()}");
        }
    }
}
