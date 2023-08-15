using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Simba";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "André", "Jubileu", "Polengo" };

            foreach (var aluno in alunos) { Console.WriteLine(aluno); }

        }
    }
}


/*
 
A estrutura de controle foreach em C# é usada para iterar sobre os elementos de uma coleção, como arrays, listas, dicionários, entre outros. Ela permite que você percorra cada elemento da coleção sem precisar gerenciar explicitamente um contador ou índice. A sintaxe básica da estrutura foreach em C# é a seguinte:

foreach (tipo elemento in coleção)
{
    // Código a ser executado para cada elemento na coleção
}


Aqui está uma explicação detalhada da estrutura foreach em C#:

A palavra-chave foreach é seguida por um par de parênteses (). Dentro desses parênteses, você especifica o tipo da variável que irá armazenar cada elemento da coleção, seguido de um nome para essa variável.

Após os parênteses, você coloca a palavra-chave in seguida da coleção sobre a qual você deseja iterar.

O bloco de código dentro das chaves {} é executado para cada elemento na coleção.

A cada iteração, a variável especificada no cabeçalho do foreach é automaticamente atribuída ao elemento atual da coleção. O código dentro do bloco de código pode usar essa variável para acessar o elemento e realizar operações sobre ele.

Aqui está um exemplo simples de uso da estrutura foreach em C#:

string[] frutas = { "maçã", "banana", "laranja", "uva" };

foreach (string fruta in frutas)
{
    Console.WriteLine("Gosto de " + fruta);
}


Neste exemplo, o programa percorrerá o array de frutas e imprimirá uma mensagem para cada uma delas. A variável fruta no foreach receberá cada elemento do array em cada iteração.

A estrutura foreach é especialmente útil quando você deseja iterar sobre todos os elementos de uma coleção sem se preocupar com índices ou contadores. Ela melhora a legibilidade do código e reduz a chance de erros relacionados ao controle de índices. */
