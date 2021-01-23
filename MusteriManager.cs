using System;
using System.Collections.Generic;
using System.Text;

namespace Classmetotdemoo
{
    class MusteriManager
    {
        
            public void Kayit(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" "+ musteri.Soyadi+ " " + "isimli kişi kaydolmuştur.");
        }
            public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listelendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli kişinin kaydı silinmiştir .");
        }
    
    }
}
