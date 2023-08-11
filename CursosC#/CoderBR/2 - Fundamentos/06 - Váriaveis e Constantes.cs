using System;

namespace CoderBR.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine("AREA:" + area);

            bool estaChovendo = true; // true ou false
            Console.WriteLine(estaChovendo);

            byte menorValorByte = byte.MinValue; // byte não aceita números negativos
            byte maiorValorByte = byte.MaxValue;
            Console.WriteLine("Menor valor de Byte: " + menorValorByte);
            Console.WriteLine("Maior valor de Byte: " + maiorValorByte);

            sbyte menorValorSbyte = sbyte.MinValue; // sbyte aceita números negativos
            sbyte maiorValorSbyte = sbyte.MaxValue;
            Console.WriteLine("Menor valor de Sbyte: " + menorValorSbyte);
            Console.WriteLine("Maior valor de Sbyte: " + maiorValorSbyte);

            short menorValorShort = short.MinValue;
            short maiorValorShort = short.MaxValue;
            Console.WriteLine("Menor valor de Short: " + menorValorShort);
            Console.WriteLine("Maior valor de Short: " + maiorValorShort);

            int menorValorInt = int.MinValue;
            int maiorValorInt = int.MaxValue;
            Console.WriteLine("Menor valor de Int: " + menorValorInt);
            Console.WriteLine("Maior valor de Int: " + maiorValorInt);

            uint menorValorUInt = uint.MinValue; // uint não aceita números negativos
            uint maiorValorUInt = uint.MaxValue;
            Console.WriteLine("Menor valor de UInt: " + menorValorUInt);
            Console.WriteLine("Maior valor de UInt: " + maiorValorUInt);

            long menorValorLong = long.MinValue;
            long maiorValorLong = long.MaxValue;
            Console.WriteLine("Menor valor de Long: " + menorValorLong);
            Console.WriteLine("Maior valor de Long: " + maiorValorLong);

            ulong menorValorULong = ulong.MinValue;
            ulong maiorValorULong = ulong.MaxValue;
            Console.WriteLine("Menor valor de ULong: " + menorValorULong);
            Console.WriteLine("Maior valor de ULong: " + maiorValorULong);

            float menorValorFloat = float.MinValue;
            float maiorValorFloat = float.MaxValue;
            Console.WriteLine("Menor valor de Float: " + menorValorFloat);
            Console.WriteLine("Maior valor de Float: " + maiorValorFloat);

            decimal menorValorDecimal = decimal.MinValue;
            decimal maiorValorDecimal = decimal.MaxValue;
            Console.WriteLine("Menor valor de Decimal: " + menorValorDecimal);
            Console.WriteLine("Maior valor de Decimal: " + maiorValorDecimal);

            char letra = 'a';
            Console.WriteLine("Letra: " + letra);

            string texto = "Olá, mundo!";
            Console.WriteLine(texto);
        }
    }
}


/*

Em C#, variáveis e constantes são elementos fundamentais para armazenar e manipular dados em um programa. Eles são usados para armazenar informações que podem ser usadas e modificadas durante a execução do programa. Vamos explorar as diferenças entre variáveis e constantes:

Variáveis:
Uma variável é um local de armazenamento nomeado que pode conter um valor de um determinado tipo de dado. As variáveis podem ser alteradas (ou seja, seus valores podem ser atribuídos e modificados) durante a execução do programa. Aqui estão os principais pontos sobre variáveis em C#:

Declaração: As variáveis são declaradas usando uma sintaxe que especifica o tipo de dado e um nome único para a variável. Por exemplo:

           int idade; // Declaração de uma variável do tipo int chamada "idade"


Atribuição: Uma vez declarada, uma variável pode receber um valor usando o operador de atribuição =. Por exemplo:

          idade = 25; // Atribui o valor 25 à variável "idade"



Inicialização: É possível declarar e atribuir um valor à variável ao mesmo tempo:


        double altura = 1.75; // Declara e atribui o valor 1.75 à variável "altura"


Manipulação: Os valores armazenados em variáveis podem ser modificados ao longo do tempo por meio de operações aritméticas, atribuições e outras manipulações.



Constantes:

Uma constante é um valor que é definido apenas uma vez e não pode ser alterado durante a execução do programa. Elas são úteis para representar valores fixos, como constantes matemáticas, valores que nunca mudam ou configurações importantes. Aqui estão os principais pontos sobre constantes em C#:

Declaração e Inicialização: As constantes são declaradas usando a palavra-chave const, seguida pelo tipo de dado e o nome da constante. Elas devem ser inicializadas no momento da declaração:


const double PI = 3.14159; // Declaração e inicialização de uma constante do tipo double


Uso: As constantes podem ser usadas em expressões e operações como qualquer outra variável. Elas são substituídas pelo seu valor literal durante a compilação.

Imutabilidade: Uma vez definida, uma constante não pode ser alterada em nenhum ponto do programa.

Comparação:
A principal diferença entre variáveis e constantes é que as variáveis podem ter seus valores alterados durante a execução do programa, enquanto as constantes têm um valor fixo que não pode ser alterado. Portanto, você escolhe usar variáveis quando precisa armazenar dados que podem mudar, e constantes quando precisa de um valor fixo e imutável.

Exemplo de uso de variável:


int contador = 0;
contador = contador + 1; // contador agora é 1


Exemplo de uso de constante:


const double taxaDeJuros = 0.05;
double saldoFinal = saldoInicial * (1 + taxaDeJuros);


Em resumo, variáveis e constantes são elementos cruciais na programação para armazenar e manipular dados. A escolha entre usar uma variável ou uma constante depende das necessidades específicas do seu programa e da natureza dos dados que você está lidando.

*/


