using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula26
{
    class ArgumentoOut
    {
        public static void Executar()
        {
            int dividido = 11;
            int divide = 2;
            int restante;
            int resultado = Divisao(dividido, divide, out restante);
            Console.WriteLine($"Resultado: {resultado} \nResto: {restante}");

          
        }

        public static int Divisao(int dividendo, int divisor, out int resto)
        {
            int quociente = dividendo/ divisor;
            resto = dividendo % divisor;
            return quociente;

        }
    }
}
