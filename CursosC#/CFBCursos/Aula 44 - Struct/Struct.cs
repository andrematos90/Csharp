using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula44
{
    struct Carro
    {
        public string marca;
        public string modelo;

        public Carro(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
    }

  
   class Struct
    {
        public static void Executar() {

           /* Carro carro1;
            carro1.marca = "Volkswagen";
            carro1.modelo = "Fusca";
            Console.WriteLine($"{carro1.marca}, {carro1.modelo}");*/


            //chamando construtor
            Carro carro2 = new Carro("Renault", "Twingo");
            Console.WriteLine($"{carro2.marca}, {carro2.modelo}");
        }
    }
}
