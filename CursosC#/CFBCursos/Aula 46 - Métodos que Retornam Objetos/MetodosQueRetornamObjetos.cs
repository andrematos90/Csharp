using CFBCursos.Aula33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula46
{
    public class Galinha
    {
        private string nome;
        private int numeroDeOVos;

        public Galinha(string nomeGalinha)
        {
            nome = nomeGalinha;
            numeroDeOVos = 0;
        }

        public Ovo botaOvo()
        {
            numeroDeOVos++;
            return new Ovo(numeroDeOVos, nome); 
        }
    }

    public class Ovo
    {
        private int QtDeOVos;
        private string minhaGalinha;
        public Ovo(int QtDeOVos, string minhaGalinha)
        {
            this.QtDeOVos = QtDeOVos;
            this.minhaGalinha = minhaGalinha;
            Console.WriteLine($"Nome da galinha: {this.minhaGalinha}");
            Console.WriteLine($"Ovos criado: {this.QtDeOVos}");
        }
    }
    class MetodosQueRetornamObjetos
    {
        public static void Executar()
        {
            Galinha galinha1 = new("Galinhosa");
            Galinha galinha2 = new("Penosa");
            Galinha galinha3 = new("Bicuda");

            galinha1.botaOvo();
            galinha1.botaOvo();
            galinha1.botaOvo();
            Console.WriteLine();
            galinha2.botaOvo();
            Console.WriteLine();
            galinha3.botaOvo();
            galinha3.botaOvo();
            galinha3.botaOvo();

        }
    }
}
