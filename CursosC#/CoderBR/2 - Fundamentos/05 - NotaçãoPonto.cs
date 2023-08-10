using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
     class Notacao_Ponto
    {
        public static void Executar()
        {
            var saudacao = "olá ".ToUpper().Insert(3, "World!").Replace("World!", " Mundo!");
            /* o resultado da chamada "olá".ToUpper() chama Insert(3, "World!") que chama .Replace("World", "Mundo!"); resultado que por fim é salvo na variável "saudacao"*/

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // ? depois da váriavel não a acessa se ela estive vazia 
        }
    }
}

/*
 * A notação de ponto em C# é uma sintaxe fundamental usada para acessar membros (métodos, propriedades, campos e eventos) de tipos (classes, estruturas, interfaces, etc.). É uma maneira de interagir com os membros públicos de um tipo e é uma característica fundamental da orientação a objetos e da programação em C#.

A notação de ponto é construída da seguinte maneira:

objeto.Membro


Onde:

objeto é uma instância de um tipo que possui membros.
Membro é o nome de um método, propriedade, campo ou evento pertencente a esse tipo.
Aqui estão alguns exemplos de como a notação de ponto é usada em C#:

Acessar um método:

string texto = "Olá, mundo!";
int comprimento = texto.Length; // Length é um método da classe string


Acessar uma propriedade:

DateTime dataAtual = DateTime.Now;
int ano = dataAtual.Year; // Year é uma propriedade da classe DateTime


Acessar um campo:

int numero = Math.PI; // PI é um campo estático da classe Math


Acessar um evento (geralmente usado em manipuladores de eventos):

botao.Click += Botao_Click; // Click é um evento do controle de botão


Chamar um método de um objeto:

List<int> numeros = new List<int>();
numeros.Add(42); // Add é um método da classe List<T>


A notação de ponto é uma maneira essencial de interagir com os membros de tipos em C# e é amplamente usada ao criar e manipular objetos. Ela permite acesso direto aos membros públicos de um tipo e é uma das bases da programação orientada a objetos, permitindo a criação de hierarquias de classes e a composição de objetos complexos.


