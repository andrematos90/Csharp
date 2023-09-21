using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula47
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
    }
    class SobrecargaDeMetodos
    {
        public static void Executar()
        {
            Calculadora conta = new Calculadora();
            
            int res = conta.Soma(1, 2);
            Console.WriteLine(res);

            double res2 = conta.Soma(2.1, 3.4);
            Console.WriteLine(res2);

        }
    }
}
