    using Microsoft.Win32.SafeHandles;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace proje38
    {
        public class musteri
        {
            int _id;
            string _isim;
            string _soyisim;
            public string isim { get { return _isim; } set { _isim = value; } }

            public string soyisim { get { return _soyisim; } set { _soyisim = value; } }

            public int id { get { return _id; } set { _id = value; } }

            public int kayitduzenle(musteri m)
            {
                Console.WriteLine("kayit düzenle çalıştı");
                return 1;
            }

            public int kayitsil(musteri m)
            {
                Console.WriteLine("kayit sil çalıştı: {0}");
                return 1;
            }

            public int yenikayit(musteri m)
            {
                Console.WriteLine("Yeni Kayit Çalıştı");
                return 1;
            
            }
       
        }
    }
