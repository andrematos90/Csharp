using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Operadores_Logicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var ExecutouTrabalho2 = false;

            bool comprouTV50 = executouTrabalho1 && ExecutouTrabalho2;
            Console.WriteLine("Comprou a Tv 50'? {0}", comprouTV50);

            var comprousorvete = executouTrabalho1 || ExecutouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", comprousorvete);

            var comprouTv32 = executouTrabalho1 ^ ExecutouTrabalho2;
            Console.WriteLine("Comprou a Tb 32'? {0}", comprouTv32);

            Console.WriteLine("Mais Saudável? {0}", !comprousorvete);
        }
    }
}

/* Operadores lógicos são usados para realizar operações lógicas em valores booleanos (verdadeiro ou falso) e para criar expressões condicionais mais complexas. Em C#, existem três operadores lógicos principais: AND, OR e NOT.

AND Lógico (&&):
O operador && é usado para realizar uma operação "E" lógica entre duas expressões. Ele retorna true somente quando ambas as expressões são verdadeiras.
Exemplo:

bool expressao1 = true;
bool expressao2 = false;
bool resultado = expressao1 && expressao2; // Resultado será false



OR Lógico (||):
O operador || é usado para realizar uma operação "OU" lógica entre duas expressões. Ele retorna true se pelo menos uma das expressões for verdadeira.
Exemplo:

bool expressao1 = true;
bool expressao2 = false;
bool resultado = expressao1 || expressao2; // Resultado será true


NOT Lógico (!):
O operador ! é usado para negar o valor de uma expressão, ou seja, inverte o valor booleano.
Exemplo:

bool expressao = true;
bool resultado = !expressao; // Resultado será false


Você também pode combinar esses operadores lógicos para criar expressões condicionais mais complexas. Por exemplo:

bool a = true;
bool b = false;
bool c = true;

bool resultado = (a && b) || (c && !b); // Resultado será true


Neste exemplo, a expressão a && b é false, a expressão c && !b é true, e o resultado final da expressão condicional é true porque pelo menos uma das expressões é verdadeira.

Operadores lógicos são fundamentais para controlar o fluxo de um programa, criar condições complexas e fazer avaliações condicionais em C#. Eles são frequentemente usados em instruções if, else, while, for e outras estruturas de controle de fluxo.*/