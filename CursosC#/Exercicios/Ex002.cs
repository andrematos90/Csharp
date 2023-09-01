/*
Código em C# com um erro relacionado ao escopo de variáveis para você resolver:
Seu objetivo é fazer com que o código compile e imprima o valor da variável novoValor. Você precisará ajustar o escopo da variável para corrigir o erro. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex002
    {
        public static void Executar()
        {

            int valor = 10;
            int novoValor = 0; // para resolver o problema se declara e atribui um valor no inicio tornando global
            

            if (valor > 5)
            {
                novoValor = 20;
            }

            Console.WriteLine(novoValor); // Aqui ocorrerá um erro de compilação


        }
    }
}
