using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula05
{
    class OperadoresEOperacoes
    {
        public static void Executar()
        {
            Console.WriteLine("Em C#, os operadores são símbolos que realizam operações em variáveis e valores. Eles são usados para executar cálculos, comparações e outras manipulações em dados. Vou explicar os principais tipos de operadores em C#:\r\n\r\nOperadores Aritméticos:\r\nEsses operadores realizam operações matemáticas básicas em números.\r\n\r\n+: Adição\r\n-: Subtração\r\n*: Multiplicação\r\n/: Divisão\r\n%: Módulo (resto da divisão)\r\r\n\r\nOperadores de Atribuição:\r\nEsses operadores atribuem um valor a uma variável.\r\n\r\n=: Atribuição simples\r\n+=: Atribuição de adição (por exemplo, x += 5 é equivalente a x = x + 5)\r\n-=: Atribuição de subtração\r\n*=: Atribuição de multiplicação\r\n/=: Atribuição de divisão\r\n%=: Atribuição de módulo\r\n\r\nOperadores de Comparação:\r\nEsses operadores comparam valores e retornam um resultado booleano (true ou false).\r\n\r\n==: Igual a\r\n!=: Diferente de\r\n<: Menor que\r\n>: Maior que\r\n<=: Menor ou igual a\r\n>=: Maior ou igual a\r\r\n\r\nOperadores Lógicos:\r\nEsses operadores são usados para realizar operações lógicas entre valores booleanos.\r\n\r\n&&: E lógico (AND)\r\n||: Ou lógico (OR)\r\n!: Negação lógica (NOT)\r\n\r\nOperadores de Incremento e Decremento:\r\nEsses operadores aumentam ou diminuem o valor de uma variável em uma unidade.\r\n\r\n++: Incremento (aumenta o valor em 1)\r\n--: Decremento (diminui o valor em 1)\r\n\r\nOperadores de Bitwise:\r\nEsses operadores realizam operações bit a bit em números inteiros.\r\n\r\n&: AND bitwise\r\n|: OR bitwise\r\n^: XOR bitwise\r\n~: NOT bitwise\r\n<<: Deslocamento para a esquerda\r\n>>: Deslocamento para a direita\r\nOperador de Ternário:\r\nO operador ternário é uma forma concisa de expressar um condicional.\r\n\r\ncondition ? expression_if_true : expression_if_false\r\n\r\nOperadores de Membro:\r\nEsses operadores são usados para acessar membros de objetos.\r\n\r\n.: Acesso ao membro (por exemplo, objeto.Propriedade)\r\n->: Acesso ao membro de um ponteiro (usado em C# apenas com tipos gerenciados)\r\n\r\nOperadores de Tipo:\r\nEsses operadores são usados para verificar o tipo de um objeto.\r\n\r\nis: Verifica se um objeto é de um tipo específico\r\nas: Tenta converter um objeto para um tipo específico\r\n\r\nOutros Operadores:\r\nExistem outros operadores menos comuns, como operadores de indexação ([]), operadores de invocação de método (()), entre outros.\r\n\r\nA compreensão desses operadores é essencial para escrever e entender o código em C#. Eles são a base para a maioria das operações realizadas em programas e são usados em conjunto para criar lógica complexa e funcionalidades.");
        }
    }
}
