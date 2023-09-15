using CFBCursos.Aula29;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula42
{

    class Veiculo
    {
        private int[] velMax = new int[5] {80, 120, 150, 90, 100};


        public int this[int index]
        {
            get
            {
                return velMax[index];
            }

            set
            {
                if (value > 150)
                {
                    velMax[index] = 150;
                }
                else if (value < 0)
                {
                    velMax[index] = 0;
                }
                else
                {
                    velMax[index] = value;
                }
            }
        }
    }
    class IndexadoresDeClasse
    {
        public static void Executar() 
        {
            Veiculo carro1 = new Veiculo();
            carro1[4] = 147;
            Console.WriteLine("Velocidaide : {0}", carro1[4]);
        }
        
    }
}

/*Classe Veiculo:

A classe Veiculo tem um campo privado chamado velMax, que é uma matriz (array) de inteiros com 5 elementos, representando as velocidades máximas de cinco veículos.
Em seguida, a classe Veiculo define um indexador público. O indexador permite acessar as velocidades máximas como se fossem elementos de uma coleção usando índices.
O indexador é declarado com a palavra-chave this e um índice inteiro, ou seja, public int this[int index]. Isso significa que você pode acessar os elementos da matriz velMax usando colchetes, como se fossem propriedades de uma classe.
O accessor get do indexador permite que você leia o valor da velocidade máxima de um veículo com base em um índice especificado.
O accessor set do indexador permite que você atribua um novo valor à velocidade máxima de um veículo com base no índice especificado.
Dentro do accessor set, há alguma lógica para garantir que as velocidades máximas estejam dentro de limites específicos (entre 0 e 150).
Classe IndexadoresDeClasse:

A classe IndexadoresDeClasse contém um método estático chamado Executar.
Dentro do método Executar, é criada uma instância da classe Veiculo chamada carro1.
Em seguida, o indexador é usado para definir a velocidade máxima do quarto veículo (índice 4) como 147.
Finalmente, o valor da velocidade máxima do quarto veículo é impresso no console.
Em resumo, este código demonstra o uso de um indexador em uma classe Veiculo que permite acessar e modificar as velocidades máximas dos veículos representados por essa classe. O indexador adiciona uma camada de abstração que facilita a interação com os dados internos da classe e permite que você adicione lógica personalizada para garantir que os valores estejam dentro de limites aceitáveis.*/