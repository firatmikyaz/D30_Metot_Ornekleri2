using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D30_Metot_Ornekleri2//Klavyeden girilen 2 sayının 4 işleme tabi tutulması
{
    class Program
    {
        static void Main(string[] args)
        {
            DEVAM:
            Console.Write("1.Sayıyı Giriniz?");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz?");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            BASADON:
            Console.Write("Seçiminizi yapınız! (Toplama:1 Çıkarma:2 Çarpma:3 Bölme:4)");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim) 
            {
                case '1':
                    dortislem toplamaislemi = new dortislem();
                    double toplama = toplamaislemi.topla(sayi1, sayi2);
                    Console.WriteLine("Toplama Sonucu:{0}", toplama);
                    break;
                case '2':
                    dortislem cikarmaislemi = new dortislem();
                    double cikarma = cikarmaislemi.cikar(sayi1, sayi2);
                    Console.WriteLine("Çıkarma Sonucu:{0}", cikarma);
                    break;
                case '3':
                    dortislem carpmaislemi = new dortislem();
                    double carpma = carpmaislemi.carp(sayi1, sayi2);
                    Console.WriteLine("Çarpma Sonucu:{0}", carpma);
                    break;
                case '4':
                    dortislem bolmeislemi = new dortislem();
                    double bolum = bolmeislemi.bol(sayi1, sayi2);
                    Console.WriteLine("Bölme işlemi:{0}", bolum);
                    break;
                default:
                    Console.Clear();
                    Console.Write("Yanlış Seçim Yaptınız!");
                    goto BASADON;
            }
            SORGULA:
            Console.Write("Yeniden işlem yapmak istermisiniz? (EVET:E, HAYIR:H)");
            char tekharf = Convert.ToChar(Console.ReadLine());
            if (tekharf=='E' || tekharf=='e')
            {
                Console.Clear();
                goto DEVAM;
            }
            else if (tekharf=='H' || tekharf=='h')
            {
                Console.Write("İyi Günler.");
            }
            else
            {
                Console.Write("Yanlış Seçim Yaptınız!");
                goto SORGULA;
            }
            Console.ReadKey();
        }
        class dortislem 
        {
            public double topla(double s1,double s2) 
            {
                return (s1 + s2);
            }
            public double cikar(double s1,double s2) 
            {
                return (s1 - s2);
            }
            public double carp(double s1,double s2) 
            {
                return (s1 * s2);
            }
            public double bol(double s1,double s2) 
            {
                return (s1 / s2);
            }
        }
    }
}
