// See https://aka.ms/new-console-template for more information
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Yavuz";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Id = 6543;
            musteri1.DogumYili = 1968;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Sevda";
            musteri2.Soyadi = "Ünal";
            musteri2.Id = 6544;
            musteri2.DogumYili = 1977;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.DogumYili);
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            


        }

    }
}
