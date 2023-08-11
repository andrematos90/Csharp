using System;
using System.Globalization;  // Importa a classe System.Globalization para usar recursos relacionados à formatação de cultura.

namespace CoderBR.Fundamentos
{
    class Lendo_Dados_no_Console
    {
        public static void Executar()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu salário?");
            // A cultura CultureInfo.InvariantCulture é usada para garantir que a conversão de string para float seja feita de acordo com uma formatação numérica consistente, independentemente das configurações de cultura do sistema.
            float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos.");
            Console.WriteLine($"Seu salário é R${salario}");

        }
    }
}

/*A leitura de dados do console em C# é uma operação fundamental que permite que um programa em C# interaja com o usuário, recebendo entradas digitadas pelo usuário e processando essas informações. A leitura de dados do console é comumente usada para criar programas interativos, como aplicativos de linha de comando e interfaces de texto simples.

Para realizar a leitura de dados do console em C#, você pode usar a classe Console. Aqui está um exemplo simples de como fazer isso:

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: "); // Mostra uma mensagem para o usuário
        string nome = Console.ReadLine();   // Lê a linha de entrada do usuário e armazena em 'nome'

        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine()); // Lê a linha de entrada e converte para um valor inteiro

        Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
    }
}


Neste exemplo, Console.Write é usado para exibir mensagens para o usuário, e Console.ReadLine é usado para ler a entrada do usuário como uma string. Se você quiser ler números inteiros, como no caso da idade, você pode usar Convert.ToInt32 para converter a entrada em um valor inteiro.

Lembre-se de que a leitura de dados do console é baseada em texto e os dados lidos são tratados como strings até que sejam convertidos para outros tipos de dados, se necessário. Certifique-se de lidar com exceções ao fazer conversões, pois os usuários podem inserir valores inválidos que podem resultar em erros durante a execução.

Além disso, tenha em mente que a leitura de dados do console é uma operação síncrona, o que significa que o programa ficará esperando até que o usuário forneça a entrada. Isso pode bloquear a execução do programa até que os dados sejam fornecidos.
*/