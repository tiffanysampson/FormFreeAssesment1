using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleLibrary
{
    public class TriangleModel
    {
        /// <summary>
        /// Represents side 1 of the triangle
        /// </summary>
        public int TriangleSide1 { get; set; }
        /// <summary>
        /// Represents side 2 of the triangle
        /// </summary>
        public int TriangleSide2 { get; set; }
        /// <summary>
        /// Represents side 3 of the triangle
        /// </summary>
        public int TriangleSide3 { get; set; }
        /// <summary>
        /// Creating new ShapeModel class
        /// </summary>
        public TriangleModel()
        { }
        /// <summary>
        /// Creating new ShapeModel object and parsing the entered values to int 
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public TriangleModel(string side1, string side2, string side3)
        {
            //Parse the input data for the 3 sides of the triangle
            int placenumber1 = 0;
            int.TryParse(side1, out placenumber1);
            TriangleSide1 = placenumber1;

            int placenumber2 = 0;
            int.TryParse(side2, out placenumber2);
            TriangleSide2 = placenumber2;

            int placenumber3 = 0;
            int.TryParse(side3, out placenumber3);
            TriangleSide3 = placenumber3;
        }

        /// <summary>
        /// Returns the Triangletype depending on values entered for the 3 sides.
        /// </summary>
        /// <param name="trianglemd"></param>
        /// <returns></returns>
        public TriangleType GetTriangleType(TriangleModel trianglemd)
        {
            if (trianglemd.TriangleSide1 <= 0 || trianglemd.TriangleSide2 <= 0 || trianglemd.TriangleSide3 <= 0)
            {
                return TriangleType.Error;
            }

            if (trianglemd.TriangleSide1 == trianglemd.TriangleSide2 && trianglemd.TriangleSide1 == trianglemd.TriangleSide3)
            {
                return TriangleType.Equilateral;
            }
            else if (trianglemd.TriangleSide1 == trianglemd.TriangleSide2 || trianglemd.TriangleSide1 == trianglemd.TriangleSide3 || trianglemd.TriangleSide2 == trianglemd.TriangleSide3)
            {
                return TriangleType.Isosceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }
    }
}
