using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleIdentifier
{
    internal class Triangletype
    {

        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public string TriangleName = "";

        public string IdentifyTriangle(int Side1, int Side2, int Side3)
        {
            if (Side1 == Side2 && Side2 == Side3)
            {
                TriangleName = "Equilateral Triangle";
                Console.WriteLine("All the sides are equal so therefore it is an: " + TriangleName);
            }
            else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
            {
                TriangleName = "Isosceles Triangle";
                Console.WriteLine("Two sides are equal so therefore it is an: " + TriangleName);
            }
            else if (Side1 != Side2 && Side2 != Side3 && Side1 != Side3)
            {
                TriangleName = "Scalene Triangle";
                Console.WriteLine("All the sides are different so therefore it is a: " + TriangleName);
            }

            return TriangleName;
            {

            }

        }
    }
}

