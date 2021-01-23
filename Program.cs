using System;

namespace Classmetotdemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "mustafa";
            musteri1.Soyadi = "yasar";
            musteri1.Yasi = 23;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "beril";
            musteri2.Soyadi = "kaya";
            musteri2.Yasi = 35;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "yusuf";
            musteri3.Soyadi = "can";
            musteri3.Yasi = 46;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine("........................");

            }

            MusteriManager musteriManager = new MusteriManager();
           
            musteriManager.Kayit(musteri1);
            musteriManager.Kayit(musteri2);
            musteriManager.Kayit(musteri3);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Listele(musteri1);
       
        }
        }
    }
