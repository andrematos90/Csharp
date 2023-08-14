using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Operador_Ternario
    {
        public static void Executar()
        {
            var nota = 7.0;
            var bomComportamento = true;
            string resultado = nota >= 7 & bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}

/*
 * O operador ternário é um operador condicional presente em várias linguagens de programação, incluindo C#. Ele permite que você execute uma expressão condicional de forma concisa. O operador ternário é frequentemente utilizado quando você precisa tomar uma decisão simples com base em uma condição.

A sintaxe do operador ternário em C# é a seguinte:

condição ? expressão_se_verdadeira : expressão_se_falsa;


condição é a expressão booleana que é avaliada.
expressão_se_verdadeira é o valor ou a expressão que será retornada se a condição for verdadeira.
expressão_se_falsa é o valor ou a expressão que será retornada se a condição for falsa.
Aqui está um exemplo simples que ilustra o uso do operador ternário:

int idade = 18;
string mensagem = idade >= 18 ? "É maior de idade" : "É menor de idade";

Console.WriteLine(mensagem); // Saída: É maior de idade

Neste exemplo, a condição idade >= 18 é avaliada. Se a condição for verdadeira, a expressão após o ? será executada, e o resultado será atribuído à variável mensagem. Se a condição for falsa, a expressão após o : será executada e seu resultado será atribuído à variável mensagem.

O operador ternário é útil para simplificar o código quando você precisa tomar uma decisão simples. No entanto, lembre-se de que ele pode se tornar difícil de ler se for usado em expressões complexas. Use-o com moderação e certifique-se de que o código resultante ainda seja claro para quem o lê.
