using System;

namespace EjDos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nros = new int [10];
            int acu = 0, prom;

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa un número:");
                nros[x] = int.Parse(Console.ReadLine());
                acu += nros[x];
            }
            
            prom = acu / 10;
            
            for(int x = 0; x < 10; x++)
            {
                if(nros[x] > prom)
                {
                    Console.Write("Este nro supera el promedio: ");                    
                    Console.WriteLine(nros[x]);
                }
                    
            }

            Console.WriteLine("Fin del programa");
        }
    }
}
