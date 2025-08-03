namespace TriangleIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangletype triangle = new Triangletype();
            Console.WriteLine("Enter the first side of the triangle below");
            int firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side of the triangle below");
            int secondSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last side of the triangle below to determine the type");
            int thirdSide = int.Parse(Console.ReadLine());

            if (firstSide <=0 || secondSide<=0 || thirdSide<=0)
            {
                Console.WriteLine("The sides of a triangle must be greater than zero. Please enter valid side lengths.");
                Console.WriteLine("Re-enter the first side of the triangle below");
                int firstSide1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Re-nter the second side of the triangle below");
                int secondSide1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Re-enter the last side of the triangle below to determine the type");
                int thirdSide1 = int.Parse(Console.ReadLine());
                triangle.IdentifyTriangle(firstSide1, secondSide1, thirdSide1);
            }

            triangle.IdentifyTriangle(firstSide, secondSide, thirdSide);
        }
    }
}
