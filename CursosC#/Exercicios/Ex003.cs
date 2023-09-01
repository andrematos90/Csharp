/*Você precisa escrever um programa em C# que realize a seguinte tarefa:

Declare uma matriz de inteiros chamada matriz com 3 linhas e 3 colunas.

Preencha a matriz com valores inteiros aleatórios entre 1 e 100.

Crie uma função chamada CalculaSomaLinha que aceita dois argumentos: a matriz e o número da linha a ser somada (1, 2 ou 3).

Dentro da função CalculaSomaLinha, calcule a soma dos elementos da linha especificada e retorne o resultado.

Fora da função, peça ao usuário que escolha uma linha (1, 2 ou 3) e chame a função CalculaSomaLinha com a matriz e o número da linha escolhida.

Exiba a soma da linha escolhida na tela.

Complete o código implementando a função CalculaSomaLinha e preenchendo a matriz com valores aleatórios. Este exercício deve desafiar suas habilidades de manipulação de matrizes e escopo de variáveis em C#.

O objetivo deste exercício é praticar o uso de matrizes e funções com escopo de variáveis em C#. Aqui está um esqueleto do código para começar:
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex003
    {
        public static void Executar()

        {

            int[,] matriz = new int[3, 3] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90, } };

 
            // Preencha a matriz com valores aleatórios entre 1 e 100

            Console.Write("Escolha uma linha (1, 2 ou 3): ");
            int linhaEscolhida = int.Parse(Console.ReadLine());

            int soma = CalculaSomaLinha(matriz, linhaEscolhida);

            Console.WriteLine($"A soma da linha {linhaEscolhida} é: {soma}");
        }

        static int CalculaSomaLinha(int[,] matriz, int linha)
        {
            // Implemente a função para calcular a soma da linha especificada
            // e retorne o resultado

            if(linha == 1)
            {
                return matriz[0, 0] + matriz[0, 1] + matriz[0, 2];
            }
            if (linha == 2)
            {
                return matriz[1, 0] + matriz[1, 1] + matriz[1, 2];
            }
            if (linha == 3)
            {
                return matriz[2, 0] + matriz[2, 1] + matriz[2, 2];
            }
            else
            {
                throw new InvalidOperationException("Algo deu errado"); // Lança uma exceção em caso de outra condição.
            }
        }
    }
}
