using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleLibrary
{
   public enum TriangleType
    {
        Scalene = 1, // No 2 sides are the same length
        Isosceles = 2, // 2 sides are the same length and 1 side is different
        Equilateral = 3, // All 3 sides are the same length
        Error = 4 // the 3 sides can not create a triangle
    }
}
