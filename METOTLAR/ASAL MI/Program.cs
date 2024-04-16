using System;

namespace AsalSayiKontrolu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = IsPrime(number);

            if (isPrime)
                Console.WriteLine($"{number} bir asal sayıdır.");
            else
                Console.WriteLine($"{number} bir asal sayı değildir.");
            Console.ReadKey();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
