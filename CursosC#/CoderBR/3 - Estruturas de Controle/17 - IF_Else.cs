using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle;

class EstruturaIF_Else
{
    public static void Executar()
    {
        Console.Write("Digita a nota: ");
        var entrada = Console.ReadLine();
        Double.TryParse(entrada, out double nota);

        if (nota >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        // na estrura if quando apenas uma linhas de código existe para ser executada não precisa de "{}" no C#
        else Console.WriteLine("Reprovado"); 
    }
}
