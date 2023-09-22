using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CFBCursos.Aula50
{

    delegate int Operacao(int primeiroParametro, int segundoParametro);

    class Mat
    {
        public static int Soma(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }
 
        public static int Multiplica(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }
    }
    class Delegates
    {
        public static void Executar()
        {

            int res;

            Operacao primeiroDelegate = new Operacao(Mat.Soma);
            res = primeiroDelegate(10, 50);
            Console.WriteLine(res);

        }

    }
}
