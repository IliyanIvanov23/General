using System;

namespace posledovatolni_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete kolko chisla iskate da vuvedete");
            uint element=Convert.ToUInt32(Console.ReadLine());
            int [] masiv = new int[element];
            int maxporedica=1;
            int maxporedicachislo=1;
            for (int a = 0;a<masiv.Length; a++) 
            {
                Console.WriteLine("Vuvedete " + (a + 1) + " chislo");
                masiv[a] = Convert.ToInt32(Console.ReadLine());
            }
            for (int a = 1; a < masiv.Length; a++)
            {
                int b = a - 1;
                int poredica = 1;
                while (masiv[b] == masiv[a]) {
                    poredica++;
                    if (a < masiv.Length) 
                    {
                        a++;
                        b++;
                    }
                }
                if (maxporedica<poredica) {
                    maxporedica = poredica;
                    maxporedicachislo = a-1;
                }
            }
            Console.Write("Nai goliamata poredica ot chisla e: ");
            for (int a = 0; a < maxporedica; a++) 
            {
                Console.Write(masiv[maxporedicachislo]+" ");
            }

        }
    }
}
