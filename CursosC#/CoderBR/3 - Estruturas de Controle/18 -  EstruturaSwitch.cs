using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle
{
    class EstruturaSWitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie o atendimento com nota de  0 à 5: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Lixo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;

                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Execelente");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }

            Console.WriteLine("Obrigado por avaliar nosso atendimento");
        }
    }
}

/*
 * A estrutura switch em C# é uma forma de controle de fluxo que permite que você avalie uma expressão e execute diferentes blocos de código com base nos diferentes valores possíveis dessa expressão. Ela é especialmente útil quando você tem múltiplas condições para verificar e executar diferentes ações com base no valor de uma única expressão. Aqui está a sintaxe básica da estrutura switch em C#:
 * 
 * switch (expressao)
{
    case valor1:
        // Código a ser executado se expressao for igual a valor1
        break;
    case valor2:
        // Código a ser executado se expressao for igual a valor2
        break;
    // ...
    default:
        // Código a ser executado se nenhum dos casos anteriores for correspondido
        break;
}

Aqui está uma explicação detalhada da estrutura switch em C#:

A palavra-chave switch é seguida por um par de parênteses (), dentro dos quais você coloca a expressão que deseja avaliar.

Dentro do bloco de switch, você define diferentes casos usando a palavra-chave case, seguida pelo valor que você quer comparar com a expressão. Cada caso é seguido por um dois-pontos :.

Dentro de cada caso, você pode colocar o código que será executado se o valor da expressão corresponder ao valor especificado no caso. Lembre-se de usar a instrução break no final de cada caso para sair do bloco switch após a execução do caso correspondente.

O bloco switch também pode incluir um bloco default, que é opcional. O bloco default é executado quando nenhum dos casos correspondentes é encontrado. Também é boa prática incluir uma instrução break após o bloco default.

Aqui está um exemplo simples de uso da estrutura switch em C#:


int diaDaSemana = 3;

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    // ...
    default:
        Console.WriteLine("Dia inválido");
        break;
}

Neste exemplo, o programa avalia o valor da variável diaDaSemana e imprime o nome correspondente do dia da semana. Se o valor não corresponder a nenhum dos casos, ele imprimirá "Dia inválido".

A estrutura switch é uma maneira eficiente e legível de lidar com múltiplas opções de decisão com base no valor de uma única expressão.*/
