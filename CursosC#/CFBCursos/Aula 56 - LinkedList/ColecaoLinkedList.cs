using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula56
{
    class ColecaoLinkedList
    {
        public static void Executar()
        {
            LinkedList<string> lista  = new LinkedList<string>();

            lista.AddFirst("Avião");
            lista.AddFirst("Carro");
            lista.AddFirst("Navio");
            lista.AddFirst("Bicicleta");
            lista.AddLast("Trem");

            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }

            LinkedListNode<string> listanode;
            listanode = lista.FindLast("Navio").Next; //fim
            lista.AddAfter(listanode, "Patinete"); // Após
            listanode = lista.FindLast("Carro"); //antes
            lista.AddBefore(listanode, "patins");

            Console.WriteLine();
            Console.WriteLine();


            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
 * O código define uma classe chamada ColecaoLinkedList com um método estático Executar. Este método demonstra o uso da classe LinkedList em C# para criar uma lista duplamente encadeada e realizar operações nela. Aqui está uma explicação passo a passo do código:

Criação da lista:

É criada uma lista duplamente encadeada de strings chamada lista.
Cinco elementos são adicionados à lista usando o método AddFirst e AddLast. Isso resulta na seguinte ordem de elementos: Bicicleta, Navio, Carro, Avião e Trem.
Iteração pela lista e impressão dos elementos:

A lista é percorrida usando um loop foreach.
Cada elemento da lista é impresso no console, resultando na impressão dos elementos na ordem em que foram adicionados.
Inserção após o elemento "Navio":

Um nó da lista chamado listanode é definido para apontar para o elemento "Navio".
listanode = lista.FindLast("Navio").Next; move o nó listanode para o final da lista, pois Next aponta para o próximo nó.
"Patinete" é inserido após o nó listanode usando lista.AddAfter(listanode, "Patinete").
Inserção antes do elemento "Carro":

listanode é atualizado para apontar para o elemento "Carro" usando listanode = lista.FindLast("Carro");.
"patins" é inserido antes do nó listanode usando lista.AddBefore(listanode, "patins").
Reimpressão da lista após as operações de inserção:

A lista é percorrida novamente usando um loop foreach.
Cada elemento da lista é impresso no console, agora refletindo a ordem após as operações de inserção.
O resultado do código será a impressão da lista duplamente encadeada de strings após as operações de inserção. A ordem final dos elementos será: Bicicleta, Navio, Patins, Carro, Avião, Patinete, Trem.
*/