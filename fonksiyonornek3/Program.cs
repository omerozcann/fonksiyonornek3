using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyonornek3
{
    internal class Program
    {
        static double donustur(double f)
        {
            double c;
            c =(Convert.ToDouble(5) / Convert.ToDouble(9))*(f - 32);
            //c = ((Double)(5) / (Double)(9)) * (f - 32); //bir üst satır ile aynı
            return c;
        }
        static void Main(string[] args)
        {
            /*
             Örnek: Kendisine gönderilen fahrenhayt (F) değerini 
            derece (C) ye çevirip geri döndüren fonksiyonu yazınız
             */
            double fh,s;
            Console.WriteLine("Fahrenhayt gir:");
            fh=double.Parse(Console.ReadLine());
            s=donustur(fh);
            Console.WriteLine("Sonuc={0}", s);
        }
    }
}
