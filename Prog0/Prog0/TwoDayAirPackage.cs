// Program 1A
// CIS-200-01
// Fall 2017
// Due: 9/25/2017
// By: C5503

// File: TwoDayAirPackage.cs
// The TwoDayAirPackage class is a class that is derived from the AirPackage class and is a delivery type for air packages.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver}; // Delivery type
        
        // Preconditions: Length, width, height, and weight must be greater than zero
        // Postconditions: TwoDayAirPackage is created with the below properties
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, Delivery deliveryType)
            :base( originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = deliveryType;
        }

        public Delivery DeliveryType { get; set; } // Get and set for DeliveryType, delivery type is returned and set to a value
        

        public override decimal CalcCost()
        {
            const decimal VOLUME_MULTIPLIER = .25M; // Volume multiplier in base cost equation
            const decimal WEIGHT_MULTIPLIER = .25M; // Weight multiplier in base cost equation
            const decimal DISCOUNT_MULTIPLIER = .90M; // 10% discount if saver

            decimal baseCost; // base cost calculation total

            baseCost = (VOLUME_MULTIPLIER * ((decimal)Length + (decimal)Width + (decimal)Height)) + ((WEIGHT_MULTIPLIER * (decimal)Weight)); // base cost equation

            if (DeliveryType == Delivery.Saver) // If deliverytype is saver, multiply base cost by .90 to get 10% discount
                baseCost *= DISCOUNT_MULTIPLIER;
            
            return baseCost;
        }
        
        // Preconditions: None
        // Postconditions: String including two day air package is returned with delivery type
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return string.Format($"TwoDay{base.ToString()}{NL}Deliver Type: {DeliveryType}");
        }
    }
}
