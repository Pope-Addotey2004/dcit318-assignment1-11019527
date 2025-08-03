using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalc
{
    
    internal class Grade
    {
        public int GradeValue { get; set; } =  int.Parse(Console.ReadLine());
        public string GradeLetter { get; set; }

        public  string  GradeCalculation(int gradeValue)
        {
            if (gradeValue >= 90)
            {
                GradeLetter = "A";
                Console.WriteLine("You got an A!");
            }
            else if (gradeValue >= 80)
            {
                GradeLetter = "B";
                Console.WriteLine("You got a B!");
            }
            else if (gradeValue >= 70)
            {
                GradeLetter = "C";
                Console.WriteLine("You got a C!");
            }
            else if (gradeValue >= 60)
            {
                GradeLetter = "D";
                Console.WriteLine("You got a D!");
            }
            else if (gradeValue < 60)
            {
                GradeLetter = "F";
                Console.WriteLine("You got an F!");
            }
            

                return GradeLetter;
            
        }
    }
}
