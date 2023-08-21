using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CFBCursos.Aula03
{
   class Variaveis
    {
        public static void Executar()
        {
            //tipos primitivos
            byte n1 = 10;
            int num = 0;
            char letra = 'a';
            float pi = 3.14f;

            string nome = "André";

            //usando o var o C# identifica automaticamente o tipo de acordo com o valor da variável
            var aux = 14;

            Console.WriteLine(nome);

        }
    }
}
