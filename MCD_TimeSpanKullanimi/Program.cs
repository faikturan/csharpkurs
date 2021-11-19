using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MCD_TimeSpanKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan : ZamanAralığı DateTime tipindeki değişkenlerin matematiksel işlemlerinde kullanılıyor.
            TimeSpan zamanAraligi = new TimeSpan();
            Console.WriteLine("Doğum Tarihi giriniz: dd.MM.yyyy");

            DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime dogumTarihi);

            zamanAraligi = DateTime.Now - dogumTarihi;
            Console.WriteLine("Kaç gündür yaşıyormuş? = " +(int)zamanAraligi.TotalDays);
            Console.WriteLine($"Kaç yaşındaymış? = {(int)(zamanAraligi.TotalDays /365)} ");
            Console.WriteLine("Kaç saattir yaşıyormuş? {0}", (int)zamanAraligi.TotalHours);

            Console.ReadKey();

        }
    }
}
