using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula13
{
    class IfAninhado
    {
        public static void Executar()
        {
            float n1, n2, n3, n4;
            n1 = n2 = n3 = n4 = 0;
            string resultado = "";

            Console.Write("Digite o valor da primera nota: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da segunda nota: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da terceira nota: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da quarta nota: ");
            n4 = int.Parse(Console.ReadLine());

            float media = (n1 + n1 + n3 + n4) / 4;

            if (media >= 7)
            {
                resultado = "Apovado";
            }
            else if( media <= 6 && media >= 4)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }

            Console.WriteLine("média {0}    situação: {1}", media, resultado);

        }
    }
}
