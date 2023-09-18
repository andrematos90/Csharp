using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula45
{
    struct Carro
    {
        public string marca;
        public string modelo;

        public void info()
        {
           
            Console.WriteLine($"{this.marca}, {this.modelo}");
            Console.WriteLine("----------------");
        }
       
    }


    class ArraysDeEstruturas
    {
        public static void Executar()
        {
           
            Carro[] carros = new Carro[5];

            carros[0].marca = "Volkswagen";
            carros[0].modelo = "Gol";

            carros[1].marca = "Honda";
            carros[1].modelo = "Civic";

            carros[2].marca = "Chevrolet";
            carros[2].modelo = "Malibu";

            carros[3].marca = "Renault";
            carros[3].modelo = "Twingo";

            carros[4].marca = "Volkswagen";
            carros[4].modelo = "Fusca";

            for(int i = 0; i < carros.Length; i++)
            {
                carros[i].info();
            }

        }
    }
}

