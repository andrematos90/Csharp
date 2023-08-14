using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Operador_Ternario
    {
        public static void Executar()
        {
            var nota = 7.0;
            string resultado = nota >= 7 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
