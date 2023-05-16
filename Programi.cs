
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri x = new musteri();
            x.id = 1;
            x.isim = "ender";
            x.soyisim = "ergin";
            int sonuc = x.yenikayit(x);
            if ( sonuc >0 )
            {
                Console.WriteLine("yeni kayıt başarılı");
            }
        }
    }
}
