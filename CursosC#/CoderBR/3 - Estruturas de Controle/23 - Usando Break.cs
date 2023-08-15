using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random numeroAleatorio = new Random();
            int numero = numeroAleatorio.Next(1, 51);

            Console.WriteLine("O umero aleatório é: {0}", numero);

            for( int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"Número Encontrado {i}");
                if( i == numero)
                {
                    Console.WriteLine("Sim");
                    break; // o break não sai do if, mas sim do laço for o que faz com que o laço seja interrompido
                }
                else
                {
                    Console.WriteLine("Não");

                }
            }
        }
    }
}

/*
 
A palavra-chave break em C# é usada para sair imediatamente de um loop (como for, while, do-while), ou de um bloco switch. Quando o programa encontra a instrução break, ele interrompe a execução do loop ou do bloco switch e continua a partir do ponto imediatamente após o loop ou o bloco switch.

O uso do break é útil para interromper uma iteração de loop ou sair de um bloco switch mais cedo, mesmo que a condição ou o caso ainda seja verdadeiro. Isso permite um maior controle sobre o fluxo do programa.

Aqui estão exemplos de uso do break em diferentes contextos:

Usando o break para sair de um loop:

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break; // Sai do loop quando i é igual a 5
    }
    Console.WriteLine(i);
}
Neste exemplo, o loop for é interrompido quando i é igual a 5. Portanto, a saída será "0 1 2 3 4".




Usando o break em um bloco switch:

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
    default:
        Console.WriteLine("Dia inválido");
        break;
}

Neste exemplo, quando diaDaSemana é igual a 3, o programa imprimirá "Terça-feira" e sairá do bloco switch devido ao break.




Usando o break para sair de um loop do-while:

int contador = 1;

do
{
    if (contador == 3)
    {
        break; // Sai do loop quando contador é igual a 3
    }
    Console.WriteLine("Contador: " + contador);
    contador++;
} while (contador <= 5);


Neste exemplo, o loop do-while é interrompido quando o contador é igual a 3. Portanto, apenas duas iterações serão executadas e a saída será "Contador: 1 Contador: 2".

Lembre-se de que o uso excessivo de break pode tornar seu código menos legível e mais difícil de entender. É recomendável usá-lo com moderação e considerar estruturas alternativas, como ajustar as condições do loop, para criar fluxos de controle mais claros.*/


