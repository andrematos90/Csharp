using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula18
{
    class ArraysMatrizes
    {
        public static void Executar()
        {
            int[,] numeros = new int[3, 5];

            numeros[0, 0] = 10;
            numeros[0, 2] = 20;
            numeros[0, 3] = 30;
            numeros[0, 4] = 50;
            numeros[0, 5] = 60;

            numeros[1, 0] = 70;
            numeros[1, 2] = 80;
            numeros[1, 3] = 90;
            numeros[1, 4] = 100;
            numeros[1, 5] = 110;

            numeros[2, 0] = 120;
            numeros[2, 2] = 130;
            numeros[2, 3] = 140;
            numeros[2, 4] = 150;
            numeros[2, 5] = 160;

            Console.WriteLine(numeros);
        }
    }
    
}
