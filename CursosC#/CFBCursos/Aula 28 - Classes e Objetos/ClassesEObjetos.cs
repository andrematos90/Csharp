using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula28
{

    class Jogardor
    {
        public int energia = 100;
        public bool vivo = true;
    }

   class ClassesEObjetos
    {
        public static void Executar()
        {
            //instanciando criando objetos do tipo "Jogador"
            Jogardor player1 = new Jogardor();
            Jogardor player2 = new Jogardor();
            Jogardor player3 = new Jogardor();


            Console.WriteLine(player1.energia); // acessando atribudo do objeto
            Console.WriteLine(player2.energia = 80); //alterando atributo do objeto
            Console.WriteLine(player3.vivo);

        }
    }
}
