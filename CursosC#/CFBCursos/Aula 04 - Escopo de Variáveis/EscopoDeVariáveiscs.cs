using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula04
{
    class EscopoDeVariaveis
    {
        public static void Executar()
        {
            Console.WriteLine("Em C#, o escopo de uma variável se refere à região do código onde a variável é acessível e válida. O escopo determina onde a variável pode ser declarada, inicializada e usada dentro de um programa. Existem vários níveis de escopo em C#, incluindo o escopo de bloco, escopo de método, escopo de classe e escopo global. Vou explicar cada um deles:\r\n\r\nEscopo de Bloco: Este é o nível mais básico de escopo e está associado a um bloco de código delimitado por chaves {}. Variáveis declaradas dentro de um bloco de código estão visíveis apenas dentro desse bloco. Isso significa que elas não podem ser acessadas fora do bloco onde foram declaradas. Um exemplo de escopo de bloco:\r\n\r\n\r\n{\r\n    int x = 10; // Variável x está visível apenas dentro deste bloco\r\n    Console.WriteLine(x);\r\n} // x não é mais acessível aqui\r\n\r\n\r\n\r\n\r\nEscopo de Método: As variáveis declaradas dentro de um método (função) estão acessíveis apenas dentro desse método. Elas não podem ser acessadas de fora do método. Isso permite que você use nomes de variáveis repetidos em diferentes métodos sem conflitos. Um exemplo de escopo de método:\r\n\r\n\r\nclass Program\r\n{\r\n    static void Main()\r\n    {\r\n        int y = 20; // Variável y está visível apenas dentro do método Main\r\n        Console.WriteLine(y);\r\n    } // y não é mais acessível aqui\r\n}\r\n\r\n\r\n\r\nEscopo de Classe: As variáveis declaradas no nível de classe (fora dos métodos) estão acessíveis para todos os métodos e blocos dentro dessa classe. Elas têm uma vida útil mais longa e podem armazenar informações que devem ser compartilhadas entre diferentes partes da classe. Um exemplo de escopo de classe:\r\n\r\n\r\nclass Calculator\r\n{\r\n    private int result; // Variável result está acessível em todos os métodos desta classe\r\n\r\n    public void Add(int a, int b)\r\n    {\r\n        result = a + b;\r\n    }\r\n}\r\n\r\n\r\n\r\nEscopo Global: Variáveis declaradas no escopo global são acessíveis em todo o programa, em todas as classes e métodos. No entanto, é uma boa prática evitar o uso excessivo de variáveis globais, pois isso pode tornar o código mais difícil de entender e manter.\r\n\r\n\r\nint globalVariable = 100; // Variável global acessível em todo o programa\r\n\r\nclass MyClass\r\n{\r\n    void MyMethod()\r\n    {\r\n        Console.WriteLine(globalVariable); // Acesso à variável global\r\n    }\r\n}\r\n\r\n\r\n\r\nÉ importante entender os diferentes níveis de escopo para evitar problemas como conflitos de nomes de variáveis e garantir uma organização clara do código. O uso adequado do escopo contribui para um código mais legível, modular e fácil de depurar.");
        }
    }
}
