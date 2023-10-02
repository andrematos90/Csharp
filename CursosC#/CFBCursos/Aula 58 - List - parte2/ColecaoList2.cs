using CFBCursos.Aula39;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula58
{
    class ColecaoList2
    {
        public static void Executar()
        {
            List<string> carros = new List<string>();

            //método insert, insere o item na lista na posição especificada
            carros.Insert(0, "Malibu");
            carros.Insert(1, "Fusca");
            carros.Insert(2, "Malibu");
            carros.Insert(3, "Fiat 147");
            carros.Insert(4, "Focus");
            carros.Insert(5, "Monza");


            //método IndexOf, retorna o indice do primeiro item que foi especificado
            int posPrimeiro = carros.IndexOf("Malibu");
            Console.WriteLine(posPrimeiro);

            Console.WriteLine();

            //método lastIndexOf, retorna o indice do ultimo item que foi especificado
            int posUltimo = carros.LastIndexOf("Malibu");
            Console.WriteLine(posUltimo);

            //método remove, remove da lista o item espeficado

            carros.Remove("Focus");

            //método removeAt, remove da lista o item do indice espeficado
            carros.RemoveAt(4);

            //método reverse, inverte a lista
            carros.Reverse();

            //método sort, ordena os elementos da lista em ordem alfabética
            carros.Sort();

            Console.WriteLine();
            //propriedade count retorna o tamanho da lista
            int tamanho = carros.Count;
            Console.WriteLine(tamanho);

            Console.WriteLine();
            //propriedad capacitu, retorna a capacidade de elementos que a lista pode ter 
            int capacidade = carros.Capacity;
            Console.WriteLine(capacidade);

            //determina a capacidade da lista
            carros.Capacity = 10;

            Console.WriteLine();
            foreach (string carro in carros)
            {
                Console.WriteLine(carro);
            }
        }
    }
}
