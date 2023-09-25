using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula54
{
    class Exemplo
    {
        public static string ImprimeMsg()
        {
           return "ola mundo!";
        }

    }
  
    class NameSpaces
    {
        public static void Executar()
        {
            string msg = Exemplo.ImprimeMsg();
            Console.WriteLine(msg);

            string msg2 = Outro.NameSpace.Exemplo.ImprimeMsg();
            Console.WriteLine(msg2);
        }
    }
}

namespace Outro.NameSpace
{
    class Exemplo
    {
        public static string ImprimeMsg()
        {
            return "impressão com o método \"ImprimeMsg()\" da classe \"Exemplo\", mas de outro namespace";
        }

    }

}
