using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task001
{
    public class Circle : GeometryInterface
    {
        public const double RadiusLimitation = 0.01;

		public Circle(double radius)
		{
			if (radius - RadiusLimitation < Constants.CalculationLimitation)
				throw new ArgumentException("ERROR: Invalid circle radius.", nameof(radius));
			Radius = radius;
		}

		public double Radius { get; }

		public double GetSquare()
		{
			return Math.PI * Math.Pow(Radius, 2d);
		}

        // Diameter
        // public const double DiameterLimitation = 0.01;

		// public Circle(double diameter)
		// {
		// 	if (diameter - DiameterLimitation < Constants.CalculationLimitation)
		// 		throw new ArgumentException("Error: Invalid circle diameter.", nameof(diameter));
		// 	Diameter = diameter;
		// }

		// public double Diameter { get; }

		// public double GetSquare()
		// {
		// 	return Math.Pow(Diameter, 2d) / 4 * Math.PI;
		// }

        // Сircumference
        // public const double СircumferenceLimitation = 0.01;

		// public Circle(double circumference)
		// {
		// 	if (circumference - СircumferenceLimitation < Constants.CalculationLimitation)
		// 		throw new ArgumentException("Error: Invalid circle circumference.", nameof(circumference));
		// 	Сircumference = circumference;
		// }

		// public double Сircumference { get; }

		// public double GetSquare()
		// {
		// 	return Math.Pow(Сircumference, 2d) / (4 * Math.PI);
		// }
    }
}