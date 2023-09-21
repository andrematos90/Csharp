using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula48
{
    public class Calculadora
    {
        public int Fat(int numero)
        {
            int res;
            if (numero <= 1)
            {
                res = 1;
            }
            else
            {
               res = numero * Fat(numero - 1);
            }
            return res;
        }
    }
    class Recursividade
    {
        public static void Executar()
        {
            Calculadora contadeFAtorial = new Calculadora();

            int res = contadeFAtorial.Fat(5);
            Console.WriteLine(res);


        }
    }
}

/*No exemplo dado com Fat(5), a recursão não retorna sempre o valor "1". Na verdade, o resultado acumulado é calculado à medida que as chamadas recursivas são desenroladas. Vou explicar isso com mais detalhes:

Quando a função Fat(5) é chamada pela primeira vez, numero é igual a 5.

A função verifica a condição if (numero <= 1), que não é satisfeita (5 não é menor ou igual a 1), então a função entra no bloco else.

No bloco else, a função chama Fat(numero - 1), ou seja, Fat(4). Esta é uma chamada recursiva.

Agora, Fat(4) é executado, e o processo se repete. numero é igual a 4, e a função verifica a condição if (numero <= 1) (4 não é menor ou igual a 1), então novamente ela chama Fat(numero - 1), que é Fat(3).

Isso continua até que a função alcance Fat(1). Quando numero é igual a 1, a condição if (numero <= 1) é satisfeita. Neste ponto, a chamada recursiva pára e começa a retornar valores.

Quando Fat(1) retorna, ele retorna 1 (que é o caso base).

Agora, Fat(2) está esperando a resposta de Fat(1). Quando Fat(1) retorna 1, Fat(2) pode calcular seu resultado: res = numero * Fat(numero - 1), ou seja, res = 2 * 1, que é igual a 2.

O processo continua, com Fat(3) esperando Fat(2) e assim por diante.

Cada vez que uma chamada recursiva retorna, ela multiplica seu próprio numero pelo valor retornado pela chamada recursiva anterior.

Finalmente, o resultado é calculado em Fat(5). Quando Fat(4) retorna 24 (porque 4 * 6 = 24), Fat(5) calcula seu resultado como res = 5 * 24, que é igual a 120.

Portanto, o valor retornado em cada chamada recursiva não é sempre "1". O resultado é acumulado à medida que as chamadas recursivas são desenroladas e retornam seus próprios valores, multiplicados pelo numero atual na chamada atual. É assim que o resultado final é calculado corretamente, neste caso, o fatorial de 5 é 120.*/