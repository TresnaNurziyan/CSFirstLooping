using System;

namespace FirstLooping
{
    class Looping
    {
        static void Main(String[] args)
        {
            for (int a = 0, b = 5; ((a < 5) && (b > 0)); b--, a++)
            {
                Console.WriteLine("{0} {1} {2}\t", a, (a > b ? '>' : '<'), b);
                //Console.WriteLine(b == 0 ? "Perbandingan selesai" : "Perbandingan selanjutnya");

                if(a == 4)
                {
                    b--;
                    Console.WriteLine("Perbandingan Selesai");
                }
                else
                {
                    Console.WriteLine("Perbandingan selanjutnya");
                }
            }
            Console.ReadKey();
        }
    }
}
