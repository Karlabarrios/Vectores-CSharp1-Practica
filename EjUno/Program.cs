using System;

namespace EjUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nros = new int [10];

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa un nro :p");
                nros[x] = int.Parse(Console.ReadLine());
            }

            int maxnro = nros[0];
            int pos = 1;

            for(int x = 0; x < 10; x++)
            {
                if(nros[x] > maxnro)
                {
                    maxnro = nros[x];
                    pos = x + 1;
                }
            }

            Console.WriteLine("El número mayor es: " + maxnro + " y su posición es: " + pos);
        }
    }
}
