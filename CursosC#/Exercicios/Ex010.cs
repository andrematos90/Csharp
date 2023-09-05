/*Você foi designado para escrever um programa em C# que lida com matrizes. Siga as instruções abaixo para criar o programa:

Crie uma matriz bidimensional (ou matriz 2D) de números inteiros. A dimensão da matriz deve ser especificada pelo usuário.

Preencha a matriz com valores inteiros aleatórios. Você pode usar a classe Random para gerar números aleatórios.

Implemente uma função que exiba a matriz na tela de forma legível, formatando-a em linhas e colunas.

Desenvolva uma função que calcule a soma de todos os elementos da matriz e exiba o resultado.

Crie uma função que encontre o maior valor na matriz e exiba-o, junto com sua posição (linha e coluna).

Escreva uma função que calcule a média dos valores na matriz e exiba o resultado.

Implemente uma função que permita ao usuário procurar um valor específico na matriz e informar se ele existe ou não na matriz, juntamente com sua posição (linha e coluna) se for encontrado.

Crie um menu interativo que permita ao usuário escolher entre as diferentes operações disponíveis, como exibir a matriz, calcular a soma, encontrar o maior valor, calcular a média e procurar um valor específico.*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex010
    {
        public static void Executar()
        {

           
            int sum =0;

            Console.Write("Type the number of lines:");
            int inputLine = int.Parse(Console.ReadLine());

            Console.Write("Type the number of columns: ");
            int inputColumn = int.Parse(Console.ReadLine());

            int[,] matrix = new int[inputLine, inputColumn];


            Random random = new Random();

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                    sum += matrix[i, j];
                }

            }


         
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine($"Sum: {sum}");

        }
    }

   
}
