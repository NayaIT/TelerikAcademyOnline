﻿namespace Abstraction
{
    using System;

    class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius of the circle should be a positive number!");
                }

                this.radius = value;
            }
        }

        internal override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        internal override double CalculateSurface()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }
    }
}