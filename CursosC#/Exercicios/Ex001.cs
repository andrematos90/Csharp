
/*
 Título: Calculadora de Média

Descrição:
Você foi designado para criar uma calculadora de média simples em C#. A calculadora deve permitir que o usuário insira três números inteiros e então calcular e exibir a média dos três números.

Instruções:

Crie um programa C# que solicite ao usuário que insira três números inteiros separados por espaços.
Converta os números inseridos em valores inteiros e armazene-os em variáveis apropriadas.
Calcule a média dos três números.
Exiba a média calculada na tela com uma mensagem clara, arredondada para duas casas decimais.
Dicas:

Utilize o método Console.ReadLine() para obter a entrada do usuário.
Use a função int.Parse() ou Convert.ToInt32() para converter as strings de entrada em valores inteiros.
Para calcular a média, some os três números e divida o resultado por 3.
Use o método Console.WriteLine() para exibir o resultado ao usuário.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios
{
     class Ex001
    {
        public static void Executar()
        {

            Console.Write("Digite o primeiro valor: ");
           int v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o primeiro valor: ");
            int v2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o primeiro valor: ");
            int v3 = Convert.ToInt32(Console.ReadLine());

            int media = (v1 + v2 + v3) / 3;

            Console.WriteLine($"média: {media}");

        }
    }
}
