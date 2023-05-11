using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Film joker = new Film("Joker", 122);
        Film interstellar = new Film("Interstellar", 169);

        Salon salon1 = new Salon("Salon 1", 100);
        Salon salon2 = new Salon("Salon 2", 50);

        Seans seans1 = new Seans(new DateTime(2023, 5, 12, 14, 0, 0), salon1, joker);
        Seans seans2 = new Seans(new DateTime(2023, 5, 12, 16, 0, 0), salon2, interstellar);

        List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

        Console.WriteLine("Seanslar:");
        Console.WriteLine("==========================================================================:");
        Console.WriteLine($"1- {joker.Ad} - {seans1.Tarih.ToString("dd.MM.yyyy HH:mm")} - {salon1.Ad}");
        Console.WriteLine($"2- {interstellar.Ad} - {seans2.Tarih.ToString("dd.MM.yyyy HH:mm")} - {salon2.Ad}");
        Console.WriteLine("Hangi seans için bilet almak istersiniz? (1/2): ");
        Console.WriteLine("==========================================================================:");
        int seansNo = int.Parse(Console.ReadLine());

        Seans secilenSeans = seansNo == 1 ? seans1 : seans2;
        Console.WriteLine("==========================================================================:");
        Console.WriteLine($"Seçilen film: {secilenSeans.Film.Ad}");
        Console.WriteLine($"Salon: {secilenSeans.Salon.Ad}");
        Console.WriteLine($"Tarih: {secilenSeans.Tarih.ToString("dd.MM.yyyy HH:mm")}");
        Console.WriteLine("==========================================================================:");

        Console.WriteLine("Kaç adet bilet istersiniz?: ");
        int biletSayisi = int.Parse(Console.ReadLine());

        for (int i = 1; i <= biletSayisi; i++)
        {
            Console.Write($"{i}. koltuk numarası: ");
            int koltukNo = int.Parse(Console.ReadLine());

            Console.Write($"{i}. müşteri adı: ");
            string musteriAd = Console.ReadLine();

            Rezervasyon rezervasyon = new Rezervasyon(secilenSeans, koltukNo, musteriAd);
            rezervasyonlar.Add(rezervasyon);

            Console.WriteLine($"Biletiniz hazırlandı. Koltuk no: {koltukNo}");
        }

        Console.WriteLine("Rezervasyonlarınız:");
        foreach (var rezervasyon in rezervasyonlar)
        {
            Console.WriteLine($"{rezervasyon.KoltukNo} numaralı koltuk - {rezervasyon.MusteriAd}");
        }
    }
}