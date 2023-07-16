using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task001
{
    public class Triangle : TriangleInterface
    {
        private double limiter = Constants.CalculationLimitation;

		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA < limiter)
				throw new ArgumentException("ERROR: Wrong side specified.", nameof(sideA));

			if (sideB < limiter)
				throw new ArgumentException("ERROR: Wrong side specified.", nameof(sideB));

			if (sideC < limiter)
				throw new ArgumentException("ERROR: Wrong side specified.", nameof(sideC));

			var maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
			var perimeter = sideA + sideB + sideC;
			if ((perimeter - maxSide) - maxSide < Constants.CalculationLimitation)
				throw new ArgumentException("The largest side of the triangle must be less than the sum of the other two sides.");

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;

			_RightTriangle = new Lazy<bool>(GetRightTriangle);
		}

		public double SideA { get; }
		public double SideB { get; }
		public double SideC { get; }

		private readonly Lazy<bool> _RightTriangle;
		public bool RightTriangle => _RightTriangle.Value;

		private bool GetRightTriangle()
		{
			double maxSide = SideA, b = SideB, c = SideC;
			if (b - maxSide > Constants.CalculationLimitation)
				Swap.SwapArray(ref maxSide, ref b);

			if (c - maxSide > Constants.CalculationLimitation)
				Swap.SwapArray(ref maxSide, ref c);

			return Math.Abs(Math.Pow(maxSide, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < Constants.CalculationLimitation;
		}

		public double GetSquare()
		{
			var semiPerimeter = (SideA + SideB + SideC) / 2d;
			var square = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));

			return square;
		}
    }
}