/*Você está trabalhando em um sistema de finanças pessoais em C#. O usuário pode inserir despesas mensais em diferentes categorias (aluguel, alimentação, transporte, etc.). Crie um programa que realiza o seguinte:

Declare uma variável saldo como double e inicialize-a com um valor inicial de 1000.0 (representando o saldo inicial da conta).

Solicite ao usuário que insira o valor de uma despesa mensal em uma determinada categoria (por exemplo, aluguel). O usuário pode inserir o valor como uma string.

Converta a entrada do usuário para um valor double usando a função double.TryParse para garantir que a entrada seja válida. Se a conversão for bem-sucedida, subtraia o valor da despesa do saldo.

Se a conversão não for bem-sucedida (por exemplo, o usuário inseriu texto em vez de um número), informe ao usuário que a entrada é inválida e continue pedindo um valor válido.

Repita os passos 2 a 4 até que o usuário escolha parar (por exemplo, inserindo "parar" como entrada).

No final, exiba o saldo restante na conta do usuário.

Isso ajudará a praticar a conversão de tipos em C#, tratando valores de entrada do usuário e mantendo o controle do saldo de uma conta financeira. */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex006
    {
        public static void Executar()
        {
            double balance = 1000.0;
            double rent = 0;
            double food = 0;
            double transport = 0;
            string input = "";




            while (input != "stop")
            {

                Console.Write("rent amount: ");
                rent = double.Parse(Console.ReadLine());
               
                if(rent.GetType() != typeof(double))
                {
                    Console.WriteLine("Invalid input, enter only numbers.");
                }
                else
                {
                    balance -= rent;
                }

                Console.Write("Continue or Stop?");
                input = Console.ReadLine().ToLower();

                if( input == "stop")
                {
                    break;
                }
                

                Console.Write(" food: ");
                food = double.Parse(Console.ReadLine());

                if (food.GetType() != typeof(double))
                {
                    Console.WriteLine("Invalid input, enter only numbers.");
                }
                else
                {
                    balance -= food;
                }

                Console.Write("Continue or Stop?");
                input = Console.ReadLine().ToLower();

                if (input == "stop")
                {
                    break;
                }

                Console.Write("transport: ");
                transport = double.Parse(Console.ReadLine());

                if (transport.GetType() != typeof(double))
                {
                    Console.WriteLine("Invalid input, enter only numbers.");
                }
                else
                {
                    balance -= transport;
                }

                Console.Write("Continue or Stop?");
                input = Console.ReadLine().ToLower();

                if (input == "stop")
                {
                    break;
                }

            }

            Console.WriteLine($"Final balance: ${balance}");
            

        }
    }
}

/*
 

Código refatorado


using System;

class Program
{
    public static void Executar()
    {
        double balance = 1000.0;
        string input;

        while (true)
        {
            Console.Write("Digite o valor da despesa (ou 'stop' para encerrar): ");
            input = Console.ReadLine().ToLower();

            if (input == "stop")
            {
                break;
            }

            if (double.TryParse(input, out double expense))
            {
                balance -= expense;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Insira apenas números.");
            }
        }

        Console.WriteLine($"Saldo final: ${balance:F2}");
    }
}





double.TryParse(input, out double expense) é uma chamada ao método TryParse da classe double. O método TryParse é usado para tentar converter uma string em um número de ponto flutuante (double). Ele retorna true se a conversão for bem-sucedida e armazena o resultado na variável expense. Caso contrário, retorna false.

input é a string que você coletou como entrada do usuário. Esta é a string que você deseja converter em um número de ponto flutuante.

out double expense é uma declaração de variável de saída. Isso significa que, se a conversão for bem-sucedida, o valor resultante será armazenado na variável expense.

Portanto, a linha if (double.TryParse(input, out double expense)) verifica se a conversão da string input em um número de ponto flutuante é bem-sucedida. Se for bem-sucedida, isso significa que o usuário inseriu um número válido e a variável expense contém esse valor. Se a conversão falhar, o bloco if não será executado, e você pode tratar a entrada como inválida.

Esta é uma maneira segura de converter entrada do usuário em um número, evitando exceções (erros) no caso de entrada inválida, como letras ou caracteres especiais. O valor convertido é então subtraído do saldo, conforme o seu código original.


*/
