using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrai
{
    class Teglalap
    {
        private int a, b;
        public Teglalap(int ao, int bo)
        {
            a = ao;
            b = bo;
        }

        public int Kerulet()
        {
            return 2 * (a + b);
        }
        public int Terulet()
        {
            return a * b;
        }
    }
    class kor
    {
        private int r;
        public kor(int sugar)
        {
            if (sugar < 1)
            {
                r = 1;
            }
            else
            {
                r = sugar;
            }
            
        }
        public double KorKerulet()
        {
            return 2 * r * Math.PI;
        }
        public double KorTerulet()
        {
            return Math.Pow(r,2) * Math.PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Teglalap t = new Teglalap();
            //kor t2 = new kor(2);
            Console.WriteLine("Add meg a Téglalap 'a' és 'b' oldalát");
            Teglalap t = new Teglalap(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));

            
            //  t.a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Add meg a Téglalap 'b' oldalát");
           // t.b = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a kör sugarát");
            //t2.r = int.Parse(Console.ReadLine());*/
            kor t2 = new kor(int.Parse(Console.ReadLine()));

            Console.WriteLine("Téglalap kerülete: {0}", t.Kerulet());
            Console.WriteLine("Téglalap területe: {0}", t.Terulet());

            Console.WriteLine("Kör kerülete: {0}",t2.KorKerulet());
            Console.WriteLine("Kör területe: {0}",t2.KorTerulet());
            
            Console.ReadKey();
        }
    }
}
