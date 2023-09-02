/*Imagine que você está desenvolvendo um programa simples em C# para calcular o fatorial de um número inteiro não negativo. No entanto, você deseja explorar o uso da instrução "go to" para criar uma solução alternativa.

Seu objetivo é criar um programa que solicite ao usuário um número inteiro não negativo e, em seguida, calcule seu fatorial usando a instrução "go to" para controlar o fluxo do programa.

Aqui estão os requisitos do exercício:

Solicite ao usuário um número inteiro não negativo.

Verifique se o número é maior ou igual a zero. Se não for, exiba uma mensagem de erro e solicite novamente um número válido.

Calcule o fatorial do número usando uma estrutura de repetição que inclua o uso da instrução "go to". Certifique-se de que o programa funcione corretamente para números pequenos, como 0, 1 e 5.

Exiba o resultado do fatorial calculado.

Pergunte ao usuário se ele deseja calcular o fatorial de outro número e repita o processo, se necessário.

Lembre-se de utilizar a instrução "go to" com responsabilidade e de forma apropriada para controlar o fluxo do programa. Evite criar código confuso ou difícil de entender.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex008
    {
        public static void Executar()
        {

        beginning:
            Console.Clear();
            int number = 0;
            int factorial = 1;
            string userInput = "";

            Console.Write("Insert a number greater than 0: ");
            number = int.Parse(Console.ReadLine());


            if (number > 0)
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

            else
            {
                Console.Write("ERROR! The number should be greater than 0: ");
                number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
            }
            Console.WriteLine(factorial);
            Console.WriteLine("Do you wish to continue?[y/n] ");
            userInput = Console.ReadLine();
            if (userInput == "y")
            {
                goto beginning;
            }

        }
    }
}

