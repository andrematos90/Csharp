using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;

            Console.WriteLine("Números pares até {0}", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine($"{i}");
            }
        }
    }
}

/*
 * A palavra-chave continue em C# é usada para pular o restante do código dentro de uma iteração atual de um loop (for, while, do-while) e passar imediatamente para a próxima iteração. Isso significa que, quando o programa encontra a instrução continue, ele não executará o código abaixo dela na iteração atual, mas passará para a próxima iteração do loop.

O uso do continue é útil quando você deseja evitar a execução de parte do código em uma iteração específica, mas ainda deseja continuar o loop para as próximas iterações.

Aqui está um exemplo de uso do continue em um loop:

for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue; // Pula a iteração quando i é igual a 3
    }
    Console.WriteLine("Iteração: " + i);
}


Neste exemplo, quando i é igual a 3, a instrução continue é acionada, pulando a iteração atual. Como resultado, o programa imprimirá "Iteração: 1" e "Iteração: 2", mas não imprimirá "Iteração: 3". Depois disso, continuará a imprimir as iterações restantes.

É importante notar que o uso excessivo do continue pode tornar o código menos legível e mais difícil de entender. Antes de usar o continue, certifique-se de que ele melhora a clareza do seu código. Em algumas situações, ajustar as condições do loop ou reorganizar o código pode ser uma alternativa mais clara e compreensível.

*/