namespace GradeCalc
{
    internal class Program
    {
        public  int GradeValue { get; set; }

        private static int GetGradeValue()
        {
            return GradeValue;
        }

        static void Main(string[] args, int gradeInput)
        {
            Grade grade = new Grade();

            Console.WriteLine("Enter your grade value:");
            gradeInput = int.Parse(Console.ReadLine());
            //Console.WriteLine(int.TryParse(Console.ReadLine(), result: out Program.GradeValue);
        }
    }
}
