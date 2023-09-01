/*Você está desenvolvendo um sistema de reservas de passagens para uma companhia aérea. Crie um programa em C# que utiliza enums para lidar com diferentes tipos de classe de passagens (Econômica, Executiva e Primeira Classe).

Siga as instruções abaixo:

Declare um enum chamado ClassePassagem com os seguintes valores: Economica, Executiva e PrimeiraClasse.

Crie uma classe chamada Passagem que possui as seguintes propriedades:

NomePassageiro (string): O nome do passageiro.
Classe (ClassePassagem): A classe da passagem (use o enum que você criou).
Crie um método na classe Passagem chamado ExibirDetalhes que exiba os detalhes da passagem, incluindo o nome do passageiro e a classe.

No método Main do programa, crie três objetos Passagem com diferentes classes de passagens e nomes de passageiros.

Chame o método ExibirDetalhes para cada objeto Passagem criado para exibir os detalhes de cada reserva.

O objetivo deste exercício é praticar o uso de enums para representar diferentes tipos de dados e como eles podem ser usados em uma classe para representar objetos com atributos relacionados.*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{

    public enum ticketsClass
    {
        Economic,
        Executive,
        FirstClass,

    }

    public class Ticket
    {
        public string PassgenrsName { get; set; }
        public ticketsClass Class { get; set;}

        public void ShowDetais() {

            Console.WriteLine($"Passenger Name: {PassgenrsName}");
            Console.WriteLine($"Classe: {Class}");
        }
    }

    class Ex005
    {

        public static void Executar() {
            // Crie objetos Passagem e chame ExibirDetalhes para cada um
            Ticket ticket1 = new Ticket { PassgenrsName = "João", Class = ticketsClass.Economic };
            Ticket ticket2 = new Ticket { PassgenrsName = "Maria", Class = ticketsClass.Executive };
            Ticket ticket3 = new Ticket { PassgenrsName = "Pedro", Class = ticketsClass.FirstClass };

            ticket1.ShowDetais();
            ticket2.ShowDetais();
            ticket3.ShowDetais();
        }
       
    }
}


/*
 * correto e implementa com sucesso o uso de enums em C# para representar diferentes classes de passagens em um sistema de reservas de passagens. Aqui está uma revisão do seu código:

Você declarou um enum chamado ticketsClass para representar as classes de passagem.
Criou uma classe Ticket com propriedades PassgenrsName e Class para representar os detalhes de uma passagem.
Implementou um método ShowDetails na classe Ticket para exibir os detalhes de uma passagem.
No método Executar, você criou três objetos Ticket com diferentes classes de passagens e nomes de passageiros.
Em seguida, chamou o método ShowDetails para exibir os detalhes de cada passagem.
No geral, seu código demonstra o uso adequado de enums e classes em C# para representar e exibir informações sobre passagens em diferentes classes. Se você deseja expandir este exercício, pode considerar adicionar mais funcionalidades, como a capacidade de reservar e cancelar passagens.*/