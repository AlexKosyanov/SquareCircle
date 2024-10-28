using Square;

namespace SquareCircle 
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Circle cir = new Circle();

            Console.WriteLine(cir.Square(8).ToString());

            Console.ReadKey();
        }
    }
}

