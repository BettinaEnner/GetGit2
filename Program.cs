namespace GetGit
{ 
internal class Program
    {
    private static void Main(string[] args)
        {
            Square square1 = new Square (5);
            Shape square2 = new Square (2);


            Console.WriteLine($"Area of the Square: {square1.GetArea()}");
            Console.WriteLine($"Area of the Square: {square2.GetArea()}");
        }
    }
}