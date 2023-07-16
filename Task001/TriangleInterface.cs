using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task001
{
    public interface TriangleInterface
    {
        double SideA { get; }
		double SideB { get; }
		double SideC { get; }
		
		bool RightTriangle { get; }
    }
}