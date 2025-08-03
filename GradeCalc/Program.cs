namespace GradeCalc
{
    internal class Program
    {
        public int GradeValue { get; set; }

        static void Main(string[] args)
        {
            Grade grade = new();

            Console.WriteLine("Enter your grade value:");
            int gradeInput = int.Parse(Console.ReadLine());

            if (gradeInput < 0 || gradeInput > 100)
            {
                Console.WriteLine("Invalid grade value. Please enter a value between 0 and 100.");
                gradeInput = int.Parse(Console.ReadLine());
                grade.GradeCalculation(gradeInput);
                return;
            }
            
            grade.GradeCalculation(gradeInput);
            Console.WriteLine(grade.GradeLetter);
            
        }
    }
}
