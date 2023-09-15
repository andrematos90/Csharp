using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula39
{
    abstract class Veiculo
    {
        protected int velMax;
        protected int velAtual;
        protected bool ligado;

        public Veiculo()
        {
            velMax = 150;
            velAtual = 0;
            ligado = false;
        }

        public void  setLigado(bool ligado)
        {
            this.ligado = ligado;
        }

        public bool  getLigado()
        {
            return ligado; ;
        }

        abstract public void setVelAtual(int velocidade);

        public int getVelocidade()
        {
            return velAtual;
        }

    }

    class Carro: Veiculo
    {
        public int rodas;

        public Carro()
        {
            rodas = 4;
        }

        override public void setVelAtual(int velocidade)
        {
            this.velAtual = velocidade;
            
        }


    }

   
    class MétodosAbstratos
    {
        public static void Executar()
        {
            Veiculo twingo = new Carro();
            twingo.setLigado(true);
            Console.WriteLine(twingo.getVelocidade());
            Console.WriteLine(twingo.getLigado());
           
            Carro fusca = new Carro();
            Console.WriteLine(fusca.rodas);

        }
    }
}

/*O código que você forneceu define um namespace chamado CFBCursos.Aula39 que contém três classes: Veiculo, Carro, e MétodosAbstratos. Vou explicar o que cada uma dessas classes faz:

Veiculo (Classe Abstrata):

Esta é uma classe abstrata que serve como base para veículos genéricos.
Ela possui três campos protegidos: velMAx (velocidade máxima), velAtual (velocidade atual) e ligado (indica se o veículo está ligado).
O construtor da classe Veiculo inicializa esses campos com valores padrão.
A classe possui métodos setLigado e getLigado para definir e obter o estado ligado do veículo.
Há um método abstrato chamado setVelAtual, que deve ser implementado nas classes derivadas.
Também existe um método getVelocidade para obter a velocidade atual do veículo.
Carro (Classe Derivada):

Esta é uma classe derivada da classe abstrata Veiculo.
Ela adiciona um campo rodas com valor padrão de 4 (indicando que é um carro de quatro rodas).
O construtor da classe Carro inicializa o número de rodas como 4.
Ela implementa o método abstrato setVelAtual da classe base.
MétodosAbstratos (Classe):

Esta classe contém um método estático chamado Executar.
No método Executar, é criada uma instância de Carro chamada twingo, que é tratada como um objeto do tipo Veiculo (devido à herança).
O método setLigado é chamado para definir o estado ligado como verdadeiro.
Em seguida, são impressas a velocidade atual e o estado ligado de twingo.
Outra instância de Carro chamada fusca é criada e o número de rodas do fusca é impresso.
Este código demonstra um exemplo de herança e uso de uma classe abstrata (Veiculo) como base para uma classe concreta (Carro). O método abstrato setVelAtual na classe Veiculo deve ser implementado em todas as classes derivadas, como feito na classe Carro. A classe MétodosAbstratos é usada para executar e demonstrar o funcionamento das classes anteriores.*/
