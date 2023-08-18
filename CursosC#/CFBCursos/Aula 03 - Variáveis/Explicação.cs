As variáveis representam locais de armazenamento. Cada variável tem um tipo que determina quais valores podem ser armazenados na variável. O c# é um idioma de tipo seguro, e o compilador C# garante que os valores armazenados em variáveis sejam sempre do tipo apropriado. O valor de uma variável pode ser alterado por atribuição ou pelo uso dos ++ operadores e --.

O C# define sete categorias de variáveis: variáveis estáticas, variáveis de instância, elementos de matriz, parâmetros de valor, parâmetros de referência, parâmetros de saída e variáveis locais. As seções a seguir descrevem cada uma dessas categorias.

class A
{
    public static int x;
    int y;

    void F(int[] v, int a, ref int b, out int c) {
        int i = 1;
        c = a + b++;
    }
}

x é uma variável estática, y é uma variável de instância, v[0] é um elemento de matriz, a é um parâmetro de valor, é um parâmetro de b referência, c é um parâmetro de saída e i é uma variável local.