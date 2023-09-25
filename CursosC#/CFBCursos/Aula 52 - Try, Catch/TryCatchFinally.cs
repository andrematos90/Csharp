using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula52
{
    class TryCatchFinally
    {
        public static void Executar()
        {
            int res, n1 , n2;

            Console.WriteLine("Digite o n1: ");
            n1 = int.Parse((Console.ReadLine()));
            Console.WriteLine("Digite o n2: ");
            n2 = int.Parse((Console.ReadLine()));

            try
            {
                res = n1 / n2;
                Console.WriteLine(res);
            }catch (Exception erro) 
            {
                Console.WriteLine("ERRO!");
                Console.WriteLine(erro.Message);
            }finally 
            { Console.WriteLine("FIM");
            }
        }
    }
}
