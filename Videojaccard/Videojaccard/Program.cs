using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojaccard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. kelimeyi giriniz");
            string kelime1 = Console.ReadLine();
            Console.WriteLine("2. kelimeyi giriniz");
            string kelime2 = Console.ReadLine();

            float kesisim = 0;
            float birlesim = 0;

            for(int x = 0; x < kelime1.Length; x++)
            {
                for(int i = 0; i < kelime2.Length; i++)
                {
                    if (kelime1[x] == kelime2[i])
                    {
                        kesisim++;
                    }
                }
            }

            birlesim = (kelime1.Length + kelime2.Length) - kesisim;

            float sonuc = kesisim / birlesim;// jaccard index

            Console.WriteLine(1-sonuc);//jaccard mesafesi
            Console.ReadKey();

        }
    }
}
