/*Você foi designado para escrever um programa em C# que lida com matrizes. Siga as instruções abaixo para criar o programa:

Crie uma matriz bidimensional (ou matriz 2D) de números inteiros. A dimensão da matriz deve ser especificada pelo usuário.

Preencha a matriz com valores inteiros aleatórios. Você pode usar a classe Random para gerar números aleatórios.

Implemente uma função que exiba a matriz na tela de forma legível, formatando-a em linhas e colunas.

Desenvolva uma função que calcule a soma de todos os elementos da matriz e exiba o resultado.

Crie uma função que encontre o maior valor na matriz e exiba-o, junto com sua posição (linha e coluna).

Escreva uma função que calcule a média dos valores na matriz e exiba o resultado.

Implemente uma função que permita ao usuário procurar um valor específico na matriz e informar se ele existe ou não na matriz, juntamente com sua posição (linha e coluna) se for encontrado.

Crie um menu interativo que permita ao usuário escolher entre as diferentes operações disponíveis, como exibir a matriz, calcular a soma, encontrar o maior valor, calcular a média e procurar um valor específico.*/


using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex010
    {
        public static void Executar()
        {

            Console.Write("Type the number of lines:");
            int inputLine = int.Parse(Console.ReadLine());

            Console.Write("Type the number of columns: ");
            int inputColumn = int.Parse(Console.ReadLine());

            int[,] matrix = new int[inputLine, inputColumn];


            Random random = new Random();

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                   
                }

            }

            char option = '0';

            Console.WriteLine("What do you wish to do? Please enter the option number: ");
            Console.WriteLine("1 - Show Matrix");
            Console.WriteLine("2 - Sum Matrix");
            Console.WriteLine("3 - Largest Element of Matrix");
            Console.WriteLine("4 - Average of Matrix");
            Console.WriteLine("5 - Search a number in Matrix");
            Console.WriteLine("0 - To close the program");

            option = char.Parse(Console.ReadLine());

            switch (option)
            {
                case '1':
                    ShowMatrix(matrix);
                    break;

                case '2':
                    Sum(matrix);
                    break;

                case '3':
                    LargestElement(matrix);
                    break;

                case '4':
                    Average(matrix);
                    break;

                case '5':
                    SearchValue(matrix);
                    break;
                default:
                    Console.WriteLine("Closing the program");
                    break;
            }

        }


        public static void ShowMatrix(int[,] matri)
        {
            for (int i = 0; i < matri.GetLength(0); i++)
            {
                for (int j = 0; j < matri.GetLength(1); j++)
                {
                    Console.Write(matri[i, j] + " ");
                    
                }
                Console.WriteLine();
            }

        }

        public static void Sum(int[,] matri)
        {
            int sum = 0;
            for(int i = 0; i < matri.GetLength(0); i++)
            {
                for(int j = 0; j < matri.GetLength(1); j++)
                {
                    sum += matri[i, j];

                }

            }

            Console.WriteLine($"sum: {sum}");
        }

        public static void LargestElement(int[,] matri)
        {
            int largest = 0;
            int linePosition = 0;
            int columnPosition = 0;

            for(int i = 0; i < matri.GetLength(0); i++)
            {
                for( int j = 0;j < matri.GetLength(1); j++)
                {
                    if (matri[i, j] > largest)
                    {
                        largest = matri[i, j];
                        linePosition =  + 1;
                        columnPosition = j + 1;
                    }
                }

            }

            Console.WriteLine($"largest: {largest} in Line: {linePosition}, Column: {columnPosition}");

        }

        public static void Average(int[,] matri)
        {

            int average = 0;
            int sum = 0;
            for (int i = 0; i < matri.GetLength(0); i++)
            {
                for (int j = 0; j < matri.GetLength(1); j++)
                {
                    sum += matri[i, j];

                }

            }

            average = sum / matri.Length;

            Console.WriteLine($"average: {average}");
        }

        public static void SearchValue(int[,] matri)
        {
            int userInput = 0;
            int linePosition = 0;
            int columnPosition = 0;
            bool found = false;
            Console.Write("What value would you like to search for?");
            userInput = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;i < matri.GetLength(0); i++)
            {
                for(int j = 0; j < matri.GetLength(1); j++)
                {

                    if (matri[i, j] == userInput) 
                    {
                        linePosition = i + 1;
                        columnPosition = j + 1;
                        found = true;
                        break;
                       
                    }
                }
            }
            if ( found ) 
            {
                Console.WriteLine($"Number {userInput} Found! in  line {linePosition} column {columnPosition}");
            }
            else
            {
                Console.WriteLine("Number not found!");
            }
        }
        

    }



   
}
