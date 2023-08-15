using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantantes = 5;
            int tentativas = 0;

            while(tentativasRestantantes > 0  && !numeroEncontrado)
            {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantantes--;

                if(numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var conAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Acertou!!! {tentativas} tentativas");

                }else if( numeroSecreto > palpite)
                {
                    Console.WriteLine("Número secreto é maior + {0} tentativas", tentativasRestantantes);
                }else if(numeroSecreto < palpite)
                {
                    Console.WriteLine($"Número Secreto é menor + {tentativasRestantantes} tentativas ");
                }
            }
        }
    }
}

/*
 A estrutura de controle while em C# é usada para criar loops que executam um bloco de código repetidamente enquanto uma determinada condição é verdadeira. Ela permite que você execute um bloco de código várias vezes, desde que a condição especificada seja avaliada como verdadeira. A sintaxe básica da estrutura while em C# é a seguinte:

while (condição)
{
    // Código a ser repetido enquanto a condição for verdadeira
}


Aqui está uma explicação detalhada da estrutura while em C#:

A palavra-chave while é seguida por um par de parênteses (), dentro dos quais você deve especificar a condição que será avaliada a cada iteração do loop.

Enquanto a condição for verdadeira, o bloco de código dentro das chaves {} será executado repetidamente. Após a execução do bloco, a condição será verificada novamente antes de cada iteração subsequente.

Se a condição for falsa no início, o bloco de código dentro do while não será executado e o programa continuará a partir do próximo ponto após o while.

É importante garantir que a condição dentro do while possa eventualmente se tornar falsa. Caso contrário, o loop continuará indefinidamente, resultando em um "loop infinito".

Aqui está um exemplo simples de uso da estrutura while em C#:

int contador = 1;

while (contador <= 5)
{
    Console.WriteLine("Contagem: " + contador);
    contador++;
}


Neste exemplo, o programa usará um loop while para imprimir a contagem de 1 a 5. A cada iteração, o valor de contador será impresso, e depois será incrementado em 1. O loop continuará até que contador seja maior do que 5.

Lembre-se de que a estrutura while é adequada quando você não sabe exatamente quantas vezes um loop precisará ser executado, mas você sabe qual condição deve ser atendida para que ele continue a ser executado. Certifique-se de que a condição seja atualizada dentro do bloco de código para evitar loops infinitos.*/