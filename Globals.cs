using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Vector2d
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Magnitude => Math.Sqrt(X * X + Y * Y);
        public Vector2d(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static Vector2d operator +(Vector2d a, Vector2d b)
        {
            return new Vector2d(a.X + b.X, a.Y + b.Y);
        }
        public static Vector2d operator -(Vector2d a, Vector2d b)
        {
            return new Vector2d(a.X - b.X, a.Y - b.Y);
        }
        public static Vector2d operator *(Vector2d v, double scalar)
        {
            return new Vector2d(v.X * scalar, v.Y * scalar);
        }
        public static Vector2d operator /(Vector2d v, double scalar)
        {
            return new Vector2d(v.X / scalar, v.Y / scalar);
        }

    }

    public static class Globals
    {
        public const double GravitationalConstant = 6.67430e-11; // m^3 kg^-1 s^-2  
        public const double EarthMass = 5.972e24; // kg  
        public const double EarthRadius = 6371e3; // m  
        public const double TimeStep = 60; // seconds, for simulation purposes  
        public static readonly double g0 = GravitationalConstant * EarthMass / (EarthRadius * EarthRadius); // m/s^2  

        public static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
        public static double ToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }
    }
}
