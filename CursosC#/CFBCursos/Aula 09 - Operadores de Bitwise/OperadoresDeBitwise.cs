using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula09
{
    class OperadoresDeBitwise
    {
        public static void Executar()
        {
            int num = 10;

            num = num << 1; //desloca o binario uma casa para a esquerda dobrando o valor da variável
            Console.WriteLine(num);

            num = num << 2; //desloca o binario duas casa para a esquerda dobrando duas vezes o valor da variável
            Console.WriteLine(num);

            int num2 = 10;

            num2 = num2 >> 1;
            Console.WriteLine(num2); //desloca o binario uma casa para a direita dividindo o valor da variável pela metade
        }
    }
}
