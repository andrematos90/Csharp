using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula15
{
    class SwitchCase
    {
        public static void Executar()
        {
            char veiculo;
           
            Console.WriteLine("Viagem De Joinville - SC a São Paulo-SP");
            Console.WriteLine("Digite o meio de transporte para saber o tempo de viagem");
            Console.WriteLine("[A] Avião");
            Console.WriteLine("[O] Ônibus");
            Console.WriteLine("[C] Carro");
            veiculo = char.Parse(Console.ReadLine().ToUpper());

            switch (veiculo)
            {
                case 'A':
                    Console.WriteLine("Veiculo Escolhido Avião --- Tempo de viagem: 1:30h");
                    Console.WriteLine("Boa viagem!");
                    break;

                case 'O':
                    Console.WriteLine("Veiculo Escolhido Ônibus --- Tempo de viagem: 7:30h");
                    Console.WriteLine("Boa viagem!");
                    break;

                case 'C':
                    Console.WriteLine("Veiculo Escolhido Carro --- Tempo de viagem: 5:30h");
                    Console.WriteLine("Boa viagem!");
                    break;

                default:
                    Console.WriteLine("Opção inexistente!");
                    break;
            }

           

        }
    }
}
