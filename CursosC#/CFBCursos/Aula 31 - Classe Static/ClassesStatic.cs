using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula31
{
    class ClassesStatic
    {
        static class Carro
        {
            public static string marca = "Renault";
            public static string modelo = "Twingo";
            public static int ano = 2001;
            public static bool importado = true;

            static public void  mostraPropriedades()
            {
                Console.WriteLine(marca);
                Console.WriteLine(modelo);
                Console.WriteLine(ano);
                Console.WriteLine(importado);

            }
 
        }
        public static void Executar()
        {
            Carro.mostraPropriedades();
           
       
        }
    }
}
