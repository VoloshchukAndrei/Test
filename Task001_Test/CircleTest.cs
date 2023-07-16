using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task001_Test
{
    public class CircleTest
    {
        private double RadiusLimitation = 0.01;
		
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void ZeroRadiusTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(0d));
		}


		[Test]
		public void NegativeRadiusTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(-1d));
		}


		[Test]
		public void RadiusLimitationTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(Circle.RadiusLimitation - 0.01));
		}
		
		
		[Test]
		public void GetSquareTest()
		{
			var radius = 7;
			var circle = new Circle(radius);
			var expectedSquare = Math.PI * Math.Pow(radius, 2d); 

			var square = circle.GetSquare();
			
			Assert.Less(Math.Abs(square-expectedSquare), RadiusLimitation);
		}
    }
}