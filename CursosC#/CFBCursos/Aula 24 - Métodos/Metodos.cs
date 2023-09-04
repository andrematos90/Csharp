using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula24
{
    class Metodos
    {
        public static void Executar()
        {
            //chamando métodos dentro do método principal
            Ola();

            //métodos com parâmetros
            int v1, v2;
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());

            Soma(v1, v2);
            Console.WriteLine($"A Subtração entre {v1} e {v2} é: {Subtrai(v1, v2)}");
        }

        public static void Ola()
        {
            Console.WriteLine("Hello World");
        }


        //método com retorn void (sem retorno)
        public static void Soma(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine($"A Soma de {n1} + {n2} é: {res}");
        }

        //métdo com retorno do tipo inteiro
        public static int Subtrai(int n1, int n2)
        {
            int res = n1 - n2;

            return res;

        }
    }
}

