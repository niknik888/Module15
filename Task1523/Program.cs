using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5};
            Console.WriteLine(Average(numbers));
        }

        static double Average(int[] numbers)
        {
            
            return numbers.Sum() / (double)numbers.Length;

        }


    }
}





