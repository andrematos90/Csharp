using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula17
{
    class Arrays
    {
        public static void Executar()
        {
            //declarando 
            int[] numeros = new int[5];

            //atribuindo valores

            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;


            //outra forma de atribuir int[] numero = new int[5]{1, 2, 3, 4, 5} declarando e ja atribuindo com a quantidade especidicada de elementos
            //outra forma de atribuir int[] numero = {1, 2, 3, 4, 5} declarando e ja atribuindo

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
