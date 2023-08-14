using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Operadores_Unarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            Console.WriteLine(numero1++);
            Console.WriteLine(--numero1);

            Console.WriteLine(numero1 ++ == --numero2); //numero2 será decremntado antes da comparação, numero 1 receberá "1" depois da comparação
        }
    }
}

/*
 * 
 * Em C#, operadores unários são aqueles que atuam em um único operando, ou seja, eles realizam uma operação em um valor único. Esses operadores podem ser aplicados a tipos numéricos, booleanos e ponteiros. Eles são usados para executar várias operações, como incremento, decremento, negação lógica, entre outros.

Aqui estão alguns exemplos de operadores unários em C#:



Operador de Incremento (++): Este operador aumenta o valor de uma variável em uma unidade.
int a = 5;
a++; // Agora 'a' é igual a 6




Operador de Decremento (--): Este operador diminui o valor de uma variável em uma unidade.
int b = 8;
b--; // Agora 'b' é igual a 7



Operador de Negativo (-): Este operador é usado para inverter o sinal de um valor numérico.
int c = 10;
int negC = -c; // negC é igual a -10



Operador de Negação Lógica (!): Este operador é usado para inverter o valor booleano de uma expressão.
bool isTrue = true;
bool isFalse = !isTrue; // isFalse é igual a false



Operador de Endereço (&): Este operador é usado para obter o endereço de uma variável na memória.
int x = 42;
int* ptr = &x; // 'ptr' agora contém o endereço de 'x'



Operador de Indireção (*): Este operador é usado para acessar o valor armazenado em um ponteiro.
int y = 100;
int* ptrY = &y;
int valueY = *ptrY; // 'valueY' conterá o valor 100



Operador de Cast (Conversão de Tipo): Embora não seja estritamente um operador unário, você também pode fazer conversões de tipo explícitas usando o operador de cast. Por exemplo:
double d = 3.14;
int i = (int)d; // Convertendo 'd' (double) para 'i' (int)


Lembre-se de que a aplicação correta dos operadores unários é importante para evitar comportamentos inesperados em seu código. Certifique-se de entender como eles funcionam e onde podem ser utilizados de forma apropriada.*/
