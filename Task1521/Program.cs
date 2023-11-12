using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Factorial(5));
        }

        static long Factorial(int number)
        {

            var numbers = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                numbers.Add(i);

            }

            long result = numbers.Aggregate((x, y) => x * y);
            return result;
        }
    }
}
