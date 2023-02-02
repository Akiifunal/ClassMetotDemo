using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Aramıza Hoşgeldiniz sayın:" + musteri.Adi + musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + musteri.Soyadi+":" + "Sistemden Çıkarıldı");
        }
        public void Listele(params Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad Soyadı:" + musteri.Adi + " " + musteri.Soyadi + "\n" + "Id:" + musteri.Id + "\n");

            }



        }

 
    }
}