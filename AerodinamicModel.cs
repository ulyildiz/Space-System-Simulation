using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class AerodinamicModel
    {
        public const double SCd = 0.3; // Coefficient of drag for a satellite
        public const double AirDensity = 10 ^ -10; // Simplicity (to avoid dealing with the equations for the upper and lower stratosphere)

        public static double AerodynamicForce(double velocity)
        {
            return 0.5 * AirDensity * velocity * velocity * SCd; //where is cross-sectional area?
        }

        public static Vector2d AerodynamicForceVector(double altitude, Vector2d velocity)
        {
            if (altitude <= Globals.EarthRadius)
                throw new ArgumentException("Altitude must be greater than Earth radius.");
            
            double force = AerodynamicForce(velocity.Magnitude);
            double angle = Math.Atan2(velocity.Y, velocity.X); // Calculate the angle of the velocity vector

            return new Vector2d(force * Math.Cos(angle), force * Math.Sin(angle));
        }
    }
}
