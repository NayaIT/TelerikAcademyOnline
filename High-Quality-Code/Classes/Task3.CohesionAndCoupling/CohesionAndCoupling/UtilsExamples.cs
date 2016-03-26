/*Task 3. Cohesion and Coupling
Take the VS solution Cohesion-and-Coupling and refactor its code to follow the principles of good abstraction, loose coupling and strong cohesion.
Split the class Utils to other classes that have strong cohesion and are loosely coupled internally.*/

namespace CohesionAndCoupling
{
    using System;

    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(GeometryUtils.GetFileExtension("example"));
            Console.WriteLine(GeometryUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(GeometryUtils.GetFileExtension("example.new.pdf"));
                              
            Console.WriteLine(GeometryUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(GeometryUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(GeometryUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", CalculateDistance.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CalculateDistance.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Utils.Width = 3;
            Utils.Height = 4;
            Utils.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Utils.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Utils.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils.CalculateDiagonalYZ());
        }
    }
}