using System;
using System.Drawing;

namespace Circle_Objects_Lab
{
	public class Circle
	{
        public double radius { get; set; }
        //public double circumferance { get; set; }
        //public decimal area { get; set; }
        //Constructor
        public Circle (double _radius)
        {
            radius = _radius;
        }

        //Methods
        public double CalculateCircumference()
        {
            return Math.PI * radius * 2;
        }
        public double CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private double FormatNumber (double x)
        {
            return Math.Round(x, 2);
        }
        public string GetDetails()
        {
            return String.Format("{0,-15} {1,-15} {2, -15}", $"{radius}", $"{CalculateFormattedCircumference()}", $"{CalculateFormattedArea()}");
        }
    }
}

