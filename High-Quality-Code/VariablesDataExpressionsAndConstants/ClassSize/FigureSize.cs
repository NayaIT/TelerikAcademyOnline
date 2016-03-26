namespace VariablesDataExpressionsAndConstants
{
    using System;

    public class Size
    {
        private double width;

        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width should be positive value!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be positive value!");
                }

                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size figure, double rotatedAngleOfTheFigure)
        {
            double dimensionWidthSin = Math.Abs(Math.Sin(rotatedAngleOfTheFigure) * figure.Width);
            double dimensionWidthCos = Math.Abs(Math.Cos(rotatedAngleOfTheFigure) * figure.Width);
            double dimensionHeightSin = Math.Abs(Math.Sin(rotatedAngleOfTheFigure) * figure.Height);
            double dimensionHeightCos = Math.Abs(Math.Cos(rotatedAngleOfTheFigure) * figure.Height);

            double rotatedFigureWidth = dimensionWidthCos + dimensionHeightSin;
            double rotatedFigureHeight = dimensionWidthSin + dimensionHeightCos;

            Size rotatedFigure = new Size(rotatedFigureWidth, rotatedFigureHeight);

            return rotatedFigure;
        }
    }
}