using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoderBR.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Jubileu";
            fulano.Idade = 20;

            //Console.WriteLine($"{fulano.Nome} tem {fulano.Idade} anos");

            fulano.ApresentarNoConsole();



            var siclano = new Pessoa();
            siclano.Nome = "Juca";
            siclano.Idade = 30;

            var ApresentarSiclano = siclano.Apresentar();
            Console.WriteLine(ApresentarSiclano);

        }
    }
}
