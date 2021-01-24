using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class MusteriManager
    {
        //İş Sınıfları
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " ID li müşteri eklendi.");
        }

        public void listele(Musteri musteri)
        {
            if (musteri is GercekMusteri)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("ID:            " + ((GercekMusteri)musteri).Id);
                Console.WriteLine("Musteri No:    " + ((GercekMusteri)musteri).MusteriNo);
                Console.WriteLine("Musteri Adi:   " + ((GercekMusteri)musteri).Adi);
                Console.WriteLine("Musteri Soyadi:" + ((GercekMusteri)musteri).Soyadi);
                Console.WriteLine("TC No:         " + ((GercekMusteri)musteri).TcNo);
                Console.WriteLine("**************************");
            }
            else if (musteri is TuzelMusteri)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("ID:            " + ((TuzelMusteri)musteri).Id);
                Console.WriteLine("Musteri No:    " + ((TuzelMusteri)musteri).MusteriNo);
                Console.WriteLine("Sirket Adi:    " + ((TuzelMusteri)musteri).SirketAdi);
                Console.WriteLine("Vergi No:      " + ((TuzelMusteri)musteri).VergiNo);
                Console.WriteLine("**************************");

            }
        }
    }
}
