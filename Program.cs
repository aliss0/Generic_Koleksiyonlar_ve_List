using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar_ve_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T> Object Türündedir.
            List<int> sayilarListesi = new List<int>();

            sayilarListesi.Add(23);
            sayilarListesi.Add(10);
            sayilarListesi.Add(4);
            sayilarListesi.Add(5);
            sayilarListesi.Add(92);
            sayilarListesi.Add(34);

            List<string> renklerListesi = new List<string>();
            renklerListesi.Add("Kırmızı");
            renklerListesi.Add("Mavi");
            renklerListesi.Add("Turuncu");
            renklerListesi.Add("Sarı");
            renklerListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renklerListesi.Count);
            Console.WriteLine(sayilarListesi.Count);
            Console.WriteLine("----------------------------------");
            foreach (var sayi in sayilarListesi)
                Console.WriteLine(sayi);
            Console.WriteLine("----------------------------------");
            foreach (var renk in renklerListesi)
                Console.WriteLine(renk);
            Console.WriteLine("----------------------------------");

            sayilarListesi.ForEach(sayi => Console.WriteLine(sayi));
            Console.WriteLine("----------------------------------");
            renklerListesi.ForEach(renk => Console.WriteLine(renk));
            Console.WriteLine("----------------------------------");

            // Listeden eleman çıkarma
            //Remove ile eleman çıkarma
            sayilarListesi.Remove(4);
            renklerListesi.Remove("Yeşil");

            sayilarListesi.RemoveAt(0);
            renklerListesi.RemoveAt(1);

            sayilarListesi.ForEach(sayi => Console.WriteLine(sayi));
            Console.WriteLine("----------------------------------");
            renklerListesi.ForEach(renk => Console.WriteLine(renk));
            Console.WriteLine("----------------------------------");
            // Liste içerisinde arama
            if (sayilarListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu.");
            Console.WriteLine("----------------------------------");

            // Eleman ile index'e erişme 
            Console.WriteLine(renklerListesi.BinarySearch("Sarı"));
            Console.WriteLine("----------------------------------");

            // Diziyi listeye çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            // Liste temizleme
            hayvanlarListesi.Clear();





            Console.ReadLine();




        }
    }
    public class Kullanicilar
    {
        string isim;

        string soyisim;

        int yaş;

      
    }
}
