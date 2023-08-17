using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle
{
    class DoWhile
    {
        public static void Executar()
        {
            string entrada;


            do
            {
                Console.WriteLine("Digite seu nome: ");
                entrada = Console.ReadLine();
                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.Write("Deseja Continuar? (S/N)");
                entrada = Console.ReadLine();


            } while (entrada.ToLower() == "s");

        }
    }
}

/*
A estrutura de controle do-while em C# é semelhante à estrutura while, mas com uma diferença fundamental: o bloco de código é executado pelo menos uma vez, independentemente da condição. Após a primeira execução, a condição é verificada, e se for verdadeira, o bloco de código é repetido. A sintaxe básica da estrutura do-while em C# é a seguinte:

do
{
    // Código a ser repetido
} while (condição);


Aqui está uma explicação detalhada da estrutura do-while em C#:

A palavra-chave do é seguida por um par de chaves {} que contêm o bloco de código a ser executado.

Após o bloco de código, há a palavra-chave while, seguida por um par de parênteses (), dentro dos quais você especifica a condição a ser verificada após cada execução do bloco.

O ponto-e-vírgula ; após a condição é necessário para finalizar a instrução do-while.

O bloco de código é executado pelo menos uma vez, mesmo que a condição seja inicialmente falsa. Após a primeira execução, a condição é verificada. Se a condição for verdadeira, o bloco de código é repetido; caso contrário, o loop é encerrado e o programa continua a partir do próximo ponto após o bloco do-while.

Aqui está um exemplo simples de uso da estrutura do-while em C#:

int contador = 1;

do
{
    Console.WriteLine("Contagem: " + contador);
    contador++;
} while (contador <= 5);


Neste exemplo, o programa imprimirá a contagem de 1 a 5 usando um loop do-while. O bloco de código dentro do do será executado pelo menos uma vez, porque a condição de verificação está no final.

A estrutura do-while é útil quando você deseja garantir que um bloco de código seja executado pelo menos uma vez antes de verificar uma condição. */