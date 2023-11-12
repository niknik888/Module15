using System;

namespace Module15
{
    class Program
    {

        static void Main(string[] args)
        {
            var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();


            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы не ввели текст");
                return;
            }

            Console.WriteLine("Вывод: ");

            Console.WriteLine(text.Except(punctuation).ToArray());
        }
    }
}
