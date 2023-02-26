using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Televizyon
    {

        public int sesseviyesi;
        public int kanal;

        public void kanaldegistir()
        {
            Console.WriteLine("1 TRT1");
            Console.WriteLine("2 Show TV");
            Console.WriteLine("3 ATV");
            Console.WriteLine("4 Kanal D");
            Console.WriteLine("5 Fox");
            Console.WriteLine("6 Star Tv");
            Console.WriteLine("7 TV8");
            Console.WriteLine("8 Teve2");


        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Televizyon t1 = new Televizyon();


            Console.WriteLine("Televizyonu açmak için 1'e basın. ");
            int televizyonacmak = Convert.ToInt32(Console.ReadLine());
            if (televizyonacmak == 1)
            {
                Console.WriteLine("Televizyon açılıyor.");
            }
            else
            {
                Console.WriteLine("Yanlış şifre. Tekrar deneyiniz.");
            }


            Console.Clear();
            
            Console.WriteLine("kanal listesi için A'ya basın");
            string kanallar = Convert.ToString(Console.ReadLine());
            if (kanallar == "A")
            {
                t1.kanaldegistir();
                Console.WriteLine("kanal seçimi yapınız: ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("TRT1");
                }
                if (secim == 2)
                {
                    Console.WriteLine("Show");
                }
                if (secim == 3)
                {
                    Console.WriteLine("ATV");
                }
                if (secim == 4)
                {
                    Console.WriteLine("Kanal D");
                }
                if (secim == 5)
                {
                    Console.WriteLine("Fox");
                }
                if (secim == 6)
                {
                    Console.WriteLine("Star Tv");
                }
                if (secim == 7)
                {
                    Console.WriteLine("Tv8");


                }
                if (secim == 8)
                {
                    Console.WriteLine("Teve2");
                }



            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama Yaptınız");
            }
            string sesduzeyi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ses düzeyiniz 2. Ses düzeyini yükseltmek için B'yi tuşlayın.");
            if (sesduzeyi == "B")
            {
                Console.WriteLine("Ses düzeyiniz fullendi. Geri düşürmek için C'ye basınız.");
            }

            string sesduzeyi2 = Convert.ToString(Console.ReadLine());
            if (sesduzeyi2 == "C")
            {
                Console.WriteLine("Ses düzeyiniz düşürüldü.");
            }

            Console.WriteLine("Televizyonu kapatmak için 0'ı tuşlayın.");
            int televizyonukapa=(Convert.ToInt32(Console.ReadLine()));  
            if (televizyonukapa==0)
            {
                Console.WriteLine("Televizyon Kapatılıyor...");
                    }
            Console.ReadKey();

        }
    }
}
