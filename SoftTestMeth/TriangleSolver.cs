using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTestMeth
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            string result=null;
            if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))//Conditions for Equilateral triangle
            {
                if ((side1 == side2) && (side2 == side3))
                {
                    result= "Equilateral";
                }
                else if (((side1 == side2) && (side2 != side3)) || ((side2 == side3) && (side3 != side1)) || ((side1 == side3) && (side3 != side2)))// Conditions for Isosceles triangle
                {
                    result="Isosceles";
                }
                else if ((side1 != side2) && (side2 != side3)&&(side1!=side3))// Conditions for Scalene triangle
                 {
                    result="Scalene";
                }

            }
            else
            {
                result="Invalid Sides! Cannot form a triangle";
            }
            return result;

        }
    }
}
