using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula20
{
    class LoopWhile
    {
        public static void Executar()
        {
            int i = 0;
            int[] numeros = new int[10];

            while(i < numeros.Length)
            {
                Console.WriteLine("Oi Mundo!");
                numeros[i] = i;
                Console.WriteLine(numeros[i]);
                i++;
            }
            Console.WriteLine("Fim do Loop!");
        }
    }
}
