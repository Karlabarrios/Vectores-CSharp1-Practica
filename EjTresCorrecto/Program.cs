using System;

namespace EjTresCorrecto
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] frase = new char [30];
            char letraActual;
            char letraNueva;
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese una frase letra por letra (para detener pulse cero)");
            letra = char.Parse(Console.ReadLine());
            while(letra != '0' && indice < 29)
            {
                //indice++;
                frase[indice] = letra;
                Console.WriteLine("Ingrese otra letra para la frase: ");
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            frase[indice] = '\0';

            Console.WriteLine("La frase completa es: ");
            indice = 0;
            while(frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Ingrese letra a reemplazar: ");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese letra nueva: ");
            letraNueva = char.Parse(Console.ReadLine());

            indice= 0;
            while(frase[indice] != '\0')
            {
                if(frase[indice] == letraActual)
                    frase[indice] = letraNueva;
                    
                indice++;
            }

            Console.WriteLine("La frase nueva es: ");
            indice = 0;
            while(frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
        }
    }
}
