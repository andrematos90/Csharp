using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            //conversão implicita, não ocorre perda de informação
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);




            //conversão explicita (casting) pode haver perda de informação
            double nota = 9.7; 
            int notaTruncada = (int)nota; 
            Console.WriteLine("Nota truncada: {0}", notaTruncada);





            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();

            //se não for digitada uma string que se seja uma letra e não um número ocorre um erro
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado {0}", idadeInteiro);





            Console.Write("Digite o Primeiro número: ");
            string numeroString = Console.ReadLine();
            int numeroInteiro1;

            /*tenta converter "numeroString" para um inteiro e salvar na váriável "numeroInteiro1" se não conseguir colocar "0" que é o padrão*/
            int.TryParse(numeroString, out numeroInteiro1); 
            Console.WriteLine($"Resultado 1: {numeroInteiro1}");

            Console.Write("Digite o Segundo número: ");
            int.TryParse(Console.ReadLine(), out int numeroInteiro2);
            Console.WriteLine("Resultado 2: {0}", numeroInteiro2);



        }
    }
}


/*Em C#, a conversão de tipos, também conhecida como "casting", é o processo de converter um valor de um tipo de dado para outro tipo. Isso é frequentemente necessário quando você precisa realizar operações que envolvem diferentes tipos de dados ou quando deseja armazenar um valor de um tipo em uma variável de outro tipo.

Existem dois tipos principais de conversões de tipos em C#: conversões explícitas e conversões implícitas.

Conversão Explícita (Casting):
Uma conversão explícita ocorre quando você precisa converter um tipo de dado para outro tipo que não é diretamente compatível. Isso é feito usando o operador de cast "(" e ")". No entanto, nem todas as conversões explícitas são seguras, pois podem resultar em perda de dados ou erros em tempo de execução. Exemplo:

double numDouble = 10.5;
int numInt = (int)numDouble; // Conversão explícita de double para int



Conversão Implícita:
Uma conversão implícita ocorre quando você pode converter um tipo de dado para outro tipo de forma segura sem a necessidade de um operador de cast explícito. Geralmente, isso ocorre quando não há risco de perda de dados. Exemplo:

int numInt = 5;
float numFloat = numInt; // Conversão implícita de int para float


Além das conversões simples, o C# também fornece métodos especiais para conversão de tipos mais complexos, como o uso de métodos Convert.ToXxx para converter entre tipos numéricos e o método Parse para converter strings em tipos numéricos ou outros tipos.

string numStr = "123";
int parsedInt = int.Parse(numStr); // Convertendo uma string para int usando Parse


É importante lembrar que, embora as conversões de tipo sejam úteis, elas devem ser usadas com cuidado para evitar erros de tempo de execução e perda de dados. Sempre verifique se a conversão é segura para o contexto em que você está trabalhando.

Em resumo, a conversão de tipos em C# é uma técnica essencial para trabalhar com diferentes tipos de dados e realizar operações que envolvam tipos diversos. Ela permite que você transforme valores de um tipo para outro de maneira controlada, desde que seja feita de maneira adequada e consciente das implicações.



                                          CLASSE CONVERT


Em C#, a classe Convert faz parte do namespace System e oferece métodos estáticos para realizar conversões entre diferentes tipos de dados primitivos. Ela é especialmente útil quando você precisa converter valores entre tipos numéricos, tipos de data e hora, strings e outros tipos primitivos.

Aqui estão alguns dos principais métodos da classe Convert e suas funções:

Convert.ToType(): Esse método é usado para converter um valor de um tipo para outro tipo. Por exemplo:

int intValue = Convert.ToInt32("123");
double doubleValue = Convert.ToDouble("3.14");


Convert.ToString(): Converte um valor para sua representação em string.

int intValue = 42;
string stringValue = Convert.ToString(intValue);


Convert.ToBoolean(): Converte um valor em um tipo booleano.

string trueString = "True";
bool boolValue = Convert.ToBoolean(trueString);

Convert.ToDateTime(): Converte um valor em um tipo DateTime (data e hora).

string dateString = "2023-08-11";
DateTime dateValue = Convert.ToDateTime(dateString);

Convert.ToInt32(), Convert.ToDouble(), Convert.ToSingle(), Convert.ToDecimal(): Convertem valores em tipos numéricos específicos.

string intString = "42";
int intResult = Convert.ToInt32(intString);

A classe Convert lida automaticamente com exceções que podem ocorrer durante as conversões, como quando um valor não pode ser convertido para o tipo desejado. Nessas situações, uma exceção é lançada, como por exemplo, FormatException ou InvalidCastException.

Lembre-se de que a classe Convert é útil para conversões simples e diretas entre tipos primitivos. Para conversões mais complexas ou personalizadas, você pode precisar de abordagens diferentes, como o uso de Parse ou conversões explícitas entre tipos.*/




