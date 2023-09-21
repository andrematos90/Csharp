using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula48
{
    public class Calculadora
    {
        public int Soma(int x, int y)
        {
            return x + y;
        }

        public double Soma(double x, double y)
        {
            return x + y;
        }

        public int Fat(int numero)
        {
            int res;
            if (numero <= 1)
            {
                res = 1;
            }
            else
            {
               res = numero * Fat(numero - 1);
            }
            return res;
        }
    }
    class Recursividade
    {
        public static void Executar()
        {
            Calculadora contadeFAtorial = new Calculadora();

            int res = contadeFAtorial.Fat(5);
            Console.WriteLine(res);


        }
    }
}
