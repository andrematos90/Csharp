using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderBR.Fundamentos
{
    class Comentarios
    {
        public static void Executar()
        {
            //Cuidadado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            Console.WriteLine("comentários de única linha //");
            Console.WriteLine("comentário de multiplas linhas /* */");
            Console.WriteLine("O C# tem o XML Comments");
            Console.WriteLine("para isso basta usar 3 barras ///");
            
        }
    }
}

/*
Em C#, assim como em outras linguagens de programação, os XML Comments (Comentários XML) são usados para documentar o código, mas de uma forma mais estruturada e formalizada. Eles permitem que você crie documentação para suas classes, métodos, propriedades, parâmetros e outros elementos do código de forma apropriada e padronizada.

Os comentários XML em C# são escritos em um formato específico dentro do código fonte, e eles são processados pelo compilador para gerar documentação legível para humanos. Essa documentação pode ser utilizada por ferramentas de desenvolvimento, como o Visual Studio, para fornecer informações contextuais, autocompletar, dicas de parâmetros e muito mais.

Aqui está um exemplo de como você pode usar os XML Comments em C#:


/// <summary>
/// Esta classe representa um exemplo de Comentário XML em C#.
/// </summary>
public class Exemplo
{
    /// <summary>
    /// Este é um método de exemplo que realiza uma operação.
    /// </summary>
    /// <param name="valor">O valor de entrada para a operação.</param>
    /// <returns>O resultado da operação.</returns>
    public int MetodoExemplo(int valor)
    {
        return valor * 2;
    }
}

Neste exemplo:

O /// é usado para indicar que você está começando um comentário XML.
<summary> é usado para fornecer um resumo descritivo da classe ou método.
<param> é usado para documentar os parâmetros do método, explicando o que eles representam.
<returns> é usado para documentar o valor de retorno do método.
Você pode adicionar outros elementos, como <remarks> para observações adicionais, ou <example> para fornecer exemplos de uso.
Quando você cria esses comentários XML em C#, as ferramentas de desenvolvimento, como o IntelliSense do Visual Studio, exibirão essas informações de documentação enquanto você escreve ou consulta o código, facilitando a compreensão e o uso das classes e métodos. Além disso, você pode usar ferramentas externas para gerar documentação formal a partir desses comentários XML, tornando-os uma parte importante da prática de desenvolvimento orientada a documentação.

*/