using System;

class Salon
{
    public string Ad { get; set; }
    public int KoltukSayisi { get; set; }

    public Salon(string ad, int koltukSayisi)
    {
        Ad = ad;
        KoltukSayisi = koltukSayisi;
    }
}