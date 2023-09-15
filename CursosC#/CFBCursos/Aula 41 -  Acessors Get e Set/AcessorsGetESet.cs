using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula41
{
    class Veiculo
    {
        private int velMax;

        public Veiculo()
        {
            velMax = 150;
        }

        public int velocidade
        {
            get
            {
                return velMax;
            }

            set
            {
                if(value > 150) 
                {
                    velMax = 150;
                }
                else if (value < 0)
                {
                    velMax = 0;
                }
                else
                {
                    velMax = value;
                }
            }
        }
    }

   

    class AcessorsGetESet
    {
        public static void Executar()
        {
            Veiculo carro = new Veiculo();
            carro.velocidade = 10; // usando o acessor set
            Console.WriteLine(carro.velocidade); // usando o acessor get
           
        }
    }
}
