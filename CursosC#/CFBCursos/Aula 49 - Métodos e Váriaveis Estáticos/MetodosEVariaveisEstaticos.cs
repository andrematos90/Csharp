using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula49
{
    public class Mat
    {
        public static double Pi = 3.14;

        public static int dobro(int numeroDeParametro)
        {
            return numeroDeParametro * 2;
        }
    }
   class MetodosEVariaveisEstaticos
    {
        public static void Executar()
        {
            Console.WriteLine(Mat.Pi);
            Console.WriteLine(Mat.dobro(8));

        }
    }
}
