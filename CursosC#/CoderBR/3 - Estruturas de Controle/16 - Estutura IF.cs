using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            bool bomComportamento;

            Console.Write("Digite a nota do aluno: ");
            var entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento?");
            entrada = Console.ReadLine();
            bomComportamento = entrada.ToLower() == "s";

            if(nota >= 9 && bomComportamento) {

                Console.WriteLine("Quadro de honrra");
            }

        }
    }
}

/*A estrutura de controle if em C# é usada para tomar decisões condicionais em um programa. Ela permite que você execute um bloco de código apenas se uma determinada condição for verdadeira. A sintaxe básica da estrutura if em C# é a seguinte:
  
  if (condição)
{
    // Código a ser executado se a condição for verdadeira
}


Aqui está uma explicação mais detalhada da estrutura de controle if em C#:

A palavra-chave if é seguida por um par de parênteses (), dentro dos quais você deve especificar uma condição. Essa condição é uma expressão que será avaliada como verdadeira ou falsa.

Se a condição for verdadeira, o bloco de código dentro das chaves {} será executado. Esse bloco de código pode conter uma ou várias instruções.

Se a condição for falsa, o bloco de código dentro das chaves não será executado e o programa continuará a partir do próximo ponto após o bloco if.

Aqui está um exemplo simples de uso da estrutura if em C#:

int idade = 20;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}


Neste exemplo, se a variável idade for maior ou igual a 18, a mensagem "Você é maior de idade." será exibida na saída. Caso contrário, se a idade for menor que 18, o bloco de código dentro do if não será executado.

Você também pode usar a estrutura else junto com o if para fornecer um bloco de código alternativo para ser executado quando a condição do if for falsa:

int idade = 15;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}


Neste exemplo, se a idade for menor que 18, o programa exibirá "Você é menor de idade.". Se for 18 ou mais, exibirá "Você é maior de idade.".

Além disso, você pode usar a estrutura else if para lidar com várias condições alternativas:

int nota = 75;

if (nota >= 90)
{
    Console.WriteLine("Nota A");
}
else if (nota >= 80)
{
    Console.WriteLine("Nota B");
}
else if (nota >= 70)
{
    Console.WriteLine("Nota C");
}
else
{
    Console.WriteLine("Nota abaixo de C");
}

Neste exemplo, dependendo da nota, o programa imprimirá a classificação correspondente (A, B, C) ou "Nota abaixo de C".

*/