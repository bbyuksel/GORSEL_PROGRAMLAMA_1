using System;

namespace KaloriHesaplayici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yağ gramını giriniz: ");
            double fat = Double.Parse(Console.ReadLine());

            Console.Write("Karbonhidrat gramını giriniz: ");
            double carb = Double.Parse(Console.ReadLine());

            double totalFatCalories = FatCalories(fat);
            double totalCarbCalories = CarbCalories(carb);

            Console.WriteLine($"Toplam yağ kalorisi: {totalFatCalories}");
            Console.WriteLine($"Toplam karbonhidrat kalorisi: {totalCarbCalories}");
            Console.ReadKey();
        }

        static double FatCalories(double fat)
        {
            double totalCalories = 0;
            totalCalories += fat * 9;
            return totalCalories;
        }

        static double CarbCalories(double carb)
        {
            double totalCalories = 0;
            totalCalories += carb * 4;
            return totalCalories;
        }
    }
}
