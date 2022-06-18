using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // İŞLEM ATAMA OPERATÖRLERİ
            int x = 2;
            int y = 3;
            int z = 5;

            x = x + 2;
                Console.WriteLine(x);
            y += 3;
            Console.WriteLine(y);
            z *= 2;
            Console.WriteLine(z);


            //MANTIKSAL OPERATÖRLER
            bool Dogru = true;
            bool Yanlis = false;

             if (Dogru && Yanlis)
                Console.WriteLine("İyi");

            if (Dogru || Yanlis)
                Console.WriteLine("Orta");

                    if (Dogru && ! Yanlis)
                Console.WriteLine("Pekiyi");

            //İLİŞKİSEL OPERATÖRLER

            int a = 4;
            int b = 5;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);

            //ARİTMETİK OPERATÖRLER

            int sayi1 = 80;
            int sayi2 = 8;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi2++;
            Console.WriteLine(sonuc1);
            





        }
    }
}
