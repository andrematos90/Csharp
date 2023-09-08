using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula32
{
    class OperadorThis
    {
        class Calculadora
        {
            int valor1;
            int valor2;

            public Calculadora(int valor1, int valor2)
            {
                this.valor1 = valor1;
                this.valor2 = valor2;
            }

            public int Somar()
            {
                return valor1 + valor2;
            }

        }
        public static void Executar()
        {
            Calculadora soma = new Calculadora(1, 2);

           Console.WriteLine(soma.Somar());

        }
    }
}
