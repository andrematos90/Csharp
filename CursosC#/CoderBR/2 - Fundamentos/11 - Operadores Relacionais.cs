using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Operadores_Relacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Pode melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}

/*
 * 
 * Em C#, os operadores relacionais são usados para comparar valores entre si e determinar a relação entre eles. Esses operadores retornam um valor booleano (verdadeiro ou falso) com base na comparação feita. Aqui estão os principais operadores relacionais em C#:

Igual (==): Verifica se dois valores são iguais.
Exemplo:

int a = 5;
int b = 5;
bool resultado = a == b; // resultado será verdadeiro (true)


Diferente (!=): Verifica se dois valores são diferentes.
Exemplo:

int a = 7;
int b = 5;
bool resultado = a != b; // resultado será verdadeiro (true)



Maior que (>): Verifica se o valor à esquerda é maior que o valor à direita.
Exemplo:

int a = 10;
int b = 7;
bool resultado = a > b; // resultado será verdadeiro (true)


Menor que (<): Verifica se o valor à esquerda é menor que o valor à direita.
Exemplo:

int a = 3;
int b = 5;
bool resultado = a < b; // resultado será verdadeiro (true)


Maior ou igual que (>=): Verifica se o valor à esquerda é maior ou igual ao valor à direita.
Exemplo:

int a = 8;
int b = 8;
bool resultado = a >= b; // resultado será verdadeiro (true)


Menor ou igual que (<=): Verifica se o valor à esquerda é menor ou igual ao valor à direita.
Exemplo:

int a = 5;
int b = 7;
bool resultado = a <= b; // resultado será verdadeiro (true)


Esses operadores são frequentemente usados para controlar fluxos de decisão em programas C#. Eles são usados em instruções condicionais, como o "if" (se), para determinar quais partes do código serão executadas com base nas comparações realizadas. Por exemplo:

int idade = 18;
if (idade >= 18)
{
    Console.WriteLine("Pode votar!");
}
else
{
    Console.WriteLine("Não pode votar.");
}


Nesse exemplo, o operador relacional ">= (maior ou igual que)" é usado para verificar se a idade é maior ou igual a 18, determinando se a pessoa pode votar ou não.*/
