using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula37
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da Classe Base");
        }
    }

    class Derivada1:Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da Classe Derivada1");
        }

    }

    class Derivada2:Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da Classe Derivada2");
        }
    }
    class OrdemExecuçãoConstrutores
    {
        public static void Executar()
        {
            Derivada2 teste = new Derivada2();
            Console.WriteLine(teste);

        }
    }
}
/*
 Se um objeto for instanciado da classe Derivda2, os construtores das classe Derivada2, Derivada1 e Base serao executados na sequerncia Base > Derivada 1 > Derivada 2
*/
