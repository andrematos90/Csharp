using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula25
{
    class PassagemPorValorEReferencia
    {
       
        public static void Executar()
        {
            int num1 = 10;
            int num2 = 10;
            dobrar( ref num1);
            Console.WriteLine(num1);
            dobrar2(num2);
            Console.WriteLine(num2);

        }

        //passgem por valor
        public static void dobrar(ref int valor)
        {
            valor *= 2;
        }

        //passagem por referencia
        public static void dobrar2(int valor)
        {
            valor *= 2;
        }
    }
}
