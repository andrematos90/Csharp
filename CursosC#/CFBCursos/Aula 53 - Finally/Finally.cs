using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula53
{
    class Area
    {
        public static float CalculaAreaDoQuadrado(float baseDoQuadrado, float alturaDoQuadrado)
        {
            if (baseDoQuadrado == 0 || alturaDoQuadrado == 0)
            {
                throw new Exception("Base ou Altura devem ser maiores do que \"0\"");
            }
            return baseDoQuadrado * alturaDoQuadrado;
        }

    }
    class Finally
    {
        public static void Executar()
        {
            float area = 0;

            try
            {
                area = Area.CalculaAreaDoQuadrado(10f, 0f);
                Console.WriteLine($"Área calculada: {area}");
            }
            catch(Exception e)
            {

                Console.WriteLine($"Erro gerado: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Fim do programa");
            }
           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int res, n1, n2;

            Console.WriteLine("Digite o n1: ");
            n1 = int.Parse((Console.ReadLine()));
            Console.WriteLine("Digite o n2: ");
            n2 = int.Parse((Console.ReadLine()));

            try
            {
                res = n1 / n2;
                Console.WriteLine("Resultado: {0}", res);
                throw new Exception("throw gera uma nova excessão, mesmo que nao de erro, força um erro");
            }
            catch (Exception erro)
            {
                Console.WriteLine("ERRO!");
                Console.WriteLine("Mensagem de erro:", erro.Message);
            }
            finally
            {

                Console.WriteLine("Finally é executando se houver erro e entrar no bloco catch," +
                    "ou se fucionar corretamente e entrar no bloco try.");
            }
        }
    }
}
