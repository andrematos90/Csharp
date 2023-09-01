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
        /* DiasSemana é um tipo que possue elementos pré definidos, ele só pode receber esses elementos,
         cada elemento tem um indice iniciando do 0*/
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        public static void Executar()
        {
            /*variavel "ds" recebe 3 convertido para Diassemana que retorna "quarta"
             recebe um tipo inteiro e converte para tipo Diassemana
             */ 
            DiasSemana ds = (DiasSemana)3;

            DiasSemana ds2 = (DiasSemana.Quarta); //variavel "ds" recebe  o elemento diretamente

            Console.WriteLine(ds);
            Console.WriteLine(ds2);


            int ds3 = (int)DiasSemana.Quarta; // converte tipo DiasSemana em tipo inteiro

            Console.WriteLine(ds3); 

            
        }
    }
}
