using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula23
{
    class MetodosDeArray
    {
        public static void Executar()
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

            Random random = new Random();
            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(50);
            }

            Console.WriteLine("Elementos do vetor1");
            foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");

            //public static BinarySearch(array, valor);
            //permite buscar um elemento em uma coleção ordenada
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            int pos=Array.BinarySearch(vetor1, procurado);
            Console.WriteLine("valor {0} está na posição {1}", procurado, pos);
            Console.WriteLine("----------------------------------------------");


            //public static void Copy(Ar_origem, Ar_destino, qtde_elementos);
            // método permite copiar elementos de um array de origem para um array de destino com um comprimento especificado
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach(int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");

            //public static void CopyTo(Ar_destino, a_partir_desta_pos );
            //Copia os elementos do array atual para outro array, começando no índice especificado no segundo array
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);

            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");

            //public int GetLongLength(dimensão);
            //permite obter o comprimento de uma dimensão específica em um array multidimensional 
            Console.WriteLine("GetLongLength");
            long qtdeElementosVetor = vetor1.GetLongLength(0);
            Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
            Console.WriteLine("----------------------------------------------");

            //public int GetLowerBound(dimensão);
            //permite obter o índice mínimo (limite inferior) de uma dimensão específica em um array multidimensional 
            Console.WriteLine("GetLoweBound");
            int MenorIndiceVetor = vetor1.GetLowerBound(0);
            int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
            Console.WriteLine("Menor Indicedo Vetor1 {0}", MenorIndiceVetor);
            Console.WriteLine("Menor Indicedo da matriz {0}", MenorIndiceMatriz_D1);
            Console.WriteLine("----------------------------------------------");

            //public int GetUpperBound(dimensão);
            //permite obter o índice máximo (limite superior) de uma dimensão específica em um array multidimensional 
            Console.WriteLine("GetUpperBound");
            int MaiorIndiceVetor = vetor1.GetUpperBound(0);
            int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
            Console.WriteLine("Maior Indice do Vetor1 {0}", MaiorIndiceVetor);
            Console.WriteLine("Maior Indice do da matriz {0}", MaiorIndiceMatriz_D1);
            Console.WriteLine("----------------------------------------------");

            //public object GetValue(long índice);
            //permite acessar o valor de um elemento específico em um array
            Console.WriteLine("GetValue");
            int valor0 = Convert.ToInt32(vetor1.GetValue(3));
            int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
            Console.WriteLine("Valor da posição 3 do vetor1 {0}", valor0);
            Console.WriteLine("Valor da posição 3 da matriz {0}", valor1);
            Console.WriteLine("----------------------------------------------");

            //public static int IndexOf(array,valor);
            //IndexOf
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1, 3);
            Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
            Console.WriteLine("----------------------------------------------");


            //public static int LastIndexOf(array,valor);
            //encontra a última ocorrência de um elemento no array
            Console.WriteLine("LastIndexOf");
            int indice2 = Array.LastIndexOf(vetor1, 3);
            Console.WriteLine("Indice do primeiro valor 3: {0}", indice2);
            Console.WriteLine("----------------------------------------------");

            //public static void Reverse(array);
            //inverte a ordem do array
            Console.WriteLine("Reverse");
            Array.Reverse(vetor1);
            foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("----------------------------------------------");
            //public void SetValue(object valor, long pos);
            // usado em C# para definir o valor de um elemento específico
            Console.WriteLine("SetValue");
            vetor2.SetValue(99, 0);
            for(int i = 0; i < vetor2.Length; i++)
            {
                vetor2.SetValue(0, i);
            }
            Console.WriteLine("Vetor 2");
            foreach(int n in vetor2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("----------------------------------------------");

            //public static void Sort(array);
            // usado para classificar os elementos de um array em ordem crescente
            Console.WriteLine("Sort");
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);

            Console.WriteLine("Vetor1");
            foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Vetor2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Vetor3");
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }
        }


    }

}
