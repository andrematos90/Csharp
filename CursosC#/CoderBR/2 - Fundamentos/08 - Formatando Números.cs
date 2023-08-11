using System;
using System.Globalization;

namespace CoderBR.Fundamentos
{
    class Formatando_Numeros
    {
        public static void Executar()
        {
            double valor = 15.175;

            // Exibindo o valor formatado com uma casa decimal
            Console.WriteLine(valor.ToString("F1"));

            // Exibindo o valor formatado como moeda
            Console.WriteLine(valor.ToString("C"));

            // Exibindo o valor formatado como porcentagem
            Console.WriteLine(valor.ToString("P"));

            // Exibindo o valor formatado com no máximo duas casas decimais
            Console.WriteLine(valor.ToString("#.##"));

            // Criando uma cultura específica (en-US) para formatação
            CultureInfo cultura = new CultureInfo("en-US");

            // Exibindo o valor formatado como moeda usando a cultura específica com três casas decimais
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            //Formata o numero "256" com 7 zeros a esquerda
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}


/*
 * 
 * Neste código, a classe Formatando_Numeros contém um método Executar que demonstra diferentes formas de formatar um valor numérico 15.175. Aqui estão os detalhes de cada parte do código:

using System;: Isso indica que o namespace System está sendo utilizado, permitindo que você use classes e funcionalidades do sistema.

using System.Globalization;: Isso permite o uso de recursos de formatação cultural, que são importantes para formatar números e moedas de acordo com as convenções específicas de um determinado idioma ou região.

namespace CoderBR.Fundamentos: Define o namespace no qual a classe Formatando_Numeros está contida.

class Formatando_Numeros: A definição da classe que contém o método Executar.

public static void Executar(): Um método público e estático chamado Executar, que contém o código que demonstra as diferentes formatações de números.

double valor = 15.175;: Declara uma variável do tipo double chamada valor e atribui a ela o valor 15.175.

Console.WriteLine(valor.ToString("F1"));: Imprime o valor formatado com uma casa decimal usando o padrão "F1".

Console.WriteLine(valor.ToString("C"));: Imprime o valor formatado como moeda, utilizando a formatação padrão de moeda da cultura atual.

Console.WriteLine(valor.ToString("P"));: Imprime o valor formatado como porcentagem.

Console.WriteLine(valor.ToString("#.##"));: Imprime o valor formatado com no máximo duas casas decimais, usando a formatação "#.##".

CultureInfo cultura = new CultureInfo("en-US");: Cria uma nova instância de CultureInfo usando a cultura "en-US" (inglês dos Estados Unidos), que será usada para formatação.

Console.WriteLine(valor.ToString("C3", cultura));: Imprime o valor formatado como moeda, usando a cultura específica "en-US" e três casas decimais.



                                       FORMATAÇÃO DE NÚMEROS EM C#



A formatação de números em C# permite que você apresente valores numéricos de maneira específica, como moeda, porcentagem, número decimal com um certo número de casas decimais, etc. Isso é especialmente útil quando você deseja exibir os números de acordo com as convenções culturais ou preferências do usuário.

A formatação de números em C# é realizada usando o método ToString() da classe System.Object. Esse método aceita um argumento de formatação que determina como o número será exibido. O argumento de formatação é uma string que contém um padrão de formatação ou um especificador numérico que controla a maneira como o número é formatado.

Aqui estão alguns exemplos de padrões de formatação comuns:

"F": Formatação de número de ponto flutuante. Exemplo: 12345.6789.ToString("F2") resulta em "12345.68".

"C": Formatação como moeda. Exemplo: 123.45.ToString("C") (dependendo da cultura) resulta em "$123.45" ou "¥123.45".

"P": Formatação como porcentagem. Exemplo: 0.25.ToString("P") resulta em "25.00%".

"N": Formatação numérica com separadores de milhar. Exemplo: 1234567.89.ToString("N") resulta em "1,234,567.89".

"#.##": Formatação personalizada com no máximo duas casas decimais. Exemplo: 12.345.ToString("#.##") resulta em "12.35".

Além dos padrões de formatação, você também pode usar especificadores numéricos, que indicam o número de casas decimais, largura total do campo, preenchimento com zeros à esquerda, etc. Por exemplo:

"F2": Duas casas decimais após o ponto. 12.345.ToString("F2") resulta em "12.35".

"D5": Largura total de 5 dígitos, preenchido com zeros à esquerda se necessário. 7.ToString("D5") resulta em "00007".

"N3": Formatação numérica com separadores de milhar e três casas decimais. 1234567.89.ToString("N3") resulta em "1,234,567.890".

É importante observar que a formatação pode ser afetada pela cultura definida no ambiente. Por padrão, a cultura atual do sistema é usada para formatação. No entanto, você pode fornecer uma cultura específica como argumento para o método ToString() para garantir que a formatação seja consistente, independentemente da configuração do sistema.

Lembre-se de que a formatação de números não altera o valor real do número; apenas afeta como ele é exibido. Portanto, o valor numérico permanece inalterado após a formatação.













*/




