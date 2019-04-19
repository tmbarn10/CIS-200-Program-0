// Program 1A
// CIS-200-01
// Fall 2017
// Due: 9/25/2017
// By: C5503

// File: NextDayAirPackage.cs
// The NextDayAirPackage class is derived from the Airpackage class and is a delivery type that adds an express fee to get the package NextDay

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal expressFee; // Next Day Air Package requires an express fee


        // Preconditions: Length, width, height, weight, and express fee must be positive numbers
        // Postconditions: NextDayAirPackage is created with the properties below
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, double _expressFee)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        {
            // Preconditions: None
            // Postconditions: Express fee is returned
            get
            {
                return expressFee;
            }
            // Preconditions: value must be positive
            // Postconditions: Express fee is set to value
            private set
            {
                if (value >= 0)
                    expressFee = value;
                else
                    throw new ArgumentOutOfRangeException("ExpressFee", value, "ExpressFee must be a positive number");
            }
        }
        // Preconditions: None
        // Postconditions: base cost is returned after calculations
        public override decimal CalcCost()
        {
            const decimal VOLUME_MULTIPLIER = .40M; // Volume multiplier in base cost equation
            const decimal WEIGHT_MULTIPLIER = .30M; // Weight multiplier in base cost equation
            const decimal IS_HEAVY_MULTIPLIER = .25M; // IsHeavy multiplier in base cost equation
            const decimal IS_LARGE_MULTIPLIER = .25M; // IsLarge multiplier in base cost equation

            decimal baseCost; // total base cost of package

            baseCost = ((VOLUME_MULTIPLIER * ((decimal)Length + (decimal)Width + (decimal)Height)) + ((WEIGHT_MULTIPLIER * (decimal)Weight)) + ExpressFee);

            if (IsHeavy())
                baseCost += IS_HEAVY_MULTIPLIER * (decimal)Weight;
            if (IsLarge())
                baseCost += IS_LARGE_MULTIPLIER * ((decimal)Length + (decimal)Width + (decimal)Height);

            return baseCost;

        }
        // Preconditions: None
        // Postconditions: String for nextdayairpackage is formatted and returned with express fee
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return string.Format($"NextDay{base.ToString()}{NL}Express Fee: {ExpressFee:C}");
        }
    }
}
