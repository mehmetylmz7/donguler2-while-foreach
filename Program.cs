using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler2_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den baslayarak console a girilen sayıya kadar ortalama hesaplayan uygulama

            Console.Write("lutfen bır sayı gırınız");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // a dan z ye kadar tum harfleri console a yazdır

            char character = 'a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }

            // foreach kısa kullanımı

            string[] arabalar = { "BMW", "toyota", "ford", "audi" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }




            Console.ReadLine();
        }
    }
}
