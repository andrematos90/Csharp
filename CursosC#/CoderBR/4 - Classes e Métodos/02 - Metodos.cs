using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.ClassesEMetodos
{
    class Metodos
    {
        public static void Executar()
        {
            Console.WriteLine("Em C#, um método é um bloco de código que realiza uma tarefa específica. Ele é um dos principais componentes de um programa C# e é usado para agrupar um conjunto de instruções relacionadas. Os métodos são usados para dividir a lógica do programa em partes mais gerenciáveis e reutilizáveis.\r\n\r\nAqui estão os principais elementos que compõem um método em C#:\r\n\r\nAssinatura do Método:\r\nA assinatura do método inclui seu nome, tipo de retorno, modificadores de acesso (como public, private, protected, etc.) e os parâmetros que ele recebe. A assinatura define como o método é chamado e como ele se comunica com o resto do programa.\r\n\r\nTipo de Retorno:\r\nTodo método em C# possui um tipo de retorno, que indica qual é o tipo de valor que o método irá retornar após sua execução. Pode ser qualquer tipo de dado válido em C#, incluindo tipos primitivos (como int, double, string, etc.), tipos personalizados (classes, structs, etc.) ou até mesmo void se o método não retornar nenhum valor.\r\n\r\nNome do Método:\r\nO nome do método identifica o método e é usado para chamá-lo posteriormente no código. Ele deve ser único dentro do escopo da classe.\r\n\r\nParâmetros:\r\nOs parâmetros são valores que você passa para o método quando o chama. Eles são especificados na assinatura do método e podem ser usados dentro do corpo do método para realizar cálculos ou operações.\r\n\r\nCorpo do Método:\r\nO corpo do método é onde o conjunto de instruções que realizam a tarefa específica do método é definido. Essas instruções são executadas quando o método é chamado.\r\n\r\nModificadores de Acesso:\r\nOs modificadores de acesso (como public, private, protected, etc.) determinam quais partes do programa podem acessar e chamar o método. Eles controlam a visibilidade do método em relação a outras partes do código.\r\n\r\nAqui está um exemplo simples de um método em C#:");

            Console.WriteLine("public class MinhaClasse\r\n{\r\n    // Método que soma dois números inteiros e retorna o resultado\r\n    public int Somar(int a, int b)\r\n    {\r\n        int resultado = a + b;\r\n        return resultado;\r\n    }\r\n\r\n    // Método principal (ponto de entrada do programa)\r\n    public static void Main()\r\n    {\r\n        MinhaClasse minhaInstancia = new MinhaClasse();\r\n        int resultadoSoma = minhaInstancia.Somar(5, 3);\r\n        Console.WriteLine(\"Resultado da soma: \" + resultadoSoma);\r\n    }\r\n}\r\n");

            Console.WriteLine("Neste exemplo, a classe MinhaClasse possui um método chamado Somar, que aceita dois números inteiros como parâmetros e retorna sua soma. O método Main é o ponto de entrada do programa, onde uma instância da classe é criada e o método Somar é chamado para obter o resultado da soma.\r\n\r\n\r\n\r\n");

            Console.WriteLine("MÉTODO SEM ENTRADA MAS COM RETORNO: ");

            Console.WriteLine("public class ExemploClasse\r\n{\r\n    // Método que gera um número aleatório e retorna o valor gerado\r\n    public int GerarNumeroAleatorio()\r\n    {\r\n        Random random = new Random();\r\n        int numeroAleatorio = random.Next(1, 101); // Gera um número entre 1 e 100\r\n        return numeroAleatorio;\r\n    }\r\n\r\n    // Método principal (ponto de entrada do programa)\r\n    public static void Main()\r\n    {\r\n        ExemploClasse exemplo = new ExemploClasse();\r\n        int numero = exemplo.GerarNumeroAleatorio();\r\n        Console.WriteLine(\"Número aleatório gerado: \" + numero);\r\n    }\r\n}\r\n");

            Console.WriteLine("Neste exemplo, a classe ExemploClasse possui um método chamado GerarNumeroAleatorio que não recebe nenhum parâmetro de entrada. O método cria uma instância da classe Random para gerar um número aleatório entre 1 e 100 e retorna esse número.\r\n\r\nNo método Main, uma instância da classe ExemploClasse é criada e o método GerarNumeroAleatorio é chamado para obter um número aleatório. O número gerado é então exibido no console.\r\n\r\r\n\r\n");


            Console.WriteLine("MÉTODO SEM ENTRADA E SEM RETONO:");

            Console.WriteLine("public class ExemploClasse\r\n{\r\n    // Método que imprime uma mensagem simples\r\n    public void ImprimirMensagem()\r\n    {\r\n        Console.WriteLine(\"Esta é uma mensagem de exemplo.\");\r\n    }\r\n\r\n    // Método principal (ponto de entrada do programa)\r\n    public static void Main()\r\n    {\r\n        ExemploClasse exemplo = new ExemploClasse();\r\n        exemplo.ImprimirMensagem();\r\n    }\r\n}\r\n");

            Console.WriteLine("Neste exemplo, a classe ExemploClasse possui um método chamado ImprimirMensagem que não recebe parâmetros de entrada e não retorna nenhum valor (declarado com void). O método simplesmente imprime uma mensagem no console.\r\n\r\nNo método Main, uma instância da classe ExemploClasse é criada e o método ImprimirMensagem é chamado para imprimir a mensagem.\r\n\r\nEsse tipo de método é útil quando você quer executar uma tarefa ou ação que não envolve calcular ou retornar um valor específico.\r\n\r\n\r\n\r\n");

            Console.WriteLine("MÉTODO COM ENTRADA MAS SEM RETONO");

            Console.WriteLine("public class ExemploClasse\r\n{\r\n    // Método que saúda o usuário com base no nome fornecido como parâmetro\r\n    public void Saudacao(string nome)\r\n    {\r\n        Console.WriteLine(\"Olá, \" + nome + \"! Bem-vindo.\");\r\n    }\r\n\r\n    // Método principal (ponto de entrada do programa)\r\n    public static void Main()\r\n    {\r\n        ExemploClasse exemplo = new ExemploClasse();\r\n        \r\n        Console.Write(\"Digite seu nome: \");\r\n        string nomeUsuario = Console.ReadLine();\r\n        \r\n        exemplo.Saudacao(nomeUsuario);\r\n    }\r\n}\r\n\r\n\r\n\r\n\r\n");

            Console.WriteLine("MÉTODO COM ENTRADA E COM RETORNO");

            Console.WriteLine("public class Calculadora\r\n{\r\n    // Método que recebe dois números e retorna sua soma\r\n    public int Somar(int a, int b)\r\n    {\r\n        return a + b;\r\n    }\r\n\r\n    // Método principal (ponto de entrada do programa)\r\n    public static void Main()\r\n    {\r\n        Calculadora calculadora = new Calculadora();\r\n        \r\n        Console.Write(\"Digite o primeiro número: \");\r\n        int numero1 = Convert.ToInt32(Console.ReadLine());\r\n        \r\n        Console.Write(\"Digite o segundo número: \");\r\n        int numero2 = Convert.ToInt32(Console.ReadLine());\r\n        \r\n        int resultadoSoma = calculadora.Somar(numero1, numero2);\r\n        Console.WriteLine(\"Resultado da soma: \" + resultadoSoma);\r\n    }\r\n}\r\n");

            Console.WriteLine("Neste exemplo, a classe Calculadora possui um método chamado Somar que aceita dois números inteiros como parâmetros de entrada. O método calcula a soma desses dois números e retorna o resultado.\r\n\r\nNo método Main, o programa solicita ao usuário que insira dois números. Os números são lidos a partir do console e passados como argumentos para o método Somar da instância da classe Calculadora. O resultado da soma é então exibido no console.\r\n\r\nEste é um exemplo simples de um método que aceita entrada e retorna um valor em C#.");
        }
    }
}
