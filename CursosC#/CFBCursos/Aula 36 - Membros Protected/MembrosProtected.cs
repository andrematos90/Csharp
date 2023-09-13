using CFBCursos.Aula34;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula36
{
    class Veiculo
    {
        public int velAtual;
        private int velMax; // private restringe o acesso ao membro a classe
        protected bool ligado; // protected permite o acesso aos membros tambem as classes derivadas (somente nas                           classes, não nos objetos instaciados dessas classes)

        public Veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public int getVelMax()
        {
            return velMax;
        }


    }

    class Carro:Veiculo
    {
        public string modelo;
        
        public Carro(string nomedomodelo,int velocidadeMaxima):base(velocidadeMaxima)
        {
            this.modelo = nomedomodelo;
            ligado=true; // "ligado pode ser acessado pq é "protected"
        }

        public bool getLigado()
        {
            return ligado;
        }

    }
    class MembrosProtected
    {
        public static void Executar()
        {
            Carro Twingo = new Carro("Hatch", 130);

            Console.WriteLine($"Nome do modelo: {Twingo.modelo}");
            Console.WriteLine($"Velocidade Atual: {Twingo.velAtual}");
            //Console.WriteLine($"Velocidade Máxima: {Twingo.velMax}"); Não consegue acessar diretamente velMAx
            Console.WriteLine($"Velocidade Máxima: {Twingo.getVelMax()}"); //consegue acessar através do método get
            Console.WriteLine($"Está Ligado? {Twingo.getLigado()}"); // também precisa de um método get para acessar                                                           em um objeto por ser proteced


        }
    }
}


/*Este código demonstra o uso de classes e membros com o modificador de acesso protected e public em C#. Vou explicar o código passo a passo:

namespace CFBCursos.Aula36: Isso define um namespace chamado "CFBCursos.Aula36" para organizar o código.

class Veiculo: Essa é a classe base que representa um veículo. Ela tem os seguintes membros:

public int velAtual: Uma variável pública que armazena a velocidade atual do veículo.

private int velMax: Uma variável privada que armazena a velocidade máxima do veículo. O modificador private restringe o acesso apenas à própria classe Veiculo.

protected bool ligado: Uma variável protegida que armazena o status de ligado/desligado do veículo. O modificador protected permite o acesso às classes derivadas (como Carro), mas não aos objetos instanciados dessas classes.

public Veiculo(int velMax): Um construtor público que recebe a velocidade máxima como parâmetro e inicializa as variáveis velAtual, velMax e ligado.

public int getVelMax(): Um método público que retorna o valor da velocidade máxima (velMax).

class Carro : Veiculo: Esta é uma classe derivada de Veiculo que herda suas propriedades e métodos. Ela também possui membros adicionais:

public string modelo: Uma variável pública que armazena o modelo do carro.

public Carro(string nomedomodelo, int velocidadeMaxima) : base(velocidadeMaxima): O construtor de Carro que recebe o modelo e a velocidade máxima como parâmetros. Ele chama o construtor da classe base Veiculo usando base(velocidadeMaxima) para inicializar as propriedades da classe base. Além disso, define ligado como true.

public bool getLigado(): Um método público que retorna o valor de ligado.

class MembrosProtected: Esta é uma classe com um método estático chamado Executar(), que demonstra o uso das classes Veiculo e Carro. No método Executar, ele cria uma instância de Carro chamada Twingo, acessa suas propriedades e métodos e imprime os valores.

O código demonstra o uso de herança, encapsulamento e acesso protegido em C#. Note que a variável velMax da classe base Veiculo não pode ser acessada diretamente a partir de uma instância de Carro devido ao modificador private, mas você pode acessá-la através do método público getVelMax(). Da mesma forma, a variável ligado é acessada através do método público getLigado().*/
