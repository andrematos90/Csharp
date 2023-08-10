using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
     class Notacao_Ponto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, "World!").Replace("World", "Mundo!");
            /* o resultado da chamada "olá".ToUpper() chama Insert(3, "World!") que chama .Replace("World", "Mundo!"); resultado que por fim é salvo na variáveç "saudacao"*/

            Console.WriteLine(saudacao);

        }
    }
}
