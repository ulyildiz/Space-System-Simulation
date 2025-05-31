using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class GravityModel
    {
        public static double CalculateGravitationalForce(double distance)
        {
            double tmp = Globals.EarthRadius / (Globals.EarthRadius + distance);
            return Globals.g0 * tmp * tmp; 
        }

        public static Vector2d CalculateGravitationalForceVector(Vector2d position)
        {
            double distance = position.Magnitude - Globals.EarthRadius;
            if (distance <= 0)
                throw new ArgumentException("Position must be greater than Earth radius.");
            
            double forceMagnitude = CalculateGravitationalForce(distance);
            double angle = Math.Atan2(position.Y, position.X); // Calculate the angle of the position vector

            return new Vector2d(-forceMagnitude * Math.Cos(angle), -forceMagnitude * Math.Sin(angle)); // Negative because gravity pulls towards the center of the Earth
        }
    }
}
