using System;

namespace EjTres
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] frase = new char [20];
            char a = 'a', i = 'i';
            int con = 0;
            Console.WriteLine("Ingresa una frase letra por letra, deten con punto");
            frase[con] = char.Parse(Console.ReadLine());

            while(frase[con] != '.' && con < 19)
            {
                con++;
                Console.WriteLine("Ingresa siguiente letra, deten con punto");
                frase[con] = char.Parse(Console.ReadLine());
            }
            frase[con] = '\0';

            con = 0;
            while(frase[con] != '\0')
            {
                if(frase[con] == a)
                {
                    frase[con] = i;
                }
                con++;
            }

            con = 0;
            while(frase[con] != '\0')
            {
                Console.Write(frase[con]);
                con++;
            }
            
        }
    }
}
