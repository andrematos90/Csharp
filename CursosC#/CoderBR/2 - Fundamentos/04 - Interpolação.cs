using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Interpolação_de_Strings
    {
        public static void Executar()
        {
            string carro = "Fusca";
            int ano = 1985;

            Console.WriteLine("Tenho um " + carro + "ano " + ano); // concatenado

            Console.WriteLine("Tenho um {0} ano {1}", carro, ano); // interpolado

            Console.WriteLine($"Tenho um {carro} ano {ano}"); // interpolado
        }
    }
}
