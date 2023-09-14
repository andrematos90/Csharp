using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula38
{

    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da classe Base");
        }

        public virtual void Info()
        {
            Console.WriteLine("BASE");
        }
    }

    class Derivada1:Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe Derivada1");
        }

        override public void Info()
        {
            Console.WriteLine("DERIVADA1");
            base.Info();
        }


    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe Derivada2");
        }
    }

    class MétodosVirtuais
    {
        public static void Executar()
        {
            Derivada2 teste = new Derivada2();
            teste.Info();
            

        }
    }
}
