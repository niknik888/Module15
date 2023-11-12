namespace Module15
{
    class Program
    {
        public static List<int> Numbers = new List<int>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число: ");
                var number = Console.ReadLine();
                var isInteger = Int32.TryParse(number, out int inputNum);


                if (!isInteger)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы ввели не число");
                }
                else
                {
                    Numbers.Add(inputNum);

                    Console.WriteLine("-----");
                    Console.WriteLine("Число " + number + " добавлено в список.");
                    Console.WriteLine($"Всего в списке { Numbers.Count } чисел");
                    Console.WriteLine($"Сумма:  {Numbers.Sum()}");
                    Console.WriteLine($"Наибольшее:  {Numbers.Max()}");
                    Console.WriteLine($"Наименьшее:  {Numbers.Min()}");
                    Console.WriteLine($"Среднее:  {Numbers.Average()}");
                    Console.WriteLine("-----");
                    Console.WriteLine();
                }
            }
        }
    }
}