using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Inferência_de_Tipo
    {
        public static void Executar()
        {
            var nome = "andré";
            // nome = 123 após uma variável ter seu tipo inferido com base em um valor específico, o tipo da variável é fixo e não pode ser alterado

            Console.WriteLine(nome);


        }
    }
}


/*
 * A inferência de tipos em C# é um recurso da linguagem que permite ao compilador deduzir automaticamente o tipo de uma variável com base no valor atribuído a ela. Isso significa que você não precisa especificar explicitamente o tipo da variável, pois o compilador é capaz de determinar o tipo correto com base no contexto.

Esse recurso foi introduzido na linguagem a partir do C# 3.0 com a introdução do tipo var, que permite declarar uma variável sem especificar o tipo, mas o tipo é inferido automaticamente com base na expressão à direita da atribuição.

Aqui está um exemplo de inferência de tipos em C#:

var numero = 42; // O tipo da variável 'numero' será inferido como int
var texto = "Olá, mundo!"; // O tipo da variável 'texto' será inferido como string
var lista = new List<int>(); // O tipo da variável 'lista' será inferido como List<int>


No exemplo acima, o compilador é capaz de inferir os tipos das variáveis numero, texto e lista com base nos valores e expressões utilizados na inicialização.

A inferência de tipos pode tornar o código mais conciso e legível, especialmente em situações onde o tipo da variável é óbvio pelo contexto. No entanto, é importante usá-la com moderação e garantir que o código permaneça claro e compreensível para outros desenvolvedores.

Lembre-se de que a inferência de tipos é aplicada apenas no momento da compilação e não afeta o desempenho ou o comportamento em tempo de execução do programa.
