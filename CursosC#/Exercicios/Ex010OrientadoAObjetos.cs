using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex010OrientadoAObjetos
    {
        private int[,] matrix;

        public Ex010OrientadoAObjetos(int rows, int columns)
        {
            matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        public void LargestElement(out int largest, out int row, out int column)
        {
            largest = matrix[0, 0];
            row = 0;
            column = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > largest)
                    {
                        largest = matrix[i, j];
                        row = i;
                        column = j;
                    }
                }
            }
        }

        public double Average()
        {
            int sum = Sum();
            return (double)sum / (matrix.GetLength(0) * matrix.GetLength(1));
        }

        public bool SearchValue(int value, out int row, out int column)
        {
            row = -1;
            column = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == value)
                    {
                        row = i;
                        column = j;
                        return true;
                    }
                }
            }
            return false;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.Write("Type the number of rows: ");
            int inputRows = int.Parse(Console.ReadLine());

            Console.Write("Type the number of columns: ");
            int inputColumns = int.Parse(Console.ReadLine());

            Ex010OrientadoAObjetos matrix = new Ex010OrientadoAObjetos(inputRows, inputColumns);

            char option = '0';

            while (option != '6')
            {
                Console.WriteLine("What do you wish to do? Please enter the option number: ");
                Console.WriteLine("1 - Show Matrix");
                Console.WriteLine("2 - Sum Matrix");
                Console.WriteLine("3 - Largest Element of Matrix");
                Console.WriteLine("4 - Average of Matrix");
                Console.WriteLine("5 - Search a number in Matrix");
                Console.WriteLine("6 - To close the program");

                option = char.Parse(Console.ReadLine());

                switch (option)
                {
                    case '1':
                        matrix.ShowMatrix();
                        break;

                    case '2':
                        int sum = matrix.Sum();
                        Console.WriteLine($"Sum: {sum}");
                        break;

                    case '3':
                        matrix.LargestElement(out int largest, out int row, out int column);
                        Console.WriteLine($"Largest Element: {largest} at Row: {row}, Column: {column}");
                        break;

                    case '4':
                        double average = matrix.Average();
                        Console.WriteLine($"Average: {average}");
                        break;

                    case '5':
                        Console.Write("Enter the number you want to search for: ");
                        int searchValue = int.Parse(Console.ReadLine());
                        if (matrix.SearchValue(searchValue, out int searchRow, out int searchColumn))
                        {
                            Console.WriteLine($"Number {searchValue} found at Row: {searchRow}, Column: {searchColumn}");
                        }
                        else
                        {
                            Console.WriteLine($"Number {searchValue} not found in the matrix");
                        }
                        break;

                    case '6':
                        Console.WriteLine("Closing the program");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }
    }
}
