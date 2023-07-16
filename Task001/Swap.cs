using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task001
{
    public static class Swap
    {
        public static void SwapArray<T>(ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}
    }
}