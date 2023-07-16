using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task001_Test
{
    public class TriangleTest
    {
        [TestCase(-1, 1, 1)]
		[TestCase(1, -1, 1)]
		[TestCase(1, 1, -1)]
		[TestCase(0, 0, 0)]
		public void InitTriangleWithErrorTest(double a, double b, double c)
		{
			Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
		}

		[Test]
		public void InitTriangleTest()
		{
            double a = 3d, b = 4d, c = 5d;
			var triangle = new Triangle(a, b, c);
			Assert.NotNull(triangle);
			Assert.Less(Math.Abs(triangle.SideA - a), Constants.CalculationLimitation);
			Assert.Less(Math.Abs(triangle.SideB - b), Constants.CalculationLimitation);
			Assert.Less(Math.Abs(triangle.SideC - c), Constants.CalculationLimitation);
		}

		[Test]
		public void GetSquareTest()
		{		
			double a = 3d, b = 4d, c = 5d;
			double result = 6d;
			var triangle = new Triangle(a, b, c);

			var square = triangle?.GetSquare();

			Assert.NotNull(square);
			Assert.Less(Math.Abs(square.Value - result), Constants.CalculationLimitation);
		}

		[Test]
		public void InitNotTriangleTest()
		{
			Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 4));
		}

		[TestCase(3, 4, 3, ExpectedResult = false)]
		[TestCase(3, 4, 5 + 0.001, ExpectedResult = false)]
		[TestCase(3, 4, 5, ExpectedResult = true)]
		[TestCase(3, 4, 5.000000001, ExpectedResult = true)]
		public bool NotRightTriangle(double a, double b, double c)
		{

			var triangle = new Triangle(a, b, c);

			var right = triangle.RightTriangle;
 
			return right;
		}
    }
}