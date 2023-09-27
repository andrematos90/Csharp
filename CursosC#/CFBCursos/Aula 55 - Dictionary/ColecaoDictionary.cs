using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula55
{
    class ColecaoDictionary
    {
        public static void Executar()
        {
            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            veiculos.Add(1, "Carro");
            veiculos.Add(2, "Avião");
            veiculos.Add(3, "Navio");
            veiculos.Add(4, "Bicicleta");
            veiculos.Add(5, "Motocicleta");

            Console.WriteLine($"Quantidade de itens do Dictionay: {veiculos.Count}");



            //método "ContainsKey" verifica se a chave especificada existe
            int chave = 5;
            if (veiculos.ContainsKey(chave))
            {
                Console.WriteLine($"Chave: \"{chave}\" existe na coleção! ");
            }
            else
            {
                Console.WriteLine($"chave: \"{chave}\" não existe na coleção");
            }


            //método "ContainsValue" verifica se o valor especificado existe
            string valor = "Avião";

            if (veiculos.ContainsValue(valor))
            {
                Console.WriteLine($"Elemento: \"{valor}\" existe na coleção");
            }
            else
            {
                Console.WriteLine($"Elemento: \"{valor}\" não existe na coleção");
            }

            //método "Remove" exclui elemento baseado na chave
            veiculos.Remove(chave);

            //substituindo item do dictionary
            veiculos[2] = "Caminhão";

            //iterando sobre dictionary "veiculos"
            foreach (var key in veiculos.Keys)
            {
                string value = veiculos[key];
                Console.WriteLine(key + ":" + value);
            }

            //outra forma
            foreach(KeyValuePair<int, string> v in veiculos)
            {
                Console.WriteLine(v.Key + ":" + v.Value);
            }

            //outra forma

            Dictionary<int, String>.ValueCollection valores = veiculos.Values;
            foreach(string v in valores)
            {
                Console.WriteLine(v);
            }
  
        }
    }
}


