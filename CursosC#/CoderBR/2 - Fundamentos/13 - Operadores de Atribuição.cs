using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Operadores_DeAtribuicao
    {
        public static void Executar()
        {
            var num = 3;
            num = 7;       
            num+= 10;       //mesmo que  num = num + 10
            num -= 3;     //mesmo que  num = num - 3
            num *= 5;    //mesmo que  num = num * 5
            num /= 2;   //mesmo que  num = num / 2

            Console.WriteLine(num);

            int a = 1;
            int b = a;

            a++; // a = a +1
            b--; // b= b-1

            Console.WriteLine($"{a} {b}");

            dynamic c  = new System.Dynamic.ExpandoObject();
            c.nome = "André";

            dynamic d = c;
            d.nome = "Simba";


            Console.WriteLine($"{c.nome}");
        }
    }
    
}

/*
 * 
 * os operadores de atribuição são usados para atribuir valores a variáveis ou expressões. Eles permitem que você atualize o valor de uma variável com base em um cálculo ou em outra variável. Aqui estão alguns dos operadores de atribuição mais comuns em C#:

Operador de Atribuição Simples (=): O operador de atribuição simples é usado para atribuir um valor a uma variável.


int x = 10; // 'x' recebe o valor 10



*Operadores de Atribuição com Operação (+=, -=, =, /=, %=): Esses operadores realizam uma operação aritmética entre o valor atual da variável e o valor à direita do operador, e, em seguida, atribuem o resultado de volta à variável.
*
*
*int y = 5;
y += 3; // Equivale a y = y + 3; (y agora é 8)
y -= 2; // Equivale a y = y - 2; (y agora é 6)
y *= 4; // Equivale a y = y * 4; (y agora é 24)
y /= 3; // Equivale a y = y / 3; (y agora é 8)
y %= 5; // Equivale a y = y % 5; (y agora é 3)


Operadores de Atribuição Bit a Bit (<<=, >>=, &=, |=, ^=): Esses operadores realizam operações bit a bit entre o valor atual da variável e o valor à direita do operador, e depois atribuem o resultado de volta à variável.


int flags = 0b0011;
flags <<= 1; // Equivale a flags = flags << 1; (flags agora é 0b0110)
flags >>= 1; // Equivale a flags = flags >> 1; (flags agora é 0b0011)
flags &= 0b0001; // Equivale a flags = flags & 0b0001; (flags agora é 0b0001)
flags |= 0b0100; // Equivale a flags = flags | 0b0100; (flags agora é 0b0101)
flags ^= 0b0010; // Equivale a flags = flags ^ 0b0010; (flags agora é 0b0111)



Operador de Atribuição de Null Condicionado (??=): Este operador atribui um valor a uma variável somente se a variável for null.

string name = null;
name ??= "John"; // Se 'name' for null, atribui "John" a 'name'



Operador de Atribuição de Valor Nulo (??): Este operador é usado para fornecer um valor padrão a uma variável se ela for null.

string city = null;
string defaultCity = "New York";
string selectedCity = city ?? defaultCity; // 'selectedCity' receberá "New York" porque 'city' é null

Esses operadores de atribuição são ferramentas poderosas para tornar seu código mais conciso e legível, permitindo que você execute operações de atribuição e cálculos em uma única linha de código. 




