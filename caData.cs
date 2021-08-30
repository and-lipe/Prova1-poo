using System;

namespace caData
{
    class Program
    {
        static void Main(string[] args)
        {
            Data t0 = new Data();
            Data t1 = new Data(03,06,2020);
            Data t2 = new Data(27, 04, 2021);

            Console.WriteLine("\nComparando t2 com t1:\t" + t1.Compara(t2));
            

            Console.WriteLine("\nMes Extenso para t1 e t2 respectivamente: " + t1.getMesExtenso() + " " + t2.getMesExtenso());
            Console.WriteLine("\n");

            Console.WriteLine("\nt1 é bissexto?\t" + t1.isBissexto());
            
            Console.WriteLine("\nt2 é bissexto?\t" + t2.isBissexto());

            Console.WriteLine("\nColando t1\n");
            t0 = t1.clone();
            Console.WriteLine("\nt0= " + t0.getDia() + "/" + t0.getMes() + "/"+t0.getAno());
        }

    }
}
