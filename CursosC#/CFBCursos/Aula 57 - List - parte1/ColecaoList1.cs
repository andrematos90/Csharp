using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula57
{
    class ColecaoList1
    {
        public static void Executar()
        {
            List<string> carros = new List<string>();
            List<string> carros2 = new List<string>();
            string[] carros3 = new string[10];

            //"Add" adiciona elementos a "carrps"
            carros.Add("Gol");
            carros.Add("Civic");
            carros.Add("Malibu");
            carros.Add("Twingo");
            carros.Add("Fusca");

            //adiciona todos os items de "carros" á "carros2"
            carros2.AddRange(carros);
            //carros2.Clear(); limpa a lista 


            // "Contains" verifica se "carros2" Contém "Fusca" 
            if (carros2.Contains("Fusca")){
                Console.WriteLine("Está na lista");
            }
            else
            {
                Console.WriteLine("Não está na lista");
            }

            Console.WriteLine();

            foreach(var carro in carros)
            {
                Console.WriteLine(carro);
            }

            Console.WriteLine();

            //copia para "carro3" os elementos de "carros2" apartir da posição "2"
            carros2.CopyTo(carros3,2);

            foreach (var carro in carros3)
            {
                Console.WriteLine(carro);
            }

            string car = "Malibu";
            int pos = 0;
            pos = carros.IndexOf(car); // "IndexOf retorna a posição do elemento
            Console.WriteLine($"{car} está na posição {pos}");
        }
    }
}
