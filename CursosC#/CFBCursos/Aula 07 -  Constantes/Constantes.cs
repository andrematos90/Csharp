using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula07
{
    class Constantes
    {
        public static void Executar()
        {
            Console.WriteLine("Em C#, constantes são valores imutáveis que não podem ser alterados durante a execução do programa. Elas são usadas para representar valores fixos que não devem ser modificados ao longo do tempo, como valores matemáticos, códigos de status ou outras informações que devem permanecer constantes durante toda a vida útil do programa.\r\n\r\nAqui estão alguns pontos-chave sobre constantes em C#:\r\n\r\nDeclaração de Constantes: As constantes em C# são declaradas usando a palavra-chave const, seguida pelo tipo de dado e o nome da constante. O valor da constante deve ser atribuído na declaração e não pode ser alterado posteriormente./\n\n\n" +
                "const int MinutosPorHora = 60;\r\nconst double Pi = 3.14159;\r\nconst string Saudacao = \"Olá, mundo!\";\r\n" +
                "Escopo: As constantes são visíveis apenas dentro do escopo em que são definidas. Elas podem ser usadas em métodos, classes ou até mesmo em namespaces.\r\n\r\nTipos de Dados: As constantes podem ser declaradas usando diferentes tipos de dados, como inteiros, números de ponto flutuante, caracteres, strings, entre outros.\r\n\r\nAvaliação em Tempo de Compilação: O valor de uma constante é avaliado em tempo de compilação e substituído diretamente pelo seu valor literal no código gerado pelo compilador. Isso pode resultar em melhor desempenho, já que não há necessidade de busca ou manipulação em tempo de execução.\r\n\r\nRestrições: Uma constante deve ser inicializada na sua declaração e não pode ser modificada em nenhum ponto durante a execução do programa. Elas não podem ser usadas para valores que só são determinados em tempo de execução.\r\n\r\nVantagens: O uso de constantes melhora a legibilidade do código, pois torna claro quais valores são constantes e não podem ser alterados. Além disso, o compilador verifica que o valor da constante não é modificado inadvertidamente.\r\n\r\nAqui está um exemplo de uso de constantes em C#:\n\n\n" +
                "using System;\r\n\r\nnamespace ExemploConstantes\r\n{\r\n    class Program\r\n    {\r\n        const double TaxaDeJuros = 0.05;\r\n\r\n        static void Main(string[] args)\r\n        {\r\n            double valorInicial = 1000;\r\n            double valorFinal = valorInicial * (1 + TaxaDeJuros);\r\n\r\n            Console.WriteLine($\"Valor final após um ano: {valorFinal:C}\");\r\n        }\r\n    }\r\n}\r\n" +
                "Neste exemplo, a constante TaxaDeJuros é usada para calcular o valor final após um ano, e seu valor é fixo durante toda a execução do programa.");
        }
    }
}
