using System;
using System.IO; // Dosya işlemleri için gerekli
class Program
{
    static void Main(string[] args)
    {
        // Dosya yolu
        string filePath = "Sales.txt";
        // Dosyanın varlığını kontrol et
        if (File.Exists(filePath))
        {
            try
            {
                // Dosya içeriğini oku ve her bir satırı bir dizi elemanı olarak al
                string[] salesData = File.ReadAllLines(filePath);
                double[] salesNumbers = Array.ConvertAll(salesData, double.Parse);
                // Dizi işlemleri
                double totalSales = Sum(salesNumbers);
                double averageSales = totalSales / salesNumbers.Length;
                double smallestSale = SmallestNumber(salesNumbers);
                double largestSale = LargestNumber(salesNumbers);
                // Sonuçları görüntüle
                Console.WriteLine("Satış Miktarları:");
                foreach (var sale in salesNumbers)
                {
                    Console.WriteLine($"{sale:n}");
                }
                Console.WriteLine($"\nToplam Satışlar: {totalSales:n}");
                Console.WriteLine($"Ortalama Satış Miktarı: {averageSales:N}");
                Console.WriteLine($"En Küçük Satış Miktarı: {smallestSale:n}");
                Console.WriteLine($"En Büyük Satış Miktarı: {largestSale:N}");
            }
            catch (Exception ex)
            {
                // Hata mesajını görüntüle
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"{filePath} dosyası bulunamadı.");
        }
        Console.ReadKey();
    }
    static double Sum(double[] numbers)
    {
        double total = 0;
        foreach (double number in numbers)
        {
            total += number;
        }
        return total;
    }
    static double SmallestNumber(double[] numbers)
    {
        double smallest = double.MaxValue;
        foreach (double number in numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        return smallest;
    }
    static double LargestNumber(double[] numbers)
    {
        double largest = double.MinValue;
        foreach (double number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        return largest;
    }
}