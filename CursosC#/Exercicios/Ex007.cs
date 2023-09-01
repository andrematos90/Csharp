/*Você está desenvolvendo uma calculadora especial que permite ao usuário realizar operações avançadas. Crie um programa em C# que realiza o seguinte:

Solicite ao usuário que insira o primeiro número (double).
Solicite ao usuário que escolha uma operação a ser realizada: "adição", "subtração", "multiplicação", "divisão" ou "potência".
Solicite ao usuário que insira o segundo número (double).
Agora, aqui vem o desafio: utilize uma instrução switch para realizar a operação escolhida e exibir o resultado. Para a potência, você pode usar o operador Math.Pow para calcular a potência de um número.

O programa deve lidar com erros caso o usuário insira uma operação inválida ou tente realizar uma divisão por zero.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex007
    {
        public static void Executar()
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            string opChoise = null;

            Console.Write("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation\n" +
                "*addition:\n" +
                "*subtraction:\n" +
                "*multiplication:\n" +
                "*division:\n" +
                "*exponentiation:\n");

            opChoise = Console.ReadLine();

            Console.Write("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());

            switch (opChoise) 
            {
                case "addition":
                    result = num1 + num2;
                    break;
                case "subtraction":
                    result = num1 - num2;
                    break;
                case "multiplication":
                    result = num1 * num2;
                    break;
                case "division":
                    result = num1 / num2;
                    break;
                case "exponentiation":
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("invalid operation!");
                    break;
            }

            Console.WriteLine($"Result: {result}");

        }
    }
           
}
