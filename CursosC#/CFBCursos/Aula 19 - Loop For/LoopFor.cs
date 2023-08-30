using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula19
{
    class LoopFor
    {
        public static void Executar()
        {
            // Criação e inicialização de uma matriz 3x5 chamada 'numeros'
            int[,] numeros = new int[3, 5];

            // Preenchimento da matriz com valores específicos
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;
            numeros[0, 3] = 50;
            numeros[0, 4] = 60;

            numeros[1, 0] = 70;
            numeros[1, 1] = 80;
            numeros[1, 2] = 90;
            numeros[1, 3] = 100;
            numeros[1, 4] = 110;

            numeros[2, 0] = 120;
            numeros[2, 1] = 130;
            numeros[2, 2] = 140;
            numeros[2, 3] = 150;
            numeros[2, 4] = 160;

            // Loop que percorre a primeira dimensão da matriz
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                // Loop que percorre a segunda dimensão da matriz
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    // Impressão do valor contido na posição [i, j] da matriz
                    Console.WriteLine(numeros[i, j]);
                }
            }
        }
    }
}

/*A expressão numeros.GetLength(0) é usada para obter o comprimento (número de elementos) da primeira dimensão da matriz numeros.

No caso do código fornecido, a matriz numeros foi declarada como int[,] numeros = new int[3, 5];, o que significa que ela possui 3 linhas e 5 colunas. A primeira dimensão se refere às linhas e a segunda dimensão se refere às colunas.

Portanto, quando usamos numeros.GetLength(0), estamos obtendo o valor 3, que é o número de linhas da matriz. Isso é usado no loop for externo para controlar quantas vezes o loop será executado, percorrendo cada uma das linhas da matriz.*/

