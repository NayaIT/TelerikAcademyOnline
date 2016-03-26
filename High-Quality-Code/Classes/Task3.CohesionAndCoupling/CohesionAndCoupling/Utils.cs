
namespace CohesionAndCoupling
{
    using System;

    internal static class Utils
    {
        internal static double Width { get; set; }
        internal static double Height { get; set; }
        internal static double Depth { get; set; }

        internal static double CalculateVolume()
        {
            var volume = Width * Height * Depth;
            return volume;
        }

        internal static double CalculateDiagonalXYZ()
        {
            var distance = CalculateDistance.CalculateDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        internal static double CalculateDiagonalXY()
        {
            var distance = CalculateDistance.CalculateDistance2D(0, 0, Width, Height);
            return distance;
        }

        internal static double CalculateDiagonalXZ()
        {
            var distance = CalculateDistance.CalculateDistance2D(0, 0, Width, Depth);
            return distance;
        }

        internal static double CalculateDiagonalYZ()
        {
            var distance = CalculateDistance.CalculateDistance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}