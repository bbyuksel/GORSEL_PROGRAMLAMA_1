using System.Collections.Generic;
using System;
using System.IO; // Dosya işlemleri için
class Program
{
    static void Main(string[] args)
    {
        // Dosya yolları
        string teamsFilePath = "Teams.txt";
        string winnersFilePath = "WorldSeriesWinners.txt";
        // Takımları ve World Series kazananlarını yükleyin
        List<string> teams = LoadTeams(teamsFilePath);
        List<string> winners = LoadWinners(winnersFilePath);
        // Kullanıcıdan bir takım seçmesini isteyin
        Console.WriteLine("Dünya Serisi kazanan takımlar listesi:");
        foreach (var team in teams)
        {
            Console.WriteLine(team);
        }
        Console.WriteLine("\nBir takım adı girin (tam adını yazın):");
        string selectedTeam = Console.ReadLine();
        // Seçilen takımın kazanma sayısını ve yıllarını hesaplayın
        var winDetails = CountWinsAndYears(selectedTeam, winners);
        // Sonucu gösterin
        if (winDetails.Count > 0)
        {
            Console.WriteLine($"\n{selectedTeam}, 1903'ten 2012'ye kadar Dünya Serisi'ni { winDetails.Count} kez kazanmıştır. Kazanılan yıllar:");
        foreach (var year in winDetails)
            {
                Console.WriteLine(year);
            }
        }
        else
        {
            Console.WriteLine($"\n{selectedTeam} isimli takım listemizde bulunamadı veya 1903'ten 2012'ye kadar olan dönemde Dünya Serisi kazanmamıştır.");
        }
        Console.ReadKey();  
    }
    static List<string> LoadTeams(string filePath)
    {
        try
        {
            var lines = File.ReadAllLines(filePath);
            return new List<string>(lines);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            return new List<string>(); // Boş liste döndür
        }
    }
    static List<string> LoadWinners(string filePath)
    {
        try
        {
            var lines = File.ReadAllLines(filePath);
            return new List<string>(lines);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            return new List<string>(); // Boş liste döndür
        }
    }
    static List<int> CountWinsAndYears(string team, List<string> winners)
    {
        List<int> winYears = new List<int>();
        int startYear = 1903;
        for (int i = 0; i < winners.Count; i++)
        {
            if (winners[i].Equals(team, StringComparison.OrdinalIgnoreCase))
            {
                // 1904 ve 1994 yıllarında World Series oynanmadı
                if (startYear == 1904 || startYear == 1994)
                {
                    startYear++;
                }
                winYears.Add(startYear);
            }
            startYear++;
            // 1904 ve 1994 atlamalarını dikkate alma
            if (startYear == 1904 || startYear == 1994)
            {
                startYear++;
            }
        }
        return winYears;
    }
}