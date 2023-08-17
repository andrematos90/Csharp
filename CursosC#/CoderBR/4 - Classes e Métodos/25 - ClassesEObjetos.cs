using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.ClassesEMetodos
{
    class ClasseEObjetos
    {
        public static void Executar()
        {
            Console.WriteLine("Em C#, classes e objetos são conceitos fundamentais da programação orientada a objetos (POO). Eles formam a base para organizar e estruturar o código de maneira mais eficiente e reutilizável. Vamos entender melhor o que são classes e objetos:\r\n\r\nClasses:\r\nUma classe é um modelo ou plano para criar objetos. Ela define os atributos (propriedades) e comportamentos (métodos) que os objetos desse tipo terão. As classes são como um molde que descreve a estrutura e o comportamento dos objetos que serão criados com base nelas. Elas encapsulam dados e funcionalidades relacionados.\r\n\r\nAqui está um exemplo simples de como uma classe pode ser definida em C#:");

            Console.WriteLine("public class Pessoa\r\n{\r\n    // Atributos (propriedades)\r\n    public string Nome { get; set; }\r\n    public int Idade { get; set; }\r\n    \r\n    // Métodos\r\n    public void Apresentar()\r\n    {\r\n        Console.WriteLine($\"Olá, meu nome é {Nome} e tenho {Idade} anos.\");\r\n    }\r\n}\r\n");

            Console.WriteLine("Objetos:\r\nUm objeto é uma instância concreta de uma classe. Ou seja, ele é criado com base nas definições da classe e possui os atributos e métodos especificados por ela. Os objetos são as entidades reais que você manipula e interage em seu programa.\r\n\r\nAqui está como você pode criar e usar objetos com base na classe Pessoa definida acima:");

            Console.WriteLine("class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        // Criando objetos da classe Pessoa\r\n        Pessoa pessoa1 = new Pessoa();\r\n        pessoa1.Nome = \"João\";\r\n        pessoa1.Idade = 25;\r\n        \r\n        Pessoa pessoa2 = new Pessoa();\r\n        pessoa2.Nome = \"Maria\";\r\n        pessoa2.Idade = 30;\r\n        \r\n        // Chamando métodos dos objetos\r\n        pessoa1.Apresentar(); // Saída: Olá, meu nome é João e tenho 25 anos.\r\n        pessoa2.Apresentar(); // Saída: Olá, meu nome é Maria e tenho 30 anos.\r\n    }\r\n}\r\n");


            Console.WriteLine("Neste exemplo, você criou duas instâncias da classe Pessoa (ou seja, dois objetos) e atribuiu valores aos atributos Nome e Idade. Em seguida, você chamou o método Apresentar() em cada objeto para exibir informações sobre eles.\r\n\r\nEm resumo, classes definem a estrutura e o comportamento, enquanto objetos são instâncias específicas criadas com base nessas classes, permitindo a manipulação dos dados e a execução de ações definidas pelos métodos.");
        }
    }
}
