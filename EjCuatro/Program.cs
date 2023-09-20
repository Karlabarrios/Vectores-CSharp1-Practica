using System;

namespace EjCuatro
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ArtTipos = new int [15];
            int CantVend;
            int indiceArt;

            /* Me había faltado agregar este for para que el acumulador de cada tipo de articulo del nro 1 al 15 
            se inicialice en 0, igual funciona sino lo hao, pero es importante siempre inicializar contadores y
            acumuladores. */

            for(int x = 0; x < 15; x++)
            {
                ArtTipos[x] = 0;
            }

            Console.WriteLine("Nueva venta.");
            Console.WriteLine("Por favor indica el número de artículo que vendiste");
            indiceArt = int.Parse(Console.ReadLine());

            while(indiceArt != 0 && indiceArt < 16)
            {
                Console.WriteLine("Por favor indica la cantidad vendida del artículo");
                CantVend = int.Parse(Console.ReadLine());
                ArtTipos[indiceArt -1] += CantVend;

                Console.WriteLine("Nueva venta.");
                Console.WriteLine("Por favor indica el número de artículo que vendiste");
                indiceArt = int.Parse(Console.ReadLine());
            }

            //Punto a
            int ArtMax = ArtTipos[0];
            int PosMax = 1;
            for(int x = 0; x < 15; x++)
            {
                if(ArtTipos[x] >= ArtMax)
                {
                    ArtMax = ArtTipos[x];
                    PosMax = x + 1;
                }

            }
            Console.WriteLine("El número de artículo que más se vendío en total fue: " + PosMax);

            //Punto b
            for(int x = 0; x < 15; x++)
            {
                
                if(ArtTipos[x] == 0)
                    Console.WriteLine("El artículo " + (x + 1) + " no vendío nada.");

            }
            //Punto c
            Console.WriteLine("Las unidades vendidas del articulo 10 fueron: " + ArtTipos[9]);
            
        }
    }
}
