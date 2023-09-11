using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula34
{
    public class Veiculo
    {
        public string marca;
        public string modelo;
        public int motor;
        public bool ligado;

        public Veiculo()
        {
            this.marca = "Marca Indefinida";
            this.modelo = "Modelo Indefinido";
            this.motor = 0;
            this.ligado = true;
        }
    }

    public class Carro : Veiculo // classe carro herdando a de Veiculo
    {
        public string nome;
        public string cor;

        public Carro(string nome, string cor) 
        {
            this.nome = nome;
            this.cor = cor;
        }
    }

    class Herança
    {
        public static void Executar()
        {
            Carro carro = new Carro("Twingo", "Prata");
            Console.WriteLine(carro.ligado); // consegue  acessar a propridade "ligado" da classe "Veiculo" pq a classe "Carro" herda os membros da classe Veiculo
        }
    }
}
