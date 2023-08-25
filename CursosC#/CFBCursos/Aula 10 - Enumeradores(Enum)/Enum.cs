using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CFBCursos.Aula10
{
    class Enumeradores
    {
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        public static void Executar()
        {
            DiasSemana ds = (DiasSemana)3;

            DiasSemana ds2 = (DiasSemana.Quarta);

            Console.WriteLine(ds);
            Console.WriteLine(ds2);


            int ds3 = (int)DiasSemana.Quarta;

            Console.WriteLine(ds3); 

            
        }
    }
}
