using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula35
{

    public class Veiculo
    {
        // Campos para informações gerais de veículos
        public string marca;
        public string modelo;
        public int motor;
        public bool ligado;
        private int rodas;

        // Construtor da classe Veiculo
        public Veiculo(int rodas)
        {
            this.marca = "Marca Indefinida";
            this.modelo = "Modelo Indefinido";
            this.motor = 0;
            this.ligado = false;
            this.rodas = rodas;
        }

        // Métodos para obter informações do veículo
        public string getLigado()
        {
            return ligado ? "Sim" : "Não";
        }

        public int getRodas()
        {
            return rodas;
        }
    }

    public class Carro : Veiculo
    {
        // Campos específicos de carros
        public string cor;

        // Construtor da classe Carro, chamando o construtor da classe base Veiculo
        public Carro(string modelo, string cor) : base(4)
        {
            this.modelo = modelo;
            this.cor = cor;
        }
    }

    public class Marca : Carro
    {
        // Campo adicional para nome da marca
        public string nomeDaMarca;

        // Construtor da classe Marca, chamando o construtor da classe base Carro
        public Marca() : base("Malibu", "Prata")
        {
            this.nomeDaMarca = "Chevrolet";
        }
    }

    class CadeiaHerançaConstrutorClasseBase
    {
        public static void Executar()
        {
            // Criando um objeto Carro
            Carro carro = new Carro("Twingo", "Prata");

            // Imprimindo informações do carro
            Console.WriteLine($"Modelo do Carro: {carro.modelo}");
            Console.WriteLine($"Número de rodas: {carro.getRodas()}");
            Console.WriteLine($"Carro está ligado? {carro.getLigado()}");

            // Criando um objeto Marca
            Marca novaMarca = new Marca();
            Console.WriteLine($"Modelo no carro: {novaMarca.modelo}");
            Console.WriteLine($"Marca do carro: {novaMarca.nomeDaMarca}");
        }
    }
}


/*
 Esse código cria uma hierarquia de classes onde Veiculo é a classe base, Carro herda de Veiculo, e Marca herda de Carro. Cada classe tem campos específicos e construtores que inicializam esses campos. O método Executar cria objetos das classes Carro e Marca e imprime informações sobre eles.

Namespace: O código está definido dentro do namespace CFBCursos.Aula35.

Classe Base - Veiculo:

A classe Veiculo é a classe base na hierarquia.
Ela possui campos públicos para armazenar informações sobre um veículo, como marca, modelo, motor, estado (ligado/desligado) e o número de rodas.
O construtor da classe Veiculo recebe um parâmetro rodas e inicializa os campos com valores padrão.
Ela também possui dois métodos públicos, getLigado e getRodas, para obter informações sobre o estado do veículo.
Classe Derivada - Carro:

A classe Carro herda da classe Veiculo. Isso significa que ela possui todos os campos e métodos da classe Veiculo, além de seus próprios campos, modelo e cor.
O construtor da classe Carro recebe os parâmetros modelo e cor, que são específicos para carros. Ele chama o construtor da classe base (Veiculo) usando base(4) para inicializar o número de rodas como 4.
Classe Derivada - Marca:

A classe Marca herda da classe Carro. Isso significa que ela herda todos os campos e métodos da classe Carro e, por extensão, da classe Veiculo.
O construtor da classe Marca não recebe parâmetros e chama o construtor da classe base (Carro) com valores "Malibu" e "Prata" para os campos modelo e cor, respectivamente.
Ela também possui um campo adicional nomeDaMarca.
Classe CadeiaHerançaConstrutorClasseBase:

Esta classe contém um método estático Executar, que é o ponto de entrada para o código de demonstração.
No método Executar, um objeto da classe Carro é criado com os parâmetros "Twingo" e "Prat" e, em seguida, são impressas informações sobre o carro, incluindo o modelo, o número de rodas e se o carro está ligado ou não.
Em seguida, um objeto da classe Marca é criado, e suas informações, como modelo e nome da marca, são impressas.
A hierarquia de classes demonstra como você pode usar herança para criar classes derivadas com base em uma classe base comum. Além disso, o código ilustra como os construtores são chamados em cada nível da hierarquia usando base.

 */