using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula27
{
    class ArgumentoParams
    {
        public static void Executar()
        {
            Soma();
            Soma(5);
            Soma(4, 6, 70);

        }

        public static void Soma(params int[] ParametrosPassados)
        {
            int resultado = 0;


            if(ParametrosPassados.Length < 1) {
                 Console.WriteLine("Sem nenhum parâmetro para a soma");
            }
            else if(ParametrosPassados.Length < 2){
                Console.WriteLine("Número de parâmetros insuficientes para a soma (minimo dois)");
            }
            else
            {
                for (int i = 0; i < ParametrosPassados.Length; i++)
                {
                    resultado += ParametrosPassados[i];
                    
                }
                Console.WriteLine("Soma {0}", resultado);
  
            }
        }
    }
}
