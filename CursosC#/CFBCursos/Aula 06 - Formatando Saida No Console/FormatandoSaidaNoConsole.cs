using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CFBCursos.Aula06
{
    class FormatandoSaidaNoConsole
    {
        public static void Executar()
        {
            string nome = "André";
            string sobrenome = "Matos";
            int Idade = 33;

            //concatenação
            Console.WriteLine("Meu nome é " + nome + ", meu sobrenome é " + sobrenome + " e tenho " + Idade + " anos de idade.");

            // metodo string format
            // com  marcadores de posição(indices)
            Console.WriteLine("Meu nome é {0}, meu sobrenome é {1} e tenho {2} anos de idade.", nome, sobrenome, Idade);

            // método mais moderno interpolação de strings 
            Console.WriteLine($"Meu nome é {nome}, meu sobrenome é {sobrenome} e tenho {Idade} anos de idade. ");

            //StringBuilder
            StringBuilder builder = new StringBuilder();
            builder.Append("Meu nome é ").Append(nome).Append(", meu sobrenome é ").Append(sobrenome).Append(" e tenho ").Append(Idade).Append(" anos de idade.");
            string formattedString = builder.ToString();
            Console.WriteLine(formattedString);

            //Caracteres de Escape

            //  \n quebra linha
            Console.WriteLine($"Meu nome é {nome},\nmeu sobrenome é {sobrenome}\ne tenho {Idade} anos de idade. ");

            //  \t da uma tabulação (afasta)
            Console.WriteLine($"Meu nome é {nome},\tmeu sobrenome é {sobrenome}\te tenho {Idade} anos de idade. ");

            /*
             * \ -Barra Invertida:
            Para inserir uma barra invertida literal em uma string, você precisa usar \\. */

            string caminho = "C:\\Diretorio\\Arquivo.txt";
            Console.WriteLine(caminho);


            /*
             " - Aspas Duplas: O caractere \" insere uma aspa dupla literal em uma string delimitada por aspas duplas.*/

            string aspas = "Isso é uma \"string\" com aspas.";
            Console.WriteLine(aspas);


            /*
             ' - Aspas Simples:
              O caractere \' insere uma aspa simples literal em uma string delimitada por aspas simples.*/

            string aspaSimples = "Isso é uma \'string\' com aspas simples.";
            Console.WriteLine(aspaSimples);

            /*
             \r - Retorno de Carro:
             O caractere \r é usado para representar um retorno de carro.*/

            string retornoCarro = "Texto antigo\rNovo texto.";
            Console.WriteLine(retornoCarro);

            /*
             \b - Retrocesso (Backspace): O caractere \b representa um retrocesso, movendo o cursor um espaço para trás. */

            string retrocesso = "Retro\bcesso";
            Console.WriteLine(retrocesso);

            /*
             \u - Unicode: O prefixo \u é usado para representar caracteres Unicode por meio de seus valores hexadecimais.*/

            char unicodeChar = '\u03A9'; // Representa o caractere grego maiúsculo Ômega (Ω)
            Console.WriteLine(unicodeChar);



            double ValorCompra = 5.50;
            double ValorVenda;
            double lucro = 0.1;
            string produto = "Pão";

            ValorVenda = ValorCompra + (ValorCompra * lucro);

            Console.WriteLine("Produto..........:{0,15}", produto);
            Console.WriteLine("Val.Compra.......:{0,15:c}",ValorCompra);
            Console.WriteLine("Lucro............:{0,15:p}",lucro);
            Console.WriteLine("Val. Venda.......:{0,15:c}",ValorVenda);

            //15 indica que o campo de saída deve ter pelo menos 15 caracteres de largura.
            // :c Formata números como valores monetários, usando a moeda regional padrão.
            //:pFormata um número como uma porcentagem, multiplicando o valor por 100 e adicionando um sinal de porcentagem.








        }
    }
    

}
