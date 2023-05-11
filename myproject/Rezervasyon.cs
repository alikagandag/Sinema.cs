using System;

class Rezervasyon
{
    public Seans Seans { get; set; }
    public int KoltukNo { get; set; }
    public string MusteriAd { get; set; }

    public Rezervasyon(Seans seans, int koltukNo, string musteriAd)
    {
        Seans = seans;
        KoltukNo = koltukNo;
        MusteriAd = musteriAd;
    }
}