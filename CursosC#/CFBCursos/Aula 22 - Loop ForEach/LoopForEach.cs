using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula22
{
    class LoopForEach
    {
        public static void Executar()
        {
            int[] numeros = new int[5] {10, 20, 30, 40, 50};

            Console.WriteLine("impressão com loop for: ");

            for (int i = 0; i< numeros.Length; i++)
            {
                
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("impressão com loop foreach: ");
            foreach (int numero in numeros)
            {
                
                Console.WriteLine(numero);
            }
        }
    }
}
