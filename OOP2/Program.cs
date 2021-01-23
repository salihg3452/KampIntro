using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Melek";
            //musteri1.Soyadi = "Budak";
            //musteri1.Id = 1;
            //musteri1.TcNo = "10037946258";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            //Salih Gül
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Melek";
            musteri1.Soyadi = "Budak";
            musteri1.TcNo = "12345678910";

            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "11122233344";

            //Gerçek müşreti - tüzel müşteri
            //solid

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
        
        
        }
    }
}
