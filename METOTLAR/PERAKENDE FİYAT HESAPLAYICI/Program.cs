using System;

namespace PerakendeFiyatHesaplayici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ürünün toptan satış maliyetini giriniz (TL): ");
            double wholesaleCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kâr marjı yüzdesini giriniz (%): ");
            double profitMargin = Convert.ToDouble(Console.ReadLine());

            double retailPrice = CalculateRetail(wholesaleCost, profitMargin);

            Console.WriteLine($"Ürünün perakende fiyatı: {retailPrice:0.00} TL");
            Console.ReadKey();
        }

        static double CalculateRetail(double wholesaleCost, double profitMargin)
        {
            double profit = (profitMargin / 100) * wholesaleCost;
            return wholesaleCost + profit;
        }
    }
}
