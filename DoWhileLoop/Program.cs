using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //do{
            //    Console.WriteLine(i);
            //    i++;

            //}while (i <= 10) ;
            //Console.WriteLine();

            //i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            Console.WriteLine("Baslangic degeri girin : ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitis degeri girin : ");
            int bitis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tek:t,Cift:c,tum:*");
            string islem = Console.ReadLine();
            int toplam = 0;
            int i = baslangic;
            do
            {
                if (islem == "*")
                {
                    toplam += i;
                }
                else if (islem == "t" && i % 2 != 0)
                {
                    toplam += i;
                }
                else if (islem == "c" && i % 2 == 0)
                {
                    toplam += i;
                }
                i++;

            } while (i <= bitis);
            Console.WriteLine(islem == "*" ? "Tüm sayilar" : islem == "t" ? "tek sayilar" : "cift sayilar ");
            Console.WriteLine("Toplam : " + toplam);

            


            Console.Read();
        }
    }
}
