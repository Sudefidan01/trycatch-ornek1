using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20230813_TryCatch_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek 1
            //Kullanıcının 4 işlem yapabileceği bir program hazırlayalım
            //Girilen değerleri trycatch mekanizmasıyla kontrol edelim
            Program metod= new Program();
            try
            {
                Console.WriteLine("1.Sayıyı Giriniz : ");
                int sayi1=int.Parse(Console.ReadLine());
                Console.WriteLine("2.Sayıyı Giriniz : ");
                int sayi2=int.Parse(Console.ReadLine());
                metod.SecimMenusu();
                int secim=int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Sayıların Toplamı = "+(sayi1+sayi2));
                        break;
                    case 2: Console.WriteLine("Sayıların Farkı = " + (sayi1 - sayi2));break;

                    case 3: Console.WriteLine("Sayıların Çarpımı = "+(sayi1*sayi2));break;

                    case 4: Console.WriteLine("Sayıların Bölümü = "+((double)sayi1/sayi2));break;

                    default: Console.WriteLine("Yanlış Bir İşlem Türü Seçtiniz"); break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }

        public void SecimMenusu()
        {
            Console.WriteLine("----- 4 İşlem Menü -----");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
        }

    }
}
