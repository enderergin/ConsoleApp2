using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
        etiket:;
            int bakiye = 1000;
            Console.WriteLine("Atm'ye hos geldiniz");
            Console.WriteLine("yapmak istediğiniz işlemi seçin");
            Console.WriteLine("Bakiye için 1 yazın");
            Console.WriteLine("Para çekmek için 2 yazın");
            Console.WriteLine("Para yatırmak için 3 yazın");
            
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Bakiyeniz: " + (bakiye));
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                if (sayi1 < bakiye)
                {
                    Console.WriteLine("kalan bakiye: " + (bakiye - sayi1));
                    Console.ReadLine();
                }


                else
                {
                    Console.WriteLine("Fazla miktar çekemezsin");
                }
            }
            else if (secim == "3")
            {

                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Toplam tutar: " + (bakiye + sayi2));
            }
            else {
                Console.WriteLine("Yanlış işlem girdniz");
            
            }
            Console.ReadKey();
            goto etiket;


        }
    }
}

