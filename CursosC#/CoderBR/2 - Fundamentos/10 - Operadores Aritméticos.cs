using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Operadores_Aritmeticos
    {
        public static void Executar()
        {
            //Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //cálculo imc

            double peso = 93;
            double altura = 1.68;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC: {imc}");

            //número par / impar

            int par = 34;
            int impar = 11;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar %2);

        }
    }
}

/*
 
Os operadores aritméticos são utilizados para realizar operações matemáticas básicas em valores numéricos. Eles permitem executar adições, subtrações, multiplicações, divisões e outras operações entre números. Aqui estão os principais operadores aritméticos em C#:

Adição (+): Realiza a soma de dois valores.
Exemplo:

int resultado = 5 + 3; // resultado será 8


Subtração (-): Realiza a diferença entre dois valores.
Exemplo:

int resultado = 10 - 4; // resultado será 6


Multiplicação (*): Realiza o produto de dois valores.
Exemplo:

int resultado = 6 * 3; // resultado será 18

Divisão (/): Realiza a divisão de dois valores.
Exemplo:

double resultado = 15.0 / 2.0; // resultado será 7.5


Módulo (%) : Retorna o resto da divisão entre dois valores.
Exemplo:

int resto = 10 % 3; // resto será 1


Incremento (++): Aumenta o valor de uma variável em uma unidade.
Exemplo:

int numero = 5;
numero++; // Agora, numero será 6


Decremento (--): Diminui o valor de uma variável em uma unidade.
Exemplo:

int numero = 8;
numero--; // Agora, numero será 7


Lembre-se de que os operadores aritméticos respeitam as regras de precedência matemática. Você também pode usar parênteses para controlar a ordem de avaliação das operações. Além disso, os operadores aritméticos podem ser combinados com atribuições para realizar operações compostas, como +=, -=, *= e /=.

Exemplo de operações compostas:

int valor = 10;
valor += 5; // Equivale a valor = valor + 5; (valor será 15)
valor *= 2; // Equivale a valor = valor * 2; (valor será 30)


Esses operadores aritméticos são fundamentais para realizar cálculos em programas C# e são amplamente utilizados em várias situações.*/

