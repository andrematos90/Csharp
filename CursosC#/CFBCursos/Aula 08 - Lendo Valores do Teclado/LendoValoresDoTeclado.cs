using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula08
{
    class LendoValoresDoTeclado
    {
        public static void Executar() {
            int v1, v2, soma;

            Console.Write("Digite o primeiro valor: ");
          v1 = int.Parse(Console.ReadLine());
            Console.Write("Digiteo segundo valor: ");
           v2 = Convert.ToInt32(Console.ReadLine());
            soma = v1 + v2;
            Console.Write($"Soma de {v1} + {v2} = {soma}");


        }
    }
}
