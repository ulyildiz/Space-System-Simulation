using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Satellite
    {
        public double SemiMajorAxis { get; set; }
        public double Eccentricity { get; set; }
        public double Anomaly { get; set; }
        public Vector2d Position;
        public Vector2d Velocity;
        public Vector2d GravitionalForce;
        public Vector2d AerodinamicForce;

        public Satellite()
        {
            // take input from user semi-major axis and eccentricity and anomaly  
            Console.Write("Enter the semi-major axis (in km): ");
            SemiMajorAxis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the eccentricity: ");
            Eccentricity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the anomaly (in degrees): ");
            Anomaly = Convert.ToDouble(Console.ReadLine());
        }
    }
}
