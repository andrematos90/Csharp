using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula12
{
    class CondicionalIf
    {
        public static void Executar()
        {
            float n1, n2, n3, n4;
            n1 = n2 = n3 = n4 = 0;

            Console.Write("Digite o valor da primera nota: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da segunda nota: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da terceira nota: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da quarta nota: ");
            n4 = int.Parse(Console.ReadLine());

            float media = (n1 + n1 + n3 + n4) / 4;

           if( media >= 7)
            {
                Console.WriteLine("média {0}: Aprovado!", media);
            }
            else
            {
                Console.WriteLine("media {0}: Reprovado!", media);
            }


        }
    }
}
