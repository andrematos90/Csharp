using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Interpolação_de_Strings
    {
        public static void Executar()
        {
            string carro = "Fusca";
            int ano = 1985;

            Console.WriteLine("Tenho um " + carro + " ano " + ano); // concatenado

            Console.WriteLine("Tenho um {0} ano {1}", carro, ano); // interpolado

            Console.WriteLine($"Tenho um {carro} ano {ano}"); // interpolado

            Console.WriteLine($"1 + 1 = { 1 + 1}"); // interpolado
        }
    }
}



/*
 * A interpolação em C# é um recurso que permite criar strings formatadas de maneira mais legível e conveniente, incorporando expressões e variáveis diretamente no texto da string. Isso torna a construção de strings formatadas mais fácil e mais compreensível em comparação com outras abordagens, como a concatenação de strings ou o uso de formatadores de string tradicionais.

A interpolação de strings em C# é feita colocando-se um símbolo de cifrão ($) antes de uma string delimitada por aspas duplas (") e, em seguida, incorporando expressões ou variáveis entre chaves {} dentro da string. As expressões e variáveis são avaliadas e seus valores são inseridos na string resultante.

Aqui está um exemplo de interpolação de strings em C#:

string nome = "João";
int idade = 30;

string mensagem = $"Olá, meu nome é {nome} e eu tenho {idade} anos.";

Console.WriteLine(mensagem);

Nesse exemplo, a variável mensagem é construída usando interpolação de strings. As expressões {nome} e {idade} são substituídas pelos valores das variáveis correspondentes, resultando em uma saída como:

Olá, meu nome é João e eu tenho 30 anos.


A interpolação de strings torna o código mais legível, pois você pode incorporar diretamente as variáveis no texto da string, evitando a necessidade de concatenar várias partes de strings manualmente.

Além disso, a interpolação de strings suporta formatação avançada, permitindo que você especifique formatos para os valores inseridos. Por exemplo:

double valor = 123.456;

string mensagem = $"O valor é: {valor:C2}";

Console.WriteLine(mensagem);


Nesse exemplo, {valor:C2} formata o valor da variável valor como uma moeda com duas casas decimais.

Em resumo, a interpolação de strings em C# é uma maneira eficaz e legível de criar strings formatadas que incorporam valores de variáveis e expressões de forma direta.*/