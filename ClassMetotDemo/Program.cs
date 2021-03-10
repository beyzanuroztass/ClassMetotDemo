using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Beyzanur";
            musteri2.Soyadi = "Öztaş";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);

            }

            Console.WriteLine("--Metotlar--");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listeleme(musteriler);
        }
    }
}
