// Program 1A
// CIS-200-01
// Fall 2017
// Due: 9/25/2017
// By: C5503

// File: Package.cs
// The Package class is an abstract class derived from the Parcel class and adds length, width, height, weight.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Package : Parcel
    {
        private double length; // Package length
        private double width; // Package width
        private double height; // Package height
        private double weight; // Package weight

        // Preconditions: length, width, height, and weight must be positive numbers
        // Postconditions: Package is created with the properties below
        public Package(Address originAddress, Address destAddress, double length, double width, double height, double weight)
            : base(originAddress, destAddress)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public double Length
        {
            // Preconditions: None
            // Postconditions: Length is returned
            get
            {
                return length;
            }
            // Preconditions: value must be positive
            // Postconditions: length is set to value
            set
            {
                if (value >= 0)
                    length = value;
                else
                    throw new ArgumentOutOfRangeException("Length", value,"Length must be a positive number");
            }
        }

        public double Width
        {
            // Preconditions: None
            // Postconditions: Width is returned
            get
            {
                return width;
            }
            // Preconditions: value must be positive
            // Postconditions: width is set to value
            set
            {
                if (value >= 0)
                    width = value;
                else
                    throw new ArgumentOutOfRangeException("Width", value, "Width must be a positive number");
            }
        }

        public double Height
        {
            // Preconditions: None
            // Postconditions: Height is returned
            get
            {
                return height;
            }
            // Preconditions: value must be positive
            // Postconditions: height is set to value
            set
            {
                if (value >= 0)
                    height = value;
                else
                    throw new ArgumentOutOfRangeException("Height", value, "Height must be a positive number");
            }
        }

        public double Weight
        {
            // Preconditions: None
            // Postconditions: Weight is returned
            get
            {
                return weight;
            }
            // Preconditions: value must be positive
            // Postconditions: weight is set to value
            set
            {
                if (value >= 0)
                    weight = value;
                else
                    throw new ArgumentOutOfRangeException("Weight", value, "Weight must be a positive number");
            }
        }
        // Preconditions: None
        // Postconditions: String with package dimensions and weight is returned in a formatted string
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return string.Format($"Package{NL}{base.ToString()}{NL}Length: {Length:N1}{NL}Width: {Width:N1}{NL}Height: {Height:N1}{NL}Weight: {Weight:N1}");
        }
    }
}
