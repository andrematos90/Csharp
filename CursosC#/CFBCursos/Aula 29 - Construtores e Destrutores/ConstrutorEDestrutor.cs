using CFBCursos.Aula29;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula29
{
    //cria a classe "Carro
    public class Carro
    {
        //inicializa as propriedades da classe 
        public string nome = "";
        public string modelo = "";
        public string marca = "";
        public bool ligado = false;
        public int qtCombustivel = 0;

        //Define o método construtor (que deve ter o mesmo nome da classe)
        public Carro(string nome1)  //(nome1 é o parametro que será passado ao método, não é a mesma variável que foi                            inicializada na classe)
        {
            //atribui valores as propriedades
            nome = nome1;
            modelo = "Twingo";
            marca = "Renault";
            ligado = true;
            qtCombustivel = 0;
        }

        //método destrutor
        ~Carro() {
            Console.WriteLine("Carro foi Limpo");
                
        }
    }


   class ConstrutorEDestrutor
    {
        public static void Executar()
        {
            Console.WriteLine("digite o nome do carro: ");
            string nomeDoCarro = Console.ReadLine();
            Console.WriteLine();

            //instancia um novo objeto com nome "carro" que é do tipo "Carro"  e passa como parametro "Dwingo")
            Carro carro = new Carro(nomeDoCarro);


            Console.WriteLine(carro.nome);
            Console.WriteLine(carro.modelo);
            Console.WriteLine(carro.marca);
            Console.WriteLine(carro.ligado);

        }
    }
}
