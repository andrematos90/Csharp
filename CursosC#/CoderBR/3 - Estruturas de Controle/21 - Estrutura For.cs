using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);

            for(int i = 0; i < tamanhoDaTurma; i++)
            {
                Console.WriteLine("Nota do Aluno: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine($"Média da Turma {media}");
        }
    }
}

/*A estrutura de controle for em C# é utilizada para criar loops que permitem que você execute um bloco de código repetidamente por um número específico de vezes. É especialmente útil quando você sabe exatamente quantas iterações o loop deve ter. A sintaxe básica da estrutura for em C# é a seguinte:
 

for (inicialização; condição; incremento/decremento)
{
    // Código a ser repetido
}


Aqui está uma explicação detalhada da estrutura for em C#:

A palavra-chave for é seguida por um par de parênteses (). Dentro desses parênteses, você especifica três partes separadas por ponto-e-vírgula ;:

Inicialização: Uma expressão que é executada uma vez no início do loop, geralmente usada para iniciar variáveis de controle.
Condição: Uma expressão que é avaliada antes de cada iteração do loop. Se a condição for verdadeira, o loop continuará; caso contrário, o loop será interrompido.
Incremento/Decremento: Uma expressão que é executada após cada iteração do loop. Geralmente usada para modificar a variável de controle.
O bloco de código dentro das chaves {} é executado repetidamente enquanto a condição especificada no cabeçalho do for for verdadeira.

Após cada iteração, a expressão de incremento/decremento é avaliada, a condição é verificada novamente e o ciclo continua até que a condição seja falsa.

Aqui está um exemplo simples de uso da estrutura for em C#:

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Iteração número: " + i);
}


Neste exemplo, o programa imprimirá a mensagem "Iteração número: " seguida do número da iteração de 1 a 5. O loop for é usado para controlar o número de iterações, e a variável i é incrementada a cada iteração.

A estrutura for é uma maneira eficiente de criar loops quando você sabe quantas vezes o bloco de código deve ser repetido. É especialmente útil quando você precisa iterar sobre uma sequência ou realizar alguma operação com base em um contador controlado.*/
